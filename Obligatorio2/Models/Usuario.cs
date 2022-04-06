using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace ObligatorioP2
{ 
public  class Usuario : IComparable<Usuario>
    {
        protected static int ultimoId = 1;

        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public DateTime FechaNac { get; set; }
        public string NombreUsuario { get; set; }
        public string Password { get; set; }
        public string Rol { get ;  set; }


        // Constructor de Usuario
        public Usuario(string nombre, string apellido, string email, DateTime fechaNac,string nombreUsuario ,string password)
        {
            IdUsuario = ultimoId;
            ultimoId++;
            Nombre = nombre;
            Apellido = apellido;
            Email = email;
            FechaNac = fechaNac;
            NombreUsuario = nombreUsuario;
            Password = password;
            Rol = "Cliente";   
        }

        public Usuario()
        {

        }

        // Metodo ToString para mostrar mensaje a usuario
        public override string ToString()
        {
            return $"El Usuario {IdUsuario} de nombre {Nombre} {Apellido} con email: {Email} y fecha Nac: {FechaNac} nombre de usuario: {NombreUsuario} Rol: {Rol}";
        }


        public override bool Equals(object obj)
        {
            return obj is Usuario usuario &&
                   (Email == usuario.Email ||
                   NombreUsuario == usuario.NombreUsuario);
        }


        // Compramos Apellido y Nombre (en caso de empate en apellido) para las busquedas de Cliente realizadas por el Operador 
        public int CompareTo([AllowNull] Usuario other)
        {
            if (this.Apellido.CompareTo(other.Apellido) > 0)
            {
                return 1;
            }else if(this.Apellido.CompareTo(other.Apellido) < 0)
            {
                return -1;
            }
            else
            { 
             
                if (this.Nombre.CompareTo(other.Nombre) > 0)
                {
                    return 1;
                }
                else if (this.Nombre.CompareTo(other.Nombre) < 0)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
