using System;
using System.Collections.Generic;
using System.Text;

namespace ObligatorioP2
{
  public  class Actividad
    {
        public static int ultimoId = 1;

        public int IdActividad { get; }
        public string Nombre { get; set; }
        public Categoria Categoria { get; set; }
        public DateTime FechaHora { get; set; }
        public Lugar Lugar { get; set; }
        public TipoEdad EdadMinima { get; set; }

        public static double PrecioBase { get; set; }
        public int CantidadMeGusta { get; set; }


        // Constructor de Actividad
        public Actividad(string nombre, Categoria categoria, DateTime fechaHora, Lugar lugar, TipoEdad edadMinima, int cantidadMeGusta)
        {
            IdActividad = ultimoId;
            ultimoId++;
            Nombre = nombre;
            Categoria = categoria;
            FechaHora = fechaHora;
            Lugar = lugar;
            EdadMinima = edadMinima;
            PrecioBase = 300;
            CantidadMeGusta = cantidadMeGusta;
        }
        
        // Metodo ToString para mostrar mensaje en pantalla.
        public override string ToString()
        {
            // Cambiar precio base por precio Final en la segunda parte del Obligatorio!!!!!!!####
            return $"\n #### Actividad: {Nombre} ###\nId:{IdActividad} \nNombre: {Nombre}\nCategoria: {Categoria}\nFecha: {FechaHora}\nLugar: {Lugar.Nombre}\nEdad: {EdadMinima}\nPrecio: {PrecioBase}\nLikes: {CantidadMeGusta}";
        }

        // Utilizamos Enum para la Edad
        public enum TipoEdad
        {
            P,
            C13,
            C16,
            C18
        }

        /// <summary>
        /// Llama a CalcularCosto() 
        /// </summary>
        /// <returns></returns>
        public double precioFinal()
        {
             double costoLugar = Lugar.CalcularCosto();
             return costoLugar;
        }

        public void MeGusta()
        {
            CantidadMeGusta++;
        }
    }
}


