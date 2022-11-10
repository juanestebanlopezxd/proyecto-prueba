using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;

namespace Datos
{
     public class Datos_Docentes
     {
        string ruta = "Docentes.txt";
        Lista_Docentes lista_doc = new Lista_Docentes();



        public bool GuardarDocente(string linea)
        {
            try
            {
                StreamWriter escritor = new StreamWriter(ruta, true);
                escritor.WriteLine(linea);
                escritor.Close();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
            
        }

        public Lista_Docentes leer_docentes()
        {
            try
            {
                Lista_Docentes lst_docen = new Lista_Docentes();
                StreamReader lector = new StreamReader(ruta);
                string linea;
                while (!lector.EndOfStream)
                {
                    Docente docen = new Docente();
                    linea = lector.ReadLine();
                    string[] items = linea.Split(';');
                    docen.Id = items[0];
                    docen.Nombre = items[1];    
                    docen.Telefono = items[2];
                    lst_docen.agg_docente(docen);
                }
                lector.Close();
                    return lst_docen;
            }
            catch (Exception)
            {

                return null;
            }
        }

        public void eliminar_archivo_doc()
        {
            File.Delete(ruta);
        }











     }
}
