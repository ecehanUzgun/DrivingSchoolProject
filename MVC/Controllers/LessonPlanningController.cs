using BLL.Services.Abstracts;
using Microsoft.AspNetCore.Mvc;

namespace MVC.Controllers
{
    public class LessonPlanningController : Controller
    {
        private readonly ITeacherService _teacherService;
        private readonly IStudentService _studentService;
        private readonly IScheduleService _scheduleService;
        private readonly IBranchService _branchService;
        public LessonPlanningController(ITeacherService teacherService, IStudentService studentService, IScheduleService scheduleService, IBranchService branchService)
        {
            _teacherService = teacherService;
            _studentService = studentService;
            _scheduleService = scheduleService;
            _branchService = branchService;
        }

        // Ana ekran: Öğretmen seçimi, tarih ve saat işlemleri
        public async Task<IActionResult> Index()
        {
            var branches = await _branchService.GetAllBranchesAsync();
            var teachers = await _teacherService.GetAllTeachersAsync();
            var students =  _studentService.GetStudentsWithRemainingHours();
            ViewBag.Teachers = teachers;
            ViewBag.Students = students;    
            ViewBag.Branches = branches;
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> GetStudentsByBranch(int? branchId)
        {
            var students = await _branchService.GetStudentsByBranchId(branchId);
            return Json(students.Select(s => new
            {
                id = s.ID,
                name = s.Name,
                surname = s.Surname,
                courseHours = s.CourseHours
            }));
        }

        // Seçilen öğretmenin uygun tarihlerini getir
        public async Task<IActionResult> GetAvailableDates(int teacherId)
        {
            var availableDates = await _teacherService.GetAvailableDatesAsync(teacherId);

            if (availableDates == null || !availableDates.Any())
            {
                return Json(new { success = false, message = "Müsait tarih bulunamadı."});
            }

            return Json(availableDates);
        }

        // Seçilen tarihe göre öğretmenin uygun saatlerini getir.
        public async Task<IActionResult> GetAvailableHours(int teacherId, DateTime date)
        {
            try
            {
                var availableHours = await _teacherService.GetAvailableHoursAsync(teacherId, date);
                return Json(availableHours);
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = ex.Message });
            }
        }

        [HttpPost]
        public async Task<IActionResult> AddLesson(int teacherId, int studentId, DateTime date, TimeSpan startTime)
        {
            try
            {
                // Hem öğretmen hem de öğrenci için çakışma kontrolü
                var isTimeAvailable = await _teacherService.IsTimeAvailableAsync(teacherId, studentId, date, startTime);

                if (!isTimeAvailable)
                {
                    return Json(new { success = false, message = "Seçilen tarih ve saatte öğrencinin zaten dersi var." });
                }

                // Eğer çakışma yoksa dersi ekle
                var result = await _scheduleService.AddLessonAsync(teacherId, studentId, date, startTime);
                if (result)
                {
                    return Json(new { success = true, message = "Ders başarıyla atandı." });
                }
                else
                {
                    return Json(new { success = false, message = "Ders atama işlemi başarısız oldu!" });
                }
            }
            catch (Exception ex)
            {
                // Hata mesajını loglayın ve kullanıcıya döndürün
                Console.WriteLine(ex.Message);
                Console.WriteLine("Inner Exception: " + ex.InnerException?.Message);
                return Json(new { success = false, message = "Bir hata oluştu: " + ex.Message });
            }
        }

    }
}
