using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ObligatorioP2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Obligatorio2.Controllers
{
    public class CompraController : Controller
    {

        Sistema s = Sistema.GetSistema();
        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("logueadoRol") == "Cliente")
            {
                int? idUsuarioLogueado = HttpContext.Session.GetInt32("logueadoId");
                List<Compra> comprasList = s.GetComprasDeUsuario(idUsuarioLogueado);

                ViewBag.comprasList = comprasList;                            
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        public IActionResult CompraUsuario(int id)
        {
            if (HttpContext.Session.GetString("logueadoRol") == "Cliente")
            {
                Actividad a = s.GetActividad(id);
                ViewBag.ActividadComprada = a;
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        [HttpPost]
        public IActionResult CompraUsuario(int id, int canEnt)
        {
            if (HttpContext.Session.GetString("logueadoRol") == "Cliente")
            {
                Actividad a = s.GetActividad(id);
                ViewBag.ActividadComprada = a;
                int? idUsuarioLogueado = HttpContext.Session.GetInt32("logueadoId");
                DateTime fechaCompra = DateTime.Now;
                double precioF = a.precioFinal() * canEnt;
                Usuario u = s.GetUsuario(idUsuarioLogueado);
                Compra nueva = s.AltaCompra(a, canEnt, u, fechaCompra, precioF);
                //ViewBag.PrecioCompra = nueva.PrecioFinal;

                if (nueva != null)
                {
                    ViewBag.MensajeCompra = "Compra realizada con exito";
                }
                else
                {
                    ViewBag.MensajeCompra = "Error en la compra";
                }
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        public IActionResult CancelarCompra(int id)
        {

            Compra c = s.GetCompra(id);
            if (s.RegistrarCancelacion(c))
            {
                ViewBag.Cancelado = "Cancelación exitosa";
            }
            else
            {
                ViewBag.Cancelado = "Problema al cancelar (verifique que la fecha de la actividad sea al menos 24 horas mayor a la actual).";
            }
           
            return RedirectToAction("Index");
        }




    }
}
