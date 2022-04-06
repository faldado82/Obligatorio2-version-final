using System;
using System.Collections.Generic;
using System.Text;

namespace ObligatorioP2
{
  public  class Cerrado: Lugar

    {
        public bool AccesibilidadTotal { get; set; }
        public int ValorMantenimiento { get; set; }
        public static int PorcentajeAforo { get;  set; }

        public Cerrado(string nombre, double dimension, bool accesibilidadTotal, int valorMantenimiento)
        {
            IdLugar = ultimoId;
            ultimoId++;
            Nombre = nombre;
            Dimension = dimension;
            AccesibilidadTotal = accesibilidadTotal;
            ValorMantenimiento = valorMantenimiento;
            PorcentajeAforo = 70;            
        }
        
        /// <summary>
        /// Cambia el porcentaje de aforo permitido en lugares cerrados
        /// </summary>
        /// <param name="nuevoValor"></param>
        /// <returns></returns>
        public static bool CambiarValorAforoMaximo(int nuevoValor)
        {
            bool valido = false;
            if(nuevoValor != PorcentajeAforo && nuevoValor >= 1 && nuevoValor <= 100)
            {
                PorcentajeAforo = nuevoValor;
                valido = true;
            }

            return valido;
        }

        // Método to string para mostrar detalle de Cerrado
        public override string ToString()
        {
            return $"{base.ToString()} Accesibilidad:{AccesibilidadTotal} Valor Mantenimiento:{ValorMantenimiento} ";
        }

        /// <summary>
        /// Devuelve el costo de la actividad cerrada modificada por porcentaje de aforo
        /// </summary>
        /// <returns></returns>
        public override double CalcularCosto()
        {
            double precioRetorno = Actividad.PrecioBase;              
            if (PorcentajeAforo < 50)
            {
                precioRetorno *= 1.3;
            }else if (PorcentajeAforo >= 50 && PorcentajeAforo <= 70)
            {
                precioRetorno *= 1.15;
            }
            return precioRetorno;
        }
    }
    }
