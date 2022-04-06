using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ObligatorioP2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Obligatorio2.Controllers
{
    public class UsuarioController : Controller
    {
        Sistema s = Sistema.GetSistema();
        public IActionResult Index()
        {
            List<Actividad> actividadesList = s.GetActividades();
            ViewBag.actividadesList = actividadesList;

            if (HttpContext.Session.GetString("logueadoNombreUsuario") != null) {
                ViewBag.Logueado = "Ingresado con exito";
                return RedirectToAction("Index", "Actividad");
            }

            return View();
        }

        // ActionResult REGISTRO
        public IActionResult Registro()
        {
            if(HttpContext.Session.GetString("logueadoNombreUsuario") == null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
           
            
        }

        [HttpPost]
        public IActionResult Registro(string nombre, string apellido, string email, DateTime fechaNac, string nombreUsuario, string password)
        {

            Usuario nuevoUsuario = s.AltaUsuario(nombre, apellido, email, fechaNac, nombreUsuario, password);
            if (nuevoUsuario!=null)
            {
                HttpContext.Session.SetString("logueadoNombreUsuario", nuevoUsuario.NombreUsuario);
                HttpContext.Session.SetString("logueadoRol", nuevoUsuario.Rol);
                HttpContext.Session.SetInt32("logueadoId", nuevoUsuario.IdUsuario);
                ViewBag.NuevoUsuario = "Alta Correcta";
            }
            else
            {
                ViewBag.NuevoUsuario = "Error de Alta";
            }

            return View();
        }

        // ActionResult LOGIN
        public IActionResult Login()
        {
            //Controlamos el acceso de la ruta de usuario, redireccionando al usuario logueado al index de usuario
            // "/Usuario/Index"  y al no logueado a la view "/Usuario/Login"
            if (HttpContext.Session.GetString("logueadoNombreUsuario") == null)
            {
                return View();
            }
            else 
            {
                return RedirectToAction("Index", "Home");
            }
        }

        [HttpPost]
        public IActionResult Login(string nombreUsuario, string password)
        {
            Usuario u = s.Login(nombreUsuario,password);
            if (u != null)
            {
                HttpContext.Session.SetString("logueadoNombreUsuario", u.NombreUsuario);
                HttpContext.Session.SetString("logueadoRol", u.Rol);
                HttpContext.Session.SetInt32("logueadoId", u.IdUsuario);
               
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Logueado = "Error en el ingreso";
                return View();
            }
        }

        // LOGOUT
        public IActionResult Logout()
        {
            if (HttpContext.Session.GetString("logueadoNombreUsuario") != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        [HttpPost] //Toma el ingreso del usuario (pedido de cerrar la sesión) que viene del form de la view de logout.
        public IActionResult Logout(string n)
        {
            HttpContext.Session.Clear();

            return RedirectToAction("Index", "Home");
        }

        // OPERADOR BUSQUEDA

        public IActionResult OpBusqueda()
        {
            if(HttpContext.Session.GetString("logueadoRol") == "Operador"){
                ViewBag.ComprasFecha = "";
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        [HttpPost]
        public IActionResult OpBusqueda(DateTime f1, DateTime f2)
        {

            if(f1 !=null  && f2 !=null)
            {
                List<Compra> comprasXFechas = s.GetComprasEntreFechas(f1, f2);
                ViewBag.ComprasFecha = comprasXFechas;
                ViewBag.LargoCompras = comprasXFechas.Count();
            }
            else
            {
                ViewBag.ComprasFecha = "Error, llene todos los campos";
            }
            return View();
        }
        
        public IActionResult ListaClientes()
        {
            if (HttpContext.Session.GetString("logueadoRol") == "Operador")
            {
                List<Usuario> clientes = new List<Usuario>();
                foreach(var c in s.GetUsuarios())
                {
                    if (c.Rol == "Cliente")
                    {
                        clientes.Add(c);
                    }
                }
                ViewBag.ClientesList = clientes;
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        public IActionResult OpListarActividadesPorLugar()
        {
            if (HttpContext.Session.GetString("logueadoRol") == "Operador")
            {
                List<Lugar> lugaresList = s.GetLugares();
                ViewBag.Lugares = lugaresList;
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        [HttpPost]
        public IActionResult OpListarActividadesPorLugar(string nombreLugar)
        {
                List<Lugar> lugaresList = s.GetLugares();
                ViewBag.Lugares = lugaresList;
                List<Actividad> actividadesList = s.GetPorLugar(nombreLugar);
                ViewBag.ActividadesXLugar = actividadesList;
                ViewBag.LargoLista = actividadesList.Count();
                return View();
          
        }


        public IActionResult OpListarActividadesPorFechaYCategoria()
        {
            if (HttpContext.Session.GetString("logueadoRol") == "Operador")
            {
             List<Categoria> categorias = s.GetCategorias();
            ViewBag.CategoriasList = categorias;
            return View();
            }
            else
            {
                return RedirectToAction("Index",  "Home");                
            }
        }

        [HttpPost]
        public IActionResult OpListarActividadesPorFechaYCategoria(DateTime f1, DateTime f2, Categoria.TipoCategoria cat)
        {
            List<Categoria> categorias = s.GetCategorias();
            ViewBag.CategoriasList = categorias;
            List<Actividad> actividadesList = s.GetPorCategoria(cat, f1, f2);
            ViewBag.ActividadesFiltradas = actividadesList;
            ViewBag.CountDeLista = actividadesList.Count();
            return View();
        }


        public IActionResult OpListarComprasMayorValor()
        {
            if (HttpContext.Session.GetString("logueadoRol") == "Operador")
            {
                List<Compra> comprasX = s.GetComprasMax();
                ViewBag.ComprasMax = comprasX;
                return View();

            }
            else
            {
                return RedirectToAction("Index", "Home");
            }

              
        }
    }
}
