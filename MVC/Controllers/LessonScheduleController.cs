using BLL.Services.Abstracts;
using Microsoft.AspNetCore.Mvc;
using MODEL.Entities;

namespace MVC.Controllers
{
    public class LessonScheduleController : Controller
    {
        private readonly IScheduleService _scheduleService;
        private readonly IStudentService _studentService;
        private readonly ITeacherService _teacherService;
        public LessonScheduleController(IScheduleService scheduleService, IStudentService studentService, ITeacherService teacherService)
        {
            _scheduleService = scheduleService;
            _studentService = studentService;
            _teacherService = teacherService;
        }
        public async Task<IActionResult> Index()
        {
            //Tüm ders programlarını detaylarıyla al
            var schedules = await _scheduleService.GetAllSchedulesWithDetailAsync();

            //ViewBag ile öğretmen ve öğrenci listesini gönder
            ViewBag.Teachers = await _teacherService.GetAllTeachersAsync();
            ViewBag.Students = _studentService.GetStudentsWithRemainingHours();

            return View(schedules);
        }

        [HttpGet]
        public async Task<IActionResult> FilterLessonSchedules(int? teacherId, int? studentId)
        {
            try
            { 
                var schedules = await _scheduleService.GetAllSchedulesWithDetailAsync();

                if (teacherId.HasValue)
                {
                    schedules = schedules.Where(s => s.TeacherId == teacherId.Value).ToList();
                }

                if (studentId.HasValue) 
                {
                    schedules = schedules.Where(s => s.StudentId == studentId.Value).ToList();
                }

                var result = schedules.Select(s => new
                {
                    Teacher = s.Teacher?.Name,
                    Student = s.Student?.Name,
                    LessonDate = s.LessonDate.ToString("dd.MM.yyyy"),
                    StartTime = s.StartTime.ToString(@"hh\:mm"),
                    CourseHours = s.Student?.CourseHours ?? 0
                });

                return Json(result);
            }
            catch (Exception ex) 
            {
                return StatusCode(500, "Filtreleme sırasında bir hata oluştu.");
            }
        }
    }
}
