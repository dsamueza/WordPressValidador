using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CDato.Query;
using CNegocio.Modelo;
namespace CNegocio.WordPress
{
   public class CeldasWordPress
    {
        #region Constructor
        ValidacionNuevo qery = new ValidacionNuevo();
        Errores errorvalidacionCelda = new Errores();
        private decimal IdCelda;
        #endregion
        /// <summary>
        /// Realiza validaciones por cedas
        /// </summary>
        /// <param name="Dato"></param>
        /// <param name="Column"></param>
        /// <param name="fila"></param>
        /// <param name="Id"></param>
        /// <returns></returns>
        public Errores DatoCelda(string Dato,int Column,int fila ,string Id) {
            try
            {
                
                Errores errorvalidacion = new Errores();
                IdCelda = Convert.ToDecimal(Id);
                switch (Column)
                {
                    case 1:
                        errorvalidacion = IdWP(Dato);
                        errorvalidacion.celda = "A" + fila;
                        break;
                    case 2:
                        errorvalidacion = NombreWP(Dato);
                        errorvalidacion.celda = "B" + fila;
                        break;
                    case 3:
                        errorvalidacion.error = PrecioWP(Dato);
                        errorvalidacion.celda = "C" + fila;
                        break;
                    case 4:
                        errorvalidacion = Categorias(Dato);
                        errorvalidacion.celda = "D" + fila;
                        break;
                    case 5:
                        errorvalidacion.error = ImagenProductoWP(Dato);
                        errorvalidacion.celda = "E" + fila;
                        break;
                    case 6:
                        errorvalidacion.error = EtiquetaWP(Dato, "Marca:");
                        errorvalidacion.celda = "F" + fila;
                        break;
                    case 7:
                        errorvalidacion = SubCategorias(Dato, "pa_marca");
                        errorvalidacion.celda = "G" + fila;
                        break;
                    case 8:
                        errorvalidacion.error = EstadoVisibleWP(Dato);
                        errorvalidacion.celda = "H" + fila;
                        break;
                    case 9:
                        errorvalidacion.error = EstadoVisibleWP(Dato);
                        errorvalidacion.celda = "I" + fila;
                        break;
                    case 10:
                        errorvalidacion.error = EtiquetaWP(Dato, "Compania:");
                        errorvalidacion.celda = "J" + fila;
                        break;
                    case 11:
                        errorvalidacion = SubCategorias(Dato, "pa_compania");
                        errorvalidacion.celda = "K" + fila;
                        break;
                    case 12:
                        errorvalidacion.error = EstadoVisibleWP(Dato);
                        errorvalidacion.celda = "L" + fila;
                        break;
                    case 13:
                        errorvalidacion.error = EstadoVisibleWP(Dato);
                        errorvalidacion.celda = "M" + fila;
                        break;
                    case 14:
                        errorvalidacion.error = EtiquetaWP(Dato, "Categoria");
                        errorvalidacion.celda = "N" + fila;
                        break;
                    case 15:
                        errorvalidacion = SubCategorias(Dato, "pa_categoria");
                        errorvalidacion.celda = "O" + fila;
                        break;
                    case 16:
                        errorvalidacion.error = EstadoVisibleWP(Dato);
                        errorvalidacion.celda = "P" + fila;
                        break;
                    case 17:
                        errorvalidacion.error = EstadoVisibleWP(Dato);
                        errorvalidacion.celda = "Q" + fila;
                        break;
                    case 18:
                        errorvalidacion.error = EtiquetaWP(Dato, "Distribuidor:");
                        errorvalidacion.celda = "R" + fila;
                        break;
                    case 19:
                        errorvalidacion = SubCategorias(Dato, "pa_distribuidor");
                        errorvalidacion.celda = "S" + fila;
                        break;
                    case 20:
                        errorvalidacion.error = EstadoVisibleWP(Dato);
                        errorvalidacion.celda = "T" + fila;
                        break;
                    case 21:
                        errorvalidacion.error = EstadoVisibleWP(Dato);
                        errorvalidacion.celda = "U" + fila;
                        break;
                    case 22:
                        errorvalidacion.error = EtiquetaWP(Dato, "Sabor:");
                        errorvalidacion.celda = "V" + fila;
                        break;
                    case 23:
                        errorvalidacion = SubCategorias(Dato, "pa_sabor");
                        errorvalidacion.celda = "W" + fila;
                        break;
                    case 24:
                        errorvalidacion.error = EstadoVisibleWP(Dato);
                        errorvalidacion.celda = "X" + fila;
                        break;
                    case 25:
                        errorvalidacion.error = EstadoVisibleWP(Dato);
                        errorvalidacion.celda = "Y" + fila;
                        break;
                    case 26:
                        errorvalidacion.error = EtiquetaWP(Dato, "Tamano:");
                        errorvalidacion.celda = "Z" + fila;
                        break;
                    case 27:
                        errorvalidacion = SubCategorias(Dato, "pa_tamano");
                        errorvalidacion.celda = "A" + fila;
                        break;
                    case 28:
                        errorvalidacion.error = EstadoVisibleWP(Dato);
                        errorvalidacion.celda = "AB" + fila;
                        break;
                    case 29:
                        errorvalidacion.error = EstadoVisibleWP(Dato);
                        errorvalidacion.celda = "AC" + fila;
                        break;
                    case 30:
                        errorvalidacion.error = EtiquetaWP(Dato, "Envase:");
                        errorvalidacion.celda = "AD" + fila;
                        break;
                    case 31:
                        errorvalidacion = SubCategorias(Dato, "pa_envase");
                        errorvalidacion.celda = "AE" + fila;
                        break;
                    case 32:
                        errorvalidacion.error = EstadoVisibleWP(Dato);
                        errorvalidacion.celda = "AF" + fila;
                        break;
                    case 33:
                        errorvalidacion.error = EstadoVisibleWP(Dato);
                        errorvalidacion.celda = "AG" + fila;
                        break;
                    case 34:
                        errorvalidacion.error = EtiquetaWP(Dato, "Lugar:");
                        errorvalidacion.celda = "AH" + fila;
                        break;
                    case 35:
                        errorvalidacion = SubCategorias(Dato, "pa_lugar");
                        errorvalidacion.celda = "AI" + fila;
                        break;
                    case 36:
                        errorvalidacion.error = EstadoVisibleWP(Dato);
                        errorvalidacion.celda = "AJ" + fila;
                        break;
                    case 37:
                        errorvalidacion.error = EstadoVisibleWP(Dato);
                        errorvalidacion.celda = "AK" + fila;
                        break;
                    case 38:
                        errorvalidacion.error = EtiquetaWP(Dato, "Canal:");
                        errorvalidacion.celda = "AL" + fila;
                        break;
                    case 39:
                        errorvalidacion = SubCategorias(Dato, "pa_canal");
                        errorvalidacion.celda = "AM" + fila;
                        break;
                    case 40:
                        errorvalidacion.error = EstadoVisibleWP(Dato);
                        errorvalidacion.celda = "AN" + fila;
                        break;
                    case 41:
                        errorvalidacion.error = EstadoVisibleWP(Dato);
                        errorvalidacion.celda = "AO" + fila;
                        break;
                   
                    case 42:
                        errorvalidacion.error = EtiquetaWP(Dato, "% Alcohol:");
                        errorvalidacion.celda = "AP" + fila;
                        break;
                    case 43:
                        try
                        {
                            string porcentaje = (Convert.ToDouble(Dato) * 100).ToString("#.##") + "%";
                            errorvalidacion = SubCategorias(porcentaje, "pa_grado-alcoholico");
                   
                        }
                        catch (Exception)
                        {
                            errorvalidacion = SubCategorias(Dato, "pa_grado-alcoholico");
                            errorvalidacion.celda = "AQ" + fila;
                        }
                      
                        break;
                    case 44:
                        errorvalidacion.error = EstadoVisibleWP(Dato);
                        errorvalidacion.celda = "AR" + fila;
                        break;
                    case 45:
                        errorvalidacion.error = EstadoVisibleWP(Dato);
                        errorvalidacion.celda = "AS" + fila;
                        break;
                    case 46:
                        
                        errorvalidacion.error = EtiquetaWP(Dato, "P.V.P anterior:");
                        errorvalidacion.celda = "AT" + fila;
                        break;
                    case 47:
                        
                        errorvalidacion.error = PrecioWP(Dato);
                        errorvalidacion.celda = "AU" + fila;
                        break;
                    case 48:
                        errorvalidacion.error = EstadoVisibleWP(Dato);
                        errorvalidacion.celda = "AV" + fila;
                        break;
                    case 49:
                        errorvalidacion.error = EstadoVisibleWP(Dato);
                        errorvalidacion.celda = "AW" + fila;
                        break;
                    case 50:

                        errorvalidacion.error = EtiquetaWP(Dato, "P.V.P:");
                        errorvalidacion.celda = "AX" + fila;
                        break;
                    case 51:

                        errorvalidacion.error = PrecioWP(Dato);
                        errorvalidacion.celda = "AY" + fila;
                        break;
                    case 52:
                        errorvalidacion.error = EstadoVisibleWP(Dato);
                        errorvalidacion.celda = "AZ" + fila;
                        break;
                    case 53:
                        errorvalidacion.error = EstadoVisibleWP(Dato);
                        errorvalidacion.celda = "BA" + fila;
                        break;
                    case 54:

                        errorvalidacion.error = EtiquetaWP(Dato, "P.V.D:");
                        errorvalidacion.celda = "BB" + fila;
                        break;
                    case 55:

                        errorvalidacion.error = PrecioWP(Dato);
                        errorvalidacion.celda = "BC" + fila;
                        break;
                    case 56:
                        errorvalidacion.error = EstadoVisibleWP(Dato);
                        errorvalidacion.celda = "BD" + fila;
                        break;
                    case 57:
                        errorvalidacion.error = EstadoVisibleWP(Dato);
                        errorvalidacion.celda = "BE" + fila;
                        break;
                    case 58:
                        errorvalidacion.error = EtiquetaWP(Dato, "Utilidad Real Incl. Imp:");
                        errorvalidacion.celda = "BF" + fila;
                        break;
                    case 59:
                        errorvalidacion.error = "";
                        errorvalidacion.celda = "BG" + fila;
                        break;
                    case 60:
                        errorvalidacion.error = EstadoVisibleWP(Dato);
                        errorvalidacion.celda = "BH" + fila;
                        break;
                    case 61:
                        errorvalidacion.error = EstadoVisibleWP(Dato);
                        errorvalidacion.celda = "BI" + fila;
                        break;
                    case 62:
                        errorvalidacion.error = EtiquetaWP(Dato, "Unidades / Caja");
                        errorvalidacion.celda = "BJ" + fila;
                        break;
                    case 63:
                        errorvalidacion = ValidaEnterosWP(Dato);
                        errorvalidacion.celda = "BK" + fila;
                        break;
                    case 64:
                        errorvalidacion.error = EstadoVisibleWP(Dato);
                        errorvalidacion.celda = "BL" + fila;
                        break;
                    case 65:
                        errorvalidacion.error = EstadoVisibleWP(Dato);
                        errorvalidacion.celda = "BM" + fila;
                        break;
                    default:
                        Console.WriteLine("Default case");
                     break;
                }
                return errorvalidacion;
            }
            catch (Exception)
            {

                return null ;
            }
           
                   
            
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public Errores ValidaEnterosWP(string ID)
        {
            try
            {
                int  idProducto = Convert.ToInt16(ID);

               }
            catch (Exception)
            {
                errorvalidacionCelda.error = "Verifique el valor";
                return errorvalidacionCelda;
            }
            errorvalidacionCelda.error = "";
            return errorvalidacionCelda;

        }
        /// <summary>
        /// Columna A del excel de WorPress 
        /// Codigo Producto
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public Errores IdWP(string ID) {
            try
            {
                decimal idProducto = Convert.ToDecimal(ID);

                if (qery.ProductoID(idProducto).Count() > 0)
                {
                    errorvalidacionCelda.error = "";
                    return errorvalidacionCelda;
                }
                else {
                    errorvalidacionCelda.error= "El producto no se encuentra ingresado";
                    return errorvalidacionCelda; 
                }
             

            }
            catch (Exception)
            {
                errorvalidacionCelda.error = "Verifique el valor";
                return errorvalidacionCelda;
            }
          
          
        }
        /// <summary>
        /// Nombres de Productos
        /// B
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public Errores NombreWP(string Nombre)
        {
            String msg = "";
            if (Nombre.Length > 201) {
                msg = "El texto del producto es demasiado grande ,";
            }
            if (qery.ProductoNombre(Nombre, IdCelda).Count() > 0)
            {
                errorvalidacionCelda.error = "";
                return errorvalidacionCelda;
            }
            else
            {
                errorvalidacionCelda.error = msg + "El nombre del producto es diferente al anterior ingreso. ";
                return errorvalidacionCelda;
            }

           
        }
        /// <summary>
        /// Validacion de precio del Producto
        /// Columna C
        /// </summary>
        /// <param name="Nombre"></param>
        /// <returns></returns>
        public string PrecioWP(string precio)
        {
            try
            {
               
                if (precio != "N/A") {
               
                decimal validacionDecimal = Convert.ToDecimal(precio);
                }

            }
            catch (Exception)
            {
                try
                {
                    Char caracter = '$';
                    string [] precioSin = precio.Trim().Split(caracter);
                    decimal validacionDecimal = Convert.ToDecimal(precioSin[1]);
                }
                catch (Exception)
                {

                    return "Escriba el valor en formato decimal(.), ($10.25))";
                }
                

            }
           

            return "";

        }
        /// <summary>
        /// Categorias que existen 
        /// </summary>
        /// <param name="categoria"></param>
        /// <returns></returns>
        public Errores Categorias(String categoria) {
            Char delimiter = ',';
            String[] categorias = categoria.Split(delimiter);
            string msg = "";
            string msgS = "";
            string msgLista = "";
            for (int i = 0; i < categorias.Length; i++)
            {
                 delimiter = '>';
                String[] subcategorias = categorias[i].Split(delimiter);
                for (int x = 0; x < subcategorias.Length; x++)
                {
                    if (qery.Categoria(subcategorias[x].Trim(), "product_cat").Count() < 1)
                    {
                        msgLista = msgLista+ (subcategorias[x]+",");

                    }
                }
            }
            if (!msgLista.Equals(""))
            {
                msg = "No existen las categorías   :" + msgLista;
                errorvalidacionCelda.error = msg;
                var sugerecia = qery.Sugerencia("product_cat");
                foreach (var se in sugerecia) {
                    msgS = msgS + se.name + ",";

                }
            }
            else {
                msg = ",";
                msgS = ",";
            }
         //   msgS = msgS.Remove(msg.Length - 1);
            msg = msg.Remove(msg.Length - 1);
            errorvalidacionCelda.error = msg;
            errorvalidacionCelda.Sugerencia = msgS;
            return errorvalidacionCelda;
        }
        /// <summary>
        /// Verifica si la imagen esta asignada a producto
        /// </summary>
        /// <param name="precio"></param>
        /// <returns></returns>
        public string ImagenProductoWP(string url)
        {
            try
            {
                String msg = "";

                if (qery.ImagenUrl(IdCelda, url)==null) {

                    msg = "El url de la imagen no se encuentra asignada al producto, verifique si la información es correcta.";
                }
                return msg;

            }
            catch (Exception)
            {

                return "Verifique la información  del campo";
            }


            

        }
        /// <summary>
        /// Verifica si el texto correcto
        /// </summary>
        /// <param name="precio"></param>
        /// <returns></returns>
        public string  EtiquetaWP(string EtiquetaI, string EtiquetaE)
        {
            try
            {
                String msg = "";

                if (!EtiquetaI.Equals(EtiquetaE))
                {

                    msg = "La etiqueta no es la correcta";
                }
                return msg;

            }
            catch (Exception)
            {

                return "Verifique la información  del campo";
            }




        }
        /// <summary>
        /// Verifica si existen las subcategosias
        /// </summary>
        /// <param name="categoria"></param>
        /// <param name="taxonomia"></param>
        /// <returns></returns>
        public Errores SubCategorias(String categoria, string taxonomia)
        {
            Char delimiter = ',';
            String[] categorias = categoria.Split(delimiter);
            string msg = "";
            string msgS = "";
            
            string msgLista = "";
            for (int i = 0; i < categorias.Length; i++)
            {
               
                    if (qery.Categoria(categorias[i].Trim(), taxonomia).Count() < 1)
                    {
                        msgLista = msgLista + (categorias[i] + ",");
                    }
               
            }
            if (!msgLista.Equals(""))
            {
                msg = "No existen las subcategorías  :" + msgLista;
                var sugerecia = qery.Sugerencia(taxonomia);
                foreach (var se in sugerecia)
                {
                    msgS = msgS  + se.name+ ",";

                }
            }
            else
            {
                msgS = ",";
                msg = ",";
            }

          
            msg = msg.Remove(msg.Length - 1);
            errorvalidacionCelda.error = msg;
            errorvalidacionCelda.Sugerencia = msgS;
            return errorvalidacionCelda;
           
        }
        public string EstadoVisibleWP(String visible)
        {
            try
            {
                int isvisible = Int16.Parse(visible);

                if (isvisible != 1) {
                   if( isvisible != 0){
                        return "El valor ingresado debe ser 1 o 0";
                    }
                   

                }
            }
            catch (Exception)
            {

                return "El valor ingresado debe ser 1 o 0";
            }
            return "";
        }

    }
}
