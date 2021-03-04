using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Laboratorio2_ED1.Models.Storage;
using Laboratorio2_ED1.Models;
using PagedList;
//Paquete de nugget, PagedList.MVC https://albertcapdevila.net/paginar-mvc5/

namespace Laboratorio2_ED1.Controllers
{
    public class MedicamentoController : Controller
    {
        // GET: Medicamento
        public ActionResult Index(int? page)
        {
            if (Request.Method != "GET")
            {
                page = 1;
            }
            int pageSize = 25;
            int pageNumber = (page ?? 1);
            return View(Singleton.Instance.miArbolMedicamentos.ObtenerLista().ToPagedList(pageNumber, pageSize));
        }
        [HttpPost]
        public ActionResult Index(int? page, IFormCollection collection)
        {
            if (Request.Method != "GET")
            {
                page = 1;
            }
            int pageSize = 25;
            int pageNumber = (page ?? 1);

            var name = collection["search"];
            return View(MedicamentoModel.Filter(name).ToPagedList(pageNumber, pageSize));
        }
    }
}
