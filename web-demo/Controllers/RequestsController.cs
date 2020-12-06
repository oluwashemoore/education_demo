
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace web_demo.Controllers
{
    public class RequestsController : Controller
    {
        // GET: Requests
        public ActionResult Index()
        {
            return View();
        }

        // GET: Requests/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Requests/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Requests/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Requests/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Requests/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Requests/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Requests/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}