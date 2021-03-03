﻿using Laboratorio2_ED1.Models.Storage;
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
            foreach (var item in Singleton.Instance.misMedicamentosExt)
            {
                if (item.Existencia == 0)
                {
                    Singleton.Instance.miAsbastecer.Add(item);
                }
            }
            return View(Singleton.Instance.miAsbastecer);
        }


        public ActionResult ReAbastecer(string tag)
        {
            Random rnd = new Random();

            foreach (var item in Singleton.Instance.miAsbastecer)
            {
                var std = Singleton.Instance.misMedicamentosExt.Where(s => s.Id == item.Id).FirstOrDefault();
                if (std.Existencia == 0)
                {
                    std.Existencia = rnd.Next(1, 15);
                    Singleton.Instance.miArbolMedicamentos.Add(std);
                }
            }
            return RedirectToAction("Index");
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
