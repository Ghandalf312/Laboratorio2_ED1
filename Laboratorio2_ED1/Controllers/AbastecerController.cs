using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Laboratorio2_ED1.Controllers
{
    public class AbastecerController : Controller
    {
        // GET: AbastecerController
        public ActionResult Index()
        {
            return View();
        }

        // GET: AbastecerController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AbastecerController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AbastecerController/Create
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

        // GET: AbastecerController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AbastecerController/Edit/5
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

        // GET: AbastecerController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AbastecerController/Delete/5
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
