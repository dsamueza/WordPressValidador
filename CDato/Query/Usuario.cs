using CDato.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDato.Query
{/// <summary>
/// 
/// </summary>
  public  class Usuario
    {

        public IList<wp_users> GetUsertAll() {

            try
            {
                using (var tran = new mardis_wp3Entities())
                {

                    return tran.wp_users.ToList<wp_users>();

                }

            }
            catch (Exception ex)
            {
                string error;
                error = ex.ToString();
                return null;
            }
        }
    }
}
