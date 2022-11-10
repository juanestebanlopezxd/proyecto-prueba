using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;

namespace Datos
{
    public class Datos_Materias
    {

        string ruta = "Materias.txt";
        Lista_Materias lista_mat = new Lista_Materias();



        public bool GuardarMater(string linea)
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

        public Lista_Materias leer_materias()
        {
            try
            {
                Lista_Materias lista_mat = new Lista_Materias();
                StreamReader lector = new StreamReader(ruta);
                string linea;
                while (!lector.EndOfStream)
                {
                    Materia materia = new Materia();
                    linea = lector.ReadLine();
                    string[] items = linea.Split(';');
                    materia.Id = items[0];
                    materia.Nombre = items[1];
                    materia.Creditos = items[2];
                    lista_mat.agg_materia(materia);
                }
                lector.Close();
                return lista_mat;
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
