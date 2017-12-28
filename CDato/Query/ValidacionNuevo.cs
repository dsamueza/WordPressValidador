using CDato.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDato.Query
{
  public class ValidacionNuevo
    {
        public IList<wp_posts> ProductoID(decimal Id)
        {

            try
            {
                using (var tran = new mardis_wp3Entities())
                {

                    return tran.wp_posts
                               .Where(x => x.ID == Id).ToArray<wp_posts>();


                }

            }
            catch (Exception ex)
            {
                string error;
                error = ex.ToString();
                return null;
            }
        }
        public IList<wp_postmeta> ProductoIDSKU(string Id)
        {

            try
            {
                using (var tran = new mardis_wp3Entities())
                {

                 //jointermToToxanomia = (from term in tran.wp_terms
                 //                              join tax in tran.wp_term_taxonomy on term.term_id equals tax.term_id
                 //                              where term.name == categoria && tax.taxonomy == taxonomia
                 //                              select term).ToArray<wp_terms>();   var 
                    var term = (from post in tran.wp_posts
                               join terpost in tran.wp_postmeta on post.ID equals terpost.post_id
                               where terpost.meta_value == Id && terpost.meta_key== "_sku"
                               select terpost).ToArray<wp_postmeta>();

                    return term;
                }

            }
            catch (Exception ex)
            {
                string error;
                error = ex.ToString();
                return null;
            }
        }
        /// <summary>
        /// Recupera Nombre Id y nombre
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="Id"></param>
        /// <returns></returns>
        public IList<wp_posts> ProductoNombre(string nombre, decimal Id)
        {

            try
            {
                using (var tran = new mardis_wp3Entities())
                {

                    return tran.wp_posts
                               .Where(x => x.post_title == nombre
                                            && x.ID==Id).ToArray<wp_posts>();


                }

            }
            catch (Exception ex)
            {
                string error;
                error = ex.ToString();
                return null;
            }
        }
        public IList<wp_terms> Categoria(String categoria, String taxonomia)
        {

            try
            {
                using (var tran = new mardis_wp3Entities())
                {

                    var jointermToToxanomia = (from term in tran.wp_terms
                                               join tax in tran.wp_term_taxonomy on term.term_id equals tax.term_id
                                               where term.name == categoria && tax.taxonomy == taxonomia 
                                               select term).ToArray<wp_terms>();


                    
                    return jointermToToxanomia;


                }

            }
            catch (Exception ex)
            {
                string error;
                error = ex.ToString();
                return null;
            }
           
        }
    
    public string ImagenUrl(decimal Id, string url)
    {

        try
        {
            using (var tran = new mardis_wp3Entities())
            {

                   var codigoUrl = (from p2 in tran.wp_posts
                                     where p2.post_type == "attachment"
                                              && p2.guid == url
                                     select p2.ID).Single<decimal>().ToString();
                    var Isurl = (from p in tran.wp_postmeta
                              where p.meta_value.Contains(codigoUrl) && p.post_id == Id
                              select p.post_id).Single<decimal>();
                return Isurl.ToString();


            }

        }
        catch (Exception ex)
        {
                string error;
                error = ex.ToString();
            return null;
        }

    }

        public IList<wp_terms> SubCategoria(String categoria)
        {

            try
            {
                using (var tran = new mardis_wp3Entities())
                {

                    var jointermToToxanomia = (from term in tran.wp_terms
                                               join tax in tran.wp_term_taxonomy on term.term_id equals tax.term_id
                                               where term.name == categoria && tax.taxonomy == "product_cat"
                                               select term).ToArray<wp_terms>();



                    return jointermToToxanomia;


                }

            }
            catch (Exception ex)
            {
                string error;
                error = ex.ToString();
                return null;
            }

        }


        public IList<wp_terms> Sugerencia(String categoria)
        {

            try
            {
                using (var tran = new mardis_wp3Entities())
                {

                    var jointermToToxanomia = (from term in tran.wp_terms
                                               join tax in tran.wp_term_taxonomy on term.term_id equals tax.term_id
                                               where tax.taxonomy == "product_cat"
                                               select term).ToArray<wp_terms>();



                    return jointermToToxanomia;


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
