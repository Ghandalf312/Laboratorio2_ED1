using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Laboratorio2_ED1.Models.Storage;

namespace Laboratorio2_ED1.Controllers
{
    public class OrdenPedidoController : Controller
    {
        // GET: OrdenPedidoController
        public ActionResult Index()
        {
            return View();
        }

        // GET: OrdenPedidoController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: OrdenPedidoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OrdenPedidoController/Create
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
                TempData["nombre"] = Singleton.Instance.miCliente.Nombre;
                double total = 0;
                foreach (var item in Singleton.Instance.miPedido)
                {
                    total += item.Precio * item.Existencia;
                }
                TempData["total"] = "$ " + total;
                return View(Singleton.Instance.miPedido);
            }
        }


        public ActionResult ConfirmarP(string tag)
        {
            Singleton.Instance.miPedido.Clear();
            return RedirectToAction("Index", "Medicamento");
        }


        // GET: OrdenPedidoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: OrdenPedidoController/Edit/5
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

        // GET: OrdenPedidoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: OrdenPedidoController/Delete/5
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
