using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;
using Week2.Models;

namespace Week2.Controllers
{
    public class StudentTestController : Controller
    {
        static IList<Student> std = new List<Student>
            {
                new Student { id = 1, age = 23, name = "Yatish", sex ='M' }
            };
        // GET: StudentTestController
        public ActionResult Index()
        {
            return View();
        }

        // GET: StudentTestController/Details/5
        public ActionResult Details(int id)
        {
            return View(std);
        }

        // GET: StudentTestController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StudentTestController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Student collection)
        {
            try
            {
                std.Add(collection);
                return RedirectToAction(nameof(Details));
            }
            catch
            {
                return View();
            }
        }

        // GET: StudentTestController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: StudentTestController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StudentTestController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: StudentTestController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
