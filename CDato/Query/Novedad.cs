using CDato.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDato.Query
{
    public class Novedad
    {
        public long GetTIPO(string tipo)
        {

            try
            {
                using (var tran = new mardis_wp3Entities())
                {

                    var Ctipo=   tran.wp_tpo_novedad.Where(x => x.wp_tpo_nov_desc==tipo).ToArray<wp_tpo_novedad>();
                    long idtipo = Ctipo.First().wp_tpo_nov_id;
                    return idtipo;
                }

            }
            catch (Exception ex)
            {
                string error;
                error = ex.ToString();
                return 0;
            }
        }
        public string GetPrecioProducto(decimal id)
        {

            try
            {
                using (var tran = new mardis_wp3Entities())
                {

                    var CPrecio = (from p in tran.wp_posts
                                   join m in tran.wp_postmeta on p.ID equals m.post_id
                                   where m.meta_key.Equals("_regular_price") && p.ID == id
                                   select m.meta_value).Single();
                   
                    return CPrecio;
                }

            }
            catch (Exception ex)
            {
                string error;
                error = ex.ToString();
                return "";
            }
        }
        public int InsertNovedad(IList<wp_novedad>  NovedadesActuales)
        {

            try
            {
                using (var tran = new mardis_wp3Entities())
                {
                    var novedad = tran.Set<wp_novedad>();
                    foreach (var NovedadIndividual in NovedadesActuales)
                    {
                        novedad.Add(NovedadIndividual);
                    }
                   

                    return tran.SaveChanges();

                }

            }
            catch (Exception ex)
            {
                string error;
                error = ex.ToString();
                return 0;
            }


        }
    }
}
