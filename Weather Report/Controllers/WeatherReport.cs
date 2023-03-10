using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Weather_Report.Controllers
{
    public class WeatherReport : Controller
    {
        // GET: WeatherReport
        public ActionResult Index()
        {
            return View();
        }

        // GET: WeatherReport/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: WeatherReport/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: WeatherReport/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: WeatherReport/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: WeatherReport/Edit/5
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

        // GET: WeatherReport/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: WeatherReport/Delete/5
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
