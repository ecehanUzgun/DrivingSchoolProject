using BLL.Services.Abstracts;
using Microsoft.AspNetCore.Mvc;

namespace MVC.Controllers
{
    public class TeacherController : Controller
    {
        private readonly ITeacherService _teacherService;
        public TeacherController(ITeacherService teacherService)
        {
            _teacherService = teacherService;
        }
        public IActionResult Index()
        {
            return View(_teacherService.GetActives());
        }

        //Create

        //Update

        //Delete
    }
}
