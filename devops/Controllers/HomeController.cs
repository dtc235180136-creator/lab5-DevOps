using devops.Models;
using devops.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace devops.Controllers
{
    public class HomeController : Controller
    {
        private readonly StudentStore studentStore;

        public HomeController(StudentStore studentStore)
        {
            this.studentStore = studentStore;
        }

        public IActionResult Index(string? keyword)
        {
            ViewData["Keyword"] = keyword;
            return View(studentStore.Search(keyword));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Add(Student student)
        {
            if (!ModelState.IsValid)
            {
                return View("Index", studentStore.Search(null));
            }

            if (!studentStore.Add(student))
            {
                ModelState.AddModelError(nameof(Student.StudentId), "Mã sinh viên đã tồn tại.");
                return View("Index", studentStore.Search(null));
            }

            TempData["SuccessMessage"] = $"Đã thêm sinh viên {student.Name} thành công.";
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
