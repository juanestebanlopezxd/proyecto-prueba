using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;

namespace Datos
{
    public class Datos_Salones
    {
        string ruta = "Salones.txt";
        Lista_Salones lista_sal = new Lista_Salones();



        public bool GuardarSalon(string linea)
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

        public Lista_Salones leer_salones()
        {
            try
            {
                Lista_Salones lst_sal = new Lista_Salones();
                StreamReader lector = new StreamReader(ruta);
                string linea;
                while (!lector.EndOfStream)
                {
                    Salon salon = new Salon();
                    linea = lector.ReadLine();
                    string[] items = linea.Split(';');
                    salon.Id = items[0];
                    salon.Numsalon = items[1];
                    salon.bloque = items[2];
                    lst_sal.agg_salon(salon);
                }
                lector.Close();
                return lst_sal;
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

