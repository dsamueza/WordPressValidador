using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using excel = Microsoft.Office.Interop.Excel;
using CNegocio.WordPress;
using CNegocio.Modelo;
using CDato.Base;
using CDato.Query;
namespace CNegocio.Validar
{
  public  class Nuevo
    {
        CeldasWordPress validar = new CeldasWordPress();
        ControlNovedad novedad = new ControlNovedad();
        IList<Errores> ILerror = new List<Errores>();
        Novedad qrynovedad = new Novedad();
        IList<wp_novedad> Inovedad = new List<wp_novedad>();
        public IList<Errores> ValidarRegistroNuevo(String PathWordPress) {
  
            try
            {
                excel.Application xlApp = new excel.Application();
                excel.Workbook xlWorkbook = xlApp.Workbooks.Open(PathWordPress);
                excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
                excel.Range xlRange = xlWorksheet.UsedRange;
                String ValorCelda = "";
                String Id = "";
                int numerofila = xlRange.Rows.Count;
                int numeroColum = xlRange.Columns.Count;
                //for (int fila = 2; fila < numerofila; fila++)
                //{
                //    for (int colunm = 1; colunm < 65; colunm++)
                //    {
                //        ValorCelda = xlWorksheet.Cells[fila, colunm].Value + "";
                //        Id = xlWorksheet.Cells[fila, 1].Value + "";
                //        Errores dtErrores = validar.DatoCelda(ValorCelda, colunm, fila, Id);
                //        if (dtErrores == null)
                //        {
                //            colunm = numeroColum;
                //            ILerror.Add(new Errores()
                //            {
                //                    celda = "A" + fila,
                //                error = "Verfique que el codigo de la fila sea numerico",
                //                Valor = Id
                //            });
                //        }
                //        else
                //        {
                //            if (dtErrores.error != "" && dtErrores.error != null)
                //            {
                //                ILerror.Add(new Errores()
                //                {
                //                    celda = dtErrores.celda,
                //                    error = dtErrores.error,
                //                    Valor = ValorCelda,
                //                    Sugerencia=dtErrores.Sugerencia
                //                });
                //            }
                //        }


                //    }
                //}
                if (ILerror.Count() == 0) {

                    for (int fila = 2; fila <= numerofila; fila++)
                    {
                        ValorCelda = xlWorksheet.Cells[fila, 73].Value + "";
                        Char delimiter = ',';
                        String[] novedadLista = ValorCelda.Split(delimiter);
                            for (int x = 0; x < novedadLista.Length; x++)
                            {
                          
                                string precio= xlWorksheet.Cells[fila, 53].Value + "";
                                string sfiltro = xlWorksheet.Cells[fila, 77].Value + "";
                                string sfecha = xlWorksheet.Cells[fila, 81].Value + "";
                                string semana = xlWorksheet.Cells[fila, 85].Value + "";
                            Id = xlWorksheet.Cells[fila, 1].Value + "";
                                 wp_novedad insertNovedad=  novedad.validarNovedad(Id, precio, novedadLista[x], sfiltro, sfecha, semana);
                                if ( insertNovedad!= null && insertNovedad.wp_tpo_nov!=0)
                                {
                                    Inovedad.Add(new wp_novedad()
                                    {
                                        wp_nov_posts_id = insertNovedad.wp_nov_posts_id,
                                        wp_nov_activa = insertNovedad.wp_nov_activa,
                                        wp_nov_val_act = insertNovedad.wp_nov_val_act,
                                        wp_nov_val_ant= insertNovedad.wp_nov_val_ant,
                                        wp_nov_fecha= insertNovedad.wp_nov_fecha,
                                        wp_tpo_nov= insertNovedad.wp_tpo_nov,
                                        wp_nov_dia_ing = insertNovedad.wp_nov_dia_ing,
                                        wp_nov_semana_ing = insertNovedad.wp_nov_semana_ing,
                                        filtro =insertNovedad.filtro
                                    });
                                 }
                            }
                    }
                    if (Inovedad.Count() > 0) {

                        qrynovedad.InsertNovedad(Inovedad);
                    }
                }
                xlWorkbook.Close();
                xlApp.Quit();

                return ILerror;
            }
            catch (Exception e)
            {

                throw new System.ArgumentException("Error al cargar datos", "original"+ e.ToString());
            }
           

        }
    }
}
