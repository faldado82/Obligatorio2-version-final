using System;
using System.Collections.Generic;
using System.Text;

namespace ObligatorioP2
{
  public abstract class Lugar
    {
        protected static int ultimoId  =  1;
        public int IdLugar { get; set; }
        public string Nombre { get; set; }
        public double Dimension { get; set; }

        public override string ToString()
        {
            return $"ID Lugar: {IdLugar} Nombre: {Nombre} Dimension: {Dimension} ";
        }

        /// <summary>
        /// Calcula el costo de la actividad segun la naturaleza del hijo
        /// </summary>
        /// <returns></returns>
        public abstract double CalcularCosto();
    }
}
