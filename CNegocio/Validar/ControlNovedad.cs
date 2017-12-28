using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CDato.Query;
using CDato.Base;
namespace CNegocio.Validar
{
    public class ControlNovedad
    {
        #region constructores

        ValidacionNuevo qryvalida = new ValidacionNuevo();
        Novedad qrynovedad = new Novedad();
        #endregion 
        public wp_novedad validarNovedad(string id, string precio, string novedad,string filtros, string fecha, string semana)
        {
            wp_novedad novedades = new wp_novedad();
          
                long tipo =qrynovedad.GetTIPO(novedad.Trim());
                switch (tipo)
                {
                    case 1:
                        novedades.wp_nov_val_act = precio;
                        novedades.wp_nov_val_ant = "SI";
                        novedades.wp_tpo_nov = tipo;
                        novedades.wp_nov_fecha = DateTime.Now;
                        novedades.wp_nov_dia_ing = fecha;
                        novedades.wp_nov_semana_ing = semana;
                    if (qryvalida.ProductoIDSKU(id).Count() > 0)
                            {
                                novedades.wp_nov_posts_id = qryvalida.ProductoIDSKU(id).First().meta_value.ToString();
                            }
                            else {
                                novedades.wp_nov_posts_id = id;
                            }
                       
                        novedades.wp_nov_activa = true;
                        novedades.filtro = filtros;
                        break;
                    case 2:
                        novedades.wp_nov_val_act = precio;
                        novedades.wp_tpo_nov = tipo;
                        novedades.wp_nov_fecha = DateTime.Now;
                    novedades.wp_nov_dia_ing = fecha;
                    novedades.wp_nov_semana_ing = semana;
                    if (qryvalida.ProductoIDSKU(id).Count() > 0)
                            {
                                novedades.wp_nov_posts_id = qryvalida.ProductoIDSKU(id).First().meta_value.ToString();
                            }
                            else
                            {
                                novedades.wp_nov_posts_id = id;
                            }
                        novedades.wp_nov_activa = true;
                        novedades.wp_nov_val_ant = qrynovedad.GetPrecioProducto(qryvalida.ProductoIDSKU(id).First().post_id);
                        novedades.filtro = filtros;
                    break;
                    case 3:
                        novedades.wp_nov_val_act = precio;
                        novedades.wp_nov_val_ant = "SI";
                    novedades.wp_tpo_nov = tipo;
                    novedades.wp_nov_fecha = DateTime.Now;
                    novedades.wp_nov_dia_ing = fecha;
                    novedades.wp_nov_semana_ing = semana;
                    if (qryvalida.ProductoIDSKU(id).Count() > 0)
                            {
                                novedades.wp_nov_posts_id = qryvalida.ProductoIDSKU(id).First().meta_value.ToString();
                            }
                            else
                            {
                                novedades.wp_nov_posts_id = id;
                            }
                    novedades.wp_nov_activa = true;
                        novedades.filtro = filtros;
                    break;
                case 4:
                    novedades.wp_nov_val_act = precio;
                    novedades.wp_nov_val_ant = "SI";
                    novedades.wp_tpo_nov = tipo;
                    novedades.wp_nov_fecha = DateTime.Now;
                    novedades.wp_nov_dia_ing = fecha;
                    novedades.wp_nov_semana_ing = semana;
                    if (qryvalida.ProductoIDSKU(id).Count() > 0)
                    {
                        novedades.wp_nov_posts_id = qryvalida.ProductoIDSKU(id).First().meta_value.ToString();
                    }
                    else
                    {
                        novedades.wp_nov_posts_id = id;
                    }
                    novedades.wp_nov_activa = true;
                    novedades.filtro = filtros;
                    break;
                case 5:
                    novedades.wp_nov_val_act = precio;
                    novedades.wp_nov_val_ant = "SI";
                    novedades.wp_tpo_nov = tipo;
                    novedades.wp_nov_fecha = DateTime.Now;
                    novedades.wp_nov_dia_ing = fecha;
                    novedades.wp_nov_semana_ing = semana;
                    if (qryvalida.ProductoIDSKU(id).Count() > 0)
                    {
                        novedades.wp_nov_posts_id = qryvalida.ProductoIDSKU(id).First().meta_value.ToString();
                    }
                    else
                    {
                        novedades.wp_nov_posts_id = id;
                    }
                    novedades.wp_nov_activa = true;
                    novedades.filtro = filtros;
                    break;
                case 6:
                    novedades.wp_nov_val_act = precio;
                    novedades.wp_nov_val_ant = "SI";
                    novedades.wp_tpo_nov = tipo;
                    novedades.wp_nov_fecha = DateTime.Now;
                    novedades.wp_nov_dia_ing = fecha;
                    novedades.wp_nov_semana_ing = semana;
                    if (qryvalida.ProductoIDSKU(id).Count() > 0)
                    {
                        novedades.wp_nov_posts_id = qryvalida.ProductoIDSKU(id).First().meta_value.ToString();
                    }
                    else
                    {
                        novedades.wp_nov_posts_id =id;
                    }
                    novedades.wp_nov_activa = true;
                    novedades.filtro = filtros;
                    break;
                default:
                        Console.WriteLine("Default case");
                        break;
                }

            
            return novedades;
        }
    }
}
