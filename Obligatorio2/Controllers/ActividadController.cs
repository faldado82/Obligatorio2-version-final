using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ObligatorioP2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Obligatorio2.Controllers
{
    public class ActividadController : Controller
    {
        Sistema s = Sistema.GetSistema();

        public IActionResult Index()
        {
            List<Actividad> actividadesList = s.GetActividades();
            ViewBag.actividadesList = actividadesList;
     
            return View();
        }

        // Cantidad de ME GUSTA
        public IActionResult MeGusta(int id)
        {         
            if (HttpContext.Session.GetString("logueadoRol") == "Cliente")
            {
            Actividad a = s.GetActividad(id);
            s.RegistrarMeGusta(a);
            }
            return RedirectToAction("Index");
        }

        
    }
}
