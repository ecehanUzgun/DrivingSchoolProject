using BLL.Services.Abstracts;
using BLL.Services.Concretes;
using Microsoft.AspNetCore.Mvc;
using MODEL.Entities;

namespace MVC.Controllers
{
    public class BranchController : Controller
    {
        private readonly IBranchService _branchService;
        public BranchController(IBranchService branchService)
        {
            _branchService = branchService;
        }
        public IActionResult Index()
        {
            return View(_branchService.GetActives());
        }

        // Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Branch branch)
        {
            try
            {
                await _branchService.CreateAsync(branch);
                TempData["Success"] = "Şube oluşturuldu.";
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
            var branch = _branchService.GetById(id);
            if (branch != null)
            {
                return View(branch);
            }

            TempData["Error"] = "Güncellenecek şube bulunamadı.";
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Update(Branch branch)
        {
            await _branchService.UpdateAsync(branch);
            return RedirectToAction("Index");
        }

        //Delete
        public async Task<IActionResult> Delete(int id)
        {
            var deletedBranch = _branchService.GetById(id);

            if (deletedBranch != null)
            {
                return View(deletedBranch);
            }

            TempData["Error"] = "Silinecek şube bulunamadı.";
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var branch = _branchService.GetById(id);
            if (branch != null)
            {
                await _branchService.DeleteAsync(branch);
                TempData["Success"] = "Şube silindi.";
            }

            TempData["Error"] = $"Silme işlemi gerçekleştirilemedi.";
            return RedirectToAction("Index");
        }
    }
}
