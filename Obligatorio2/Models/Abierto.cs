using System;
using System.Collections.Generic;
using System.Text;

namespace ObligatorioP2
{
   public class Abierto : Lugar 
    {
        public static double PrecioButaca { get; set; }
   
        // Constructor de Abierto
        public Abierto(string nombre, double dimension) 
        {
            PrecioButaca = 400;
            IdLugar = ultimoId;
            ultimoId++;
            Nombre = nombre;
            Dimension = dimension;       
        }

        // Método para cambiar el precio de las butacas.        
        /// <summary>
        /// Asigna precio de las butacas
        /// </summary>
        /// <param name="nuevoPrecio"></param>
        /// <returns></returns>
        public static bool CambiarPrecioButaca(double nuevoPrecio)
        {
            bool valido = false;
            if (nuevoPrecio != PrecioButaca && nuevoPrecio > 0)
            {
                PrecioButaca = nuevoPrecio;
                valido = true;
            }
            return valido;
        }

        // Método ToString() para mostrar detalle de Lugar Abierto.        
        public override string ToString()
        {
            return $"{base.ToString()} Precio butaca: {PrecioButaca}";
        }

        public override double CalcularCosto()
        {
            double precioRetorno = Actividad.PrecioBase;
            if (Dimension > 1000)
            {
                precioRetorno *= 1.1;
            }
            return precioRetorno;
        }
    }
}
