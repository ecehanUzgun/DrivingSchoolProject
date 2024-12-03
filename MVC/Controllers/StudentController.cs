using BLL.Services.Abstracts;
using Microsoft.AspNetCore.Mvc;
using MODEL.Entities;

namespace MVC.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentService _studentService;
        private readonly IBranchService _branchService;
        public StudentController(IStudentService studentService, IBranchService branchService)
        {
            _studentService = studentService;
            _branchService = branchService;
        }

        //Read
        public IActionResult Index()
        {
            return View(_studentService.GetActives());
        }

        //Create
        public IActionResult Create() 
        {
            ViewBag.Branches = _branchService.GetActives();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Student student)
        {
            try
            {
                await _studentService.CreateAsync(student);
                TempData["Success"] = "Öğrenci oluşturuldu.";
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                TempData["Error"] = ex.Message;
                return View();
            }
        }

        //Update
        public IActionResult Update(int id) 
        {
            var student = _studentService.GetById(id);
            if (student != null) 
            {
                ViewBag.Branches = _branchService.GetActives();
                return View(student);
            }

            TempData["Error"] = "Güncellenecek öğrenci bulunamadı.";
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Update(Student student) 
        { 
            await _studentService.UpdateAsync(student);
            return RedirectToAction("Index");
        }

        //Delete
        public async Task<IActionResult> Delete(int id) 
        { 
            var deletedStudent = _studentService.GetById(id);

            if (deletedStudent != null) 
            {
                return View(deletedStudent);
            }

            TempData["Error"] = "Silinecek öğrenci bulunamadı.";
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var student = _studentService.GetById(id);
            if (student != null) 
            { 
                await _studentService.DeleteAsync(student);
                TempData["Success"] = "Öğrenci silindi.";
            }

            TempData["Error"] = $"Silme işlemi gerçekleştirilemedi.";
            return RedirectToAction("Index");
        }
    }
}
