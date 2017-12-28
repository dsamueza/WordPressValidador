using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
namespace WordPressValidador.Models
{
    public class login
    {
        [DisplayName("Nombre de usuario o dirección de correo electrónico")]
        public String NombreUsuario { get; set; }
        [DisplayName("Contraseña")]
        public String PassUsuario { get; set; }

    }
}