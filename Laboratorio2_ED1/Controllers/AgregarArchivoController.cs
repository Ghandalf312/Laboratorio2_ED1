using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using Laboratorio2_ED1.Controllers;
using Laboratorio2_ED1.Models.Storage;
using Laboratorio2_ED1.Models;
using Laboratorio2_ED1.Controllers;
using Microsoft.VisualBasic.FileIO;
using System.IO;
using System.Web;
using HttpPostedFileHelper;
using System.Configuration;


namespace Laboratorio2_ED1.Controllers
{
    public class AgregarArchivoController : Controller
    {
        // GET: AgregarArchivoController
        public ActionResult Index()
        {
            return View();
        }

        // GET: AgregarArchivoController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AgregarArchivoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AgregarArchivoController/Create
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

        // GET: AgregarArchivoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AgregarArchivoController/Edit/5
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

        // GET: AgregarArchivoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AgregarArchivoController/Delete/5
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

        

         [HttpGet]
        public ActionResult SubirArchivo()
        {
            return View();
        }



        [HttpPost]
        public ActionResult SubirArchivo(IFormFile file)
        {
            string _path = "";
            string _FileName = "";
            try
            {

                if (file.Length > 0)
                {
                    _FileName = Path.GetFileName(file.FileName);
                    _path = Path.Combine(server.MapPath("~/Archivos"), _FileName);
                    file.SaveAs(_path);
                    Console.WriteLine(_FileName + ", " + _path);
                }

                ViewBag.Message = "Archivo subido exitosamente!";
                using (TextFieldParser parser = new TextFieldParser(_path))
                {
                    parser.TextFieldType = FieldType.Delimited;
                    parser.SetDelimiters(",");
                    while (!parser.EndOfData)
                    {
                        string[] fields = parser.ReadFields();
                        if (fields[0] != "id")
                        {
                            var medicamento = new MedicamentoExtModel
                            {
                                Id = int.Parse(fields[0]),
                                Nombre = fields[1],
                                Descripcion = fields[2],
                                CasaProd = fields[3],
                                Precio = double.Parse(fields[4].Substring(1, fields[4].Length - 1)),
                                Existencia = int.Parse(fields[5]),
                            };


                            Singleton.Instance.misMedicamentosExt.Add(medicamento);
                            Singleton.Instance.miArbolMedicamentos.Add(medicamento);
                        }
                    }
                }
                return RedirectToAction("Index", "Medicamento");
            }
            catch
            {
                ViewBag.Message = "No se pudo subir el archivo";
                return View();
            }




        }
    }
}
