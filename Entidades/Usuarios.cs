using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Proyecto_Registro.Entidades
{
    public class Usuarios
    {
        [Key]
        public int UsuarioID { get; set; }
        public string Clave { get; set; }
        public string Nombres { get; set; }
        public string Email { get; set; }
        public DateTime FechaIngreso { get; set; }
        public int RolID { get; set; }
        public string Alias { get; set; }
        public bool Activo { get; set; }

        public Usuarios()
        {
            UsuarioID = 0;
            Clave = string.Empty;
            Nombres = string.Empty;
            Email = string.Empty;
            FechaIngreso = DateTime.Now;
            RolID = 0;
            Alias = string.Empty;
            Activo = false;
        }
    }
}
