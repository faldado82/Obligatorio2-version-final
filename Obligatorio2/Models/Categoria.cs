using System;
using System.Collections.Generic;
using System.Text;

namespace ObligatorioP2
{
   public class Categoria
    {
        public static int ultimoId = 1;
        public int IdCategoria { get; }
        public TipoCategoria NombreCategoria { get; set; }
        public string Descripcion { get; set; }

        public Categoria(TipoCategoria tipoCategoria, string descripcion)
        {
            IdCategoria = ultimoId;
            ultimoId++;
            NombreCategoria = tipoCategoria;
            Descripcion = descripcion;
        }

        public enum TipoCategoria
        {
            cine,
            teatro,
            concierto,
            feria
        }

        public override string ToString()
        {
            return $"Id: {IdCategoria}\nNombre: {NombreCategoria}\nDescripción: {Descripcion}";
        }

    }
}
