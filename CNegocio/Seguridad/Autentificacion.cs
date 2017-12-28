using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CDato.Query;
using CDato.Base;
using CryptSharp;
namespace CNegocio.Seguridad
{
   public class Autentificacion
    {
        Usuario usuario = new Usuario();
    
        public string IsUser(String Usuario, String Password) {

            string lgn = "";
            IList<wp_users> users=  usuario.GetUsertAll();
            var QryUsuario =  users.Where(x => x.user_login == Usuario).ToList<wp_users>();
  

            if (QryUsuario.Count() > 0 && Password=="Mardis2017") {
                lgn = QryUsuario.First().user_login;
            }

            return lgn;
        }
    }
}
