using BLL.Services.Abstracts;
using Microsoft.AspNetCore.Mvc;

namespace MVC.Controllers
{
    public class LessonScheduleController : Controller
    {
        private readonly IStudentService _studentService;
        private readonly ITeacherService _teacherService;
        private readonly IScheduleService _scheduleService;
        public LessonScheduleController(IStudentService studentService, ITeacherService teacherService)
        {
            _studentService = studentService;
            _teacherService = teacherService;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
