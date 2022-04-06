using System;
using System.Collections.Generic;

using System.Text;

namespace ObligatorioP2
{
    public class Compra 
    {
        public static int ultimoId = 1;
        public int IdCompra { get; }
        public Actividad Actividad { get; set; }
        public int CantidadEntradas { get; set; }
        public Usuario Usuario { get; set; }
        public DateTime FechaHoraCompra { get; set; }
        public string Estado { get; set; }
        public double PrecioFinal { get; set; } 

        public Compra()
        {

        }
        public Compra(Actividad actividad, int cantidadEntradas, Usuario usuario, DateTime fechaHoraCompra, double precioFinal)
        {
            IdCompra = ultimoId;
            ultimoId++;
            Actividad = actividad;
            CantidadEntradas = cantidadEntradas;
            Usuario = usuario;
            FechaHoraCompra = fechaHoraCompra;
            Estado = "Activa";
            PrecioFinal = precioFinal;
        }


         public void CancelarCompra()
        {            
            Estado = "Cancelada";                            
        }
           

        public override string ToString()
        {
            return $"La Compra {IdCompra}, pertenece a la actividad {Actividad.Nombre}, se han comprado {CantidadEntradas} entradas por el usuario {Usuario} el dia/hora {FechaHoraCompra}, a $ {PrecioFinal} pesos. El estado es {Estado} ";
        }

       
    }
}
