using Obligatorio2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.AspNetCore.Http;


namespace ObligatorioP2
{
    public class Sistema
    {
        // ######################  Listas  ###########################
        private List<Actividad> actividades = new List<Actividad>();
        private List<Compra> compras = new List<Compra>();
        private List<Categoria> categorias = new List<Categoria>();
        private List<Usuario> usuarios = new List<Usuario>();
        private List<Lugar> lugares = new List<Lugar>();


        // #### Método precarga automática  ####
        public Sistema()
        {
            Precarga();
        }

        private static Sistema instancia = null;


        // ######################  Métodos GET  #####################       
        # region Get

        // Metodo singleton para tener una sola instancia de Sistema
        /// <summary>
        /// Método singleton para utilizar una sola instancia de Sistema
        /// </summary>
        /// <returns></returns>
        public static Sistema GetSistema()
        {
            if(instancia== null)
            {
                instancia = new Sistema();
            }
            return instancia;
        }
        
        // OPCION DE MENU 1
        // Metodo para listar Todas las Actividades
        /// <summary>
        /// Retorna lista de actividades
        /// </summary>
        /// <returns></returns>
        public List<Actividad> GetActividades()
        {
            return actividades;
        }

        // Metodo para listar todas las Compras
        /// <summary>
        /// Retorna lista de compras
        /// </summary>
        /// <returns></returns>
        public List<Compra> GetCompras()
        {
            return compras;
        }
        /// <summary>
        /// Se obtienen las compras de mayor valor para el Operador
        /// </summary>
        /// <returns></returns>
        public List<Compra> GetComprasMax()
        {
            double valorM = int.MinValue;
            List<Compra> comprasX = new List<Compra>();
            foreach (Compra c in compras)
            {
                if (c.PrecioFinal > valorM)
                {
                    valorM = c.PrecioFinal;
                    comprasX.Clear();
                    comprasX.Add(c);

                }
                else if (c.PrecioFinal == valorM)
                {
                    comprasX.Add(c);

                }
            }

            return comprasX;
           
        }


        // Metodo para listar todas las Compras por ID de Usuario
        /// <summary>
        /// Retorna lista de compras de un usuario logueado
        /// </summary>
        /// <returns></returns>
        public List<Compra> GetComprasDeUsuario(int? idUsuario)
        {
            List<Compra> ret = new List<Compra>();
            foreach (Compra c in compras)
            {
                if(c.Usuario.IdUsuario == idUsuario)
                {
                    ret.Add(c);
                }
            }  
            return ret;
        }

        /// <summary>
        /// Retorna una instancia de la clase compra 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Compra GetCompra(int id)
        {
            foreach (Compra c in compras)
            {
                if (c.IdCompra.Equals(id))
                {
                    return c;
                }
            }
            return null;
        }


        // Metodo para listar todas las Categorias
        /// <summary>
        /// Retorna lista de categorias
        /// </summary>
        /// <returns></returns>
        public List<Categoria> GetCategorias()
        {
            return categorias;
        }

        // Metodo para listar todos los Usuarios
        /// <summary>
        /// Retorna lista de usuarios
        /// </summary>
        /// <returns></returns>
        public List<Usuario> GetUsuarios()
        {
            usuarios.Sort();
            return usuarios;
        }

        // Metodo para mostrar un Usuario segun ID
        /// <summary>
        /// Retorna un Usuario con un Id
        /// </summary>
        /// <returns></returns>
        internal Usuario GetUsuario(int? idUsuarioLogueado)
        {
            foreach (Usuario u in usuarios)
            {
                if (u.IdUsuario.Equals(idUsuarioLogueado))
                {
                    return u;
                }
            }
            return null;
        }
         
        /// <summary>
        /// Retorna una Actividad con un Id
        /// </summary>
        /// <param name="idActividad"></param>
        /// <returns></returns>
        internal Actividad GetActividad(int? idActividad)
        {
            foreach (Actividad a in actividades)
            {
                if (a.IdActividad.Equals(idActividad))
                {
                    return a;
                }
            }
            return null;
        }
       
        // Metodos para Listar todos los Lugares
        /// <summary>
        /// Retorna la lista de lugares
        /// </summary>
        /// <param name="GetLlugares"></param>
        /// <returns></returns>
        public List<Lugar> GetLugares()
        {
            return lugares;
        }
       
        // OPCION DE MENU 4
        // Metodo para Listar Actividades por Categoria con rango de fechas
        /// <summary>
        /// Retorna una lista filtrada de lugares entre 2 fechas y de determinada categoria
        /// </summary>
        /// <param name="tipoCategoria"></param>
        /// <param name="fechaInicio"></param>
        /// <param name="fechaFinal"></param>
        /// <returns></returns>
        public List<Actividad> GetPorCategoria(Categoria.TipoCategoria tipoCategoria, DateTime fechaInicio, DateTime fechaFinal)
        {
            List<Actividad> actividadesCategoria = new List<Actividad>();
            foreach (Actividad a in actividades)
            {
                if (tipoCategoria == a.Categoria.NombreCategoria && fechaInicio <= a.FechaHora && fechaFinal >= a.FechaHora)
                {
                    actividadesCategoria.Add(a);
                }
            }
            return actividadesCategoria;
        }

        /// <summary>
        /// Retorna lista de actividades en determinado lugar
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns></returns>
        public List<Actividad> GetPorLugar(string nombre)
        {
            List<Actividad> actividadesCategoria = new List<Actividad>();
            foreach (Actividad a in actividades)
            {
                if (a.Lugar.Nombre == nombre)
                {
                    actividadesCategoria.Add(a);
                }
            }
            return actividadesCategoria;
        }

        // OPCION DE MENU 5
        // Metodo para Listar actividades para todo publico
        /// <summary>
        /// Retorna lista de actividades para todo público
        /// </summary>
        /// <returns></returns>
        public List<Actividad> GetTodoPublico()
        {
            List<Actividad> actividadTodoPublico = new List<Actividad>();
            foreach (Actividad a in actividades)
            {
                if (a.EdadMinima == Actividad.TipoEdad.P)
                {
                    actividadTodoPublico.Add(a);
                }
            }
            return actividadTodoPublico;
        }

        /// <summary>
        /// Metodo para Listar las Compras entre realizadas entre dos fechas
        /// </summary>
        /// <param name="fechaInicio"></param>
        /// <param name="fechaFinal"></param>
        /// <returns></returns>      
        // Metodo para Listar Compras al operador en un rango de fechas
        public List<Compra> GetComprasEntreFechas(DateTime fechaInicio, DateTime fechaFinal)
        {
           
            List<Compra> comprasEntreFechas = new List<Compra>();
            foreach (Compra c in compras)
            {
                if (fechaInicio > fechaFinal)
                {
                    var aux = fechaInicio;
                    fechaInicio = fechaFinal;
                    fechaFinal = aux;
                }
                if (c.FechaHoraCompra >= fechaInicio && c.FechaHoraCompra<= fechaFinal)
                {
                    comprasEntreFechas.Add(c);
                }
            }
            return comprasEntreFechas;
        }

        #endregion


        // ################################ VALIDACIONES ####################################
        #region Validaciones
        // Validamos la edad minima segun categoria.
        /// <summary>
        /// Valida la categoría de edad permitida para publica (enum)
        /// </summary>
        /// <param name="edadMinima"></param>
        /// <returns></returns>
        public bool ValidarEdadMinima(Actividad.TipoEdad edadMinima)
        {
            bool valido = false;
            if (edadMinima == Actividad.TipoEdad.P || edadMinima == Actividad.TipoEdad.C13 || edadMinima == Actividad.TipoEdad.C16 || edadMinima == Actividad.TipoEdad.C18)
            {
                valido = true;
            }
            return valido;
        }

        /// <summary>
        /// Valida que el password tenga al menos 1 minúscula, 1 mayúscula, 1 número y 6 caracteres
        /// </summary>
        /// <param name="pass"></param>
        /// <returns></returns>
        public bool ValidarPassword(string pass)
        {
            bool tieneMayusculas = false;
            bool tieneMinusculas = false;
            bool tieneNumero = false;
            bool valido = false;

            if (pass.Length >= 6)
            {
                tieneMayusculas = pass.Any(c => char.IsUpper(c));
                tieneMinusculas = pass.Any(c => char.IsLower(c));
                tieneNumero = pass.Any(c => char.IsNumber(c));

                if (tieneMayusculas && tieneMinusculas && tieneNumero)
                {
                    valido = true;
                }
            }
            return valido;
        }
        
        /// <summary>
        /// Valida que el string tenga minimo 2 caracteres (usado en nombre y en apellido del registro de usuarios)
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public bool ValidarLargoMinimo(string x)
        {
            bool valido = false;
            if (x.Length >= 2)
            {
                valido = true;
            }
            return valido;
        }
       
        /// <summary>
        /// Valida que haya una Actividad seleccionada al momento de dar MeGusta
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public bool ValidarMeGusta( Actividad a)
        {
            bool valido = false;
            if( a != null)
            {
                valido = true;   
            }
            return valido;
        }

        /// <summary>
        /// Valida la cancelacion de la compra en el caso que falten mas de 24 horas para la Actividad
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public bool ValidarCancelacion(Compra c)
        {
           bool valido = false;
           if (c != null)
           {
              DateTime fechaActualMasUnDia = DateTime.Now.AddDays(1);
              if (fechaActualMasUnDia < c.Actividad.FechaHora)
              {
                  valido = true;
              }
           }
           return valido;
          }
                 

        #endregion

        // ################################  ALTAS  #########################################

        #region Altas
        // Damos alta a la Actividad
        /// <summary>
        /// Genera una instancia Actividad
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="categoria"></param>
        /// <param name="fechaHora"></param>
        /// <param name="lugar"></param>
        /// <param name="edadMinima"></param>
        /// <param name="cantidadMeGusta"></param>
        /// <returns></returns>
        public Actividad AltaActividad(string nombre, Categoria categoria, DateTime fechaHora, Lugar lugar, Actividad.TipoEdad edadMinima, int cantidadMeGusta)
        {
            Actividad nuevaActividad = null;
            if (nombre != "" && categoria != null && fechaHora > DateTime.Now && lugar != null && ValidarEdadMinima(edadMinima) && cantidadMeGusta >= 0)
            {
                nuevaActividad = new Actividad(nombre, categoria, fechaHora, lugar, edadMinima, cantidadMeGusta);
                actividades.Add(nuevaActividad);
            }
            return nuevaActividad;
        }

        // Damos alta a la Compra
        /// <summary>
        /// Genera una instancia Compra
        /// </summary>
        /// <param name="actividad"></param>
        /// <param name="cantidadentradas"></param>
        /// <param name="usuario"></param>
        /// <param name="fechaHoraCompra"></param>
        /// <param name="precio_final"></param>
        /// <returns></returns>
        public Compra AltaCompra(Actividad actividad, int cantidadentradas, Usuario usuario, DateTime fechaHoraCompra, double precio_final)
        {

            Compra nuevaCompra = null;
            bool comparacionFechas = fechaHoraCompra < actividad.FechaHora;


            if (actividad != null && cantidadentradas > 0 && usuario != null && comparacionFechas && precio_final >= 0)
            {
                nuevaCompra = new Compra(actividad, cantidadentradas, usuario, fechaHoraCompra, precio_final);
                compras.Add(nuevaCompra);
            }
            return nuevaCompra;
        }

        // Damos alta al Usuario
        /// <summary>
        /// Genera una instancia Usuario
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="email"></param>
        /// <param name="fechaNac"></param>
        /// <param name="nomUsuario"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public Usuario AltaUsuario(string nombre, string apellido, string email, DateTime fechaNac,string nomUsuario,string password)
        {
            Usuario nuevoUsuario = null;

            Usuario aux = new Usuario();
            aux.Email = email;
            aux.NombreUsuario = nomUsuario;

            if (ValidarLargoMinimo(nombre) && ValidarLargoMinimo(apellido) && email != "" && fechaNac < DateTime.Now && !usuarios.Contains(aux) )
            {
                nuevoUsuario = new Usuario( nombre,  apellido,  email,  fechaNac, nomUsuario,  password);
                usuarios.Add(nuevoUsuario);
            }
            return nuevoUsuario;
        }

        // Damos alta Lugar Abierto
        /// <summary>
        /// Genera una instanca Lugar : Abierto
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="dimension"></param>
        /// <returns></returns>
        public Abierto AltaLugarAbierto(string nombre, double dimension) 
        {
            Abierto nuevoAbierto = null;
            if (nombre != "" && dimension > 0)
            {
                nuevoAbierto = new Abierto(nombre, dimension);
                lugares.Add(nuevoAbierto);
            }
            return nuevoAbierto;
        }

        // Damos alta Lugar.Cerrado
        /// <summary>
        /// Genera una instancia Lugar : Cerrado
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="dimension"></param>
        /// <param name="accesibilidadTotal"></param>
        /// <param name="valorMantenimiento"></param>
        /// <returns></returns>
        public Cerrado AltaLugarCerrado(string nombre, double dimension, bool accesibilidadTotal, int valorMantenimiento)
        {
            Cerrado nuevoCerrado = null;
            if (valorMantenimiento >= 0 && nombre != "" && dimension > 0)
            {
                nuevoCerrado = new Cerrado(nombre, dimension, accesibilidadTotal, valorMantenimiento);
                lugares.Add(nuevoCerrado);
            }
            return nuevoCerrado;
        }

        // Damos alta a la Categoria
        /// <summary>
        /// Genera una instancia de Categoria
        /// </summary>
        /// <param name="tipoCategoria"></param>
        /// <param name="descripcion"></param>
        /// <returns></returns>
        public Categoria AltaCategoria(Categoria.TipoCategoria tipoCategoria, string descripcion)
        {
            Categoria nuevaCategoria = null;
            if (tipoCategoria == Categoria.TipoCategoria.teatro || tipoCategoria == Categoria.TipoCategoria.feria || tipoCategoria == Categoria.TipoCategoria.concierto || tipoCategoria == Categoria.TipoCategoria.cine)
            {
                nuevaCategoria = new Categoria(tipoCategoria, descripcion);
                categorias.Add(nuevaCategoria);
            }
            return nuevaCategoria;
        }
        #endregion

        /// <summary>
        /// Genera variables de Session para usuarios ya registrados
        /// </summary>
        /// <param name="nombreUsuario"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        internal Usuario Login(string nombreUsuario, string password)
        {
            bool encontrado = false;
            Usuario buscado = null;
            foreach (var u in usuarios) if (!encontrado)
                {
                    if (u.NombreUsuario.Equals(nombreUsuario) && u.Password.Equals(password))
                    {
                        encontrado = true;
                        buscado = u;
                    }

                }
            return buscado;
        }

        /// <summary>
        /// Si la accion es validada en ValidaMeGusta, suma un MeGusta en la Actividad
        /// </summary>
        /// <param name="a"></param>
        internal void RegistrarMeGusta(Actividad a)
        {
            if(ValidarMeGusta(a))                
            {
            a.MeGusta();
            }
        }

        
        /// <summary>
        /// Si la accion es validada en ValidarCancelacion, cancela la Compra
        /// </summary>
        /// <param name="c"></param>
        public bool RegistrarCancelacion(Compra c)
        {
            bool cancelada = false;
         if(ValidarCancelacion(c))
            {
                cancelada = true; 
                c.CancelarCompra();
            }
               return cancelada;
        }
        

        // #################################################### PRECARGAS #############################################################################
        #region Precargas
        private void Precarga() 
        {
            //Precarga Lugar --> Abierto
            Abierto la1 = AltaLugarAbierto("Teatro de Verano", 600);            
            Abierto la2 = AltaLugarAbierto("Estadio Centenario", 1000);           
            Abierto la3 = AltaLugarAbierto("Volvé mi negra", 250);            

            // Precarga Lugar ---> Cerrado
            Cerrado lc1 = AltaLugarCerrado("Shopping Punta Carretas", 500, true, 280);
            Cerrado lc2 = AltaLugarCerrado("Cine Movie", 500, true, 300);
                      // Para probar lugar sin actividades (caso de borde para mandar mensaje a usuario que no hay actividades)
            Cerrado lc3 = AltaLugarCerrado("Lugar Sin Actividades", 200, true, 100);

            // Precarga Categoria
            Categoria cat1 = AltaCategoria(Categoria.TipoCategoria.teatro, "Sala Teatro");
            Categoria cat2 = AltaCategoria(Categoria.TipoCategoria.cine, "Sala para Cine o espectaculos");
            Categoria cat3 = AltaCategoria(Categoria.TipoCategoria.concierto, "Estadio Deportivo o espectaculos");
            Categoria cat4 = AltaCategoria(Categoria.TipoCategoria.feria, "Para comer y disfrutar");

            //Precarga Actividad
            Actividad a1 = AltaActividad("Leo Masliah y el coro de la Filarmónica", cat1, DateTime.Parse("2022-08-29 06:00 PM"), lc1, Actividad.TipoEdad.P, 1200);
            Actividad a2 = AltaActividad("Fran Aldado: 4 estaciones", cat2, DateTime.Parse("2022-02-12 09:00 PM"), lc2, Actividad.TipoEdad.C13, 1922);
            Actividad a3 = AltaActividad("Boskimanos", cat3, DateTime.Parse("2023/05/31 10:00 PM"), la1, Actividad.TipoEdad.C16, 23022);
            Actividad a4 = AltaActividad("Hamlet", cat4, DateTime.Parse("2022-03-28 09:00 PM"), lc2, Actividad.TipoEdad.C18, 127);
            Actividad a5 = AltaActividad("Jazz en el sotano", cat1, DateTime.Parse("2022-12-12 09:00 AM"), lc1, Actividad.TipoEdad.C18, 445);
            Actividad a6 = AltaActividad("Una de Anton Chejov", cat2, DateTime.Parse("2022-12-24 12:00 AM"), lc2, Actividad.TipoEdad.P, 5);
            Actividad a7 = AltaActividad("Sueño de una noche de Verano", cat3, DateTime.Parse("2022-12-03 10:00 PM"), la3, Actividad.TipoEdad.P, 122002);
            Actividad a8 = AltaActividad("Buenos Muchachos: Presentación del disco", cat4, DateTime.Parse("2022-05-05 09:00 PM"), la2, Actividad.TipoEdad.C13, 2330);
            Actividad a9 = AltaActividad("Cuentos de Susana Olaondo", cat1, DateTime.Parse("2022-02-27 09:00 PM"), la1, Actividad.TipoEdad.P, 4001);
            Actividad a10 = AltaActividad("Presentación del libro 'Irse Yendo' de Leonor Courtoisie", cat4, DateTime.Parse("2022-10-10 09:00 AM"), la2, Actividad.TipoEdad.C18, 2020);
                        // Para probar cancelar Actividad con menos de 24 horas de anticipacion (23/11/2021 9:10 AM)
            Actividad a11 = AltaActividad("Fiesta de fin de año Esteban, Fran, Rafa", cat3, DateTime.Parse("2021-11-24 6:00 AM"), la2, Actividad.TipoEdad.C18, 202);

            //Precarga Usuario
            Usuario u1 = AltaUsuario("Rafa", "Diaz", "rmiles@gmail.com", DateTime.Parse("12/05/1985"), "rdiaz", "Rd1234");
            Usuario u2 = AltaUsuario("Esteban", "Martinez", "emartinez@gmail.com", DateTime.Parse("11/07/1995"), "emartinez", "Em1234");
            Usuario u3 = AltaUsuario("Francisco", "Aldado", "faldado@gmail.com", DateTime.Parse("03/03/1982"), "faldado", "Fa1234");
            Usuario u4 = AltaUsuario("Elon", "Musk", "emusck@gmail.com", DateTime.Parse("12/06/1971"), "emusk", "Elon1234");
            Usuario u5 = AltaUsuario("Bill", "Smith", "bsmith@gmail.com", DateTime.Parse("10/08/1962"), "bsmith", "Bm1234");
                        // casos de borde para prueba con email y nombres de usuario iguales
            Usuario u6 = AltaUsuario("Bill", "Small", "bsmall@gmail.com", DateTime.Parse("05/08/1962"), "bsmith", "Bm1234");
            Usuario u7 = AltaUsuario("Bill", "Smith", "bsmore@gmail.com", DateTime.Parse("07/08/1962"), "bsmith", "Bm234");
            Usuario u8 = AltaUsuario("Bill", "Smith", "bsmore@gmail.com", DateTime.Parse("06/08/1962"), "bsmsafdith", "Bm234");
            Usuario u9 = AltaUsuario("ultimo", "Smith", "bsmoasdare@gmail.com", DateTime.Parse("08/08/1962"), "bsssmith", "Bm11234");

            // Precarga Operador
            Usuario o1 = new Usuario("Op1", "Admin", "op1@gmail.com", DateTime.Parse("03/05/1985"), "op1", "Op1111");
            Usuario o2 = new Usuario("Op2", "Admin", "op2@gmail.com", DateTime.Parse("05/06/1981"), "op2", "Op2222");
            o1.Rol = "Operador";
            o2.Rol = "Operador";
            usuarios.Add(o1);
            usuarios.Add(o2);

            // Precarga Compra
            Compra compra1 = AltaCompra(a6, 5, u1, DateTime.Parse("11/07/2021 12:38:21"), a6.precioFinal()*5);
            Compra compra2 = AltaCompra(a2, 10, u2, DateTime.Parse("10/03/2019 03:30:22"), a2.precioFinal()*10);
            Compra compra3 = AltaCompra(a3, 7, u3, DateTime.Parse("09/07/2011 12:10:15"), a3.precioFinal()*7);

            #endregion

        }
    }
}
