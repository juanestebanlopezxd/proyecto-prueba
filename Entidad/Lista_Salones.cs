using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Lista_Salones
    {
        private List<Salon> col_salones = new List<Salon>();


        public void agg_salon(Salon salon)
        {
            col_salones.Add(salon);
        }

        public List<Salon> coleccion_salones()
        {
            return col_salones;

        }

        //public void actualizar_docente(Docente docente)
        //{

        //    Docente docente1 = col_docentes.Where(d => d.Id == docente.Id).FirstOrDefault();
        //    docente1.Id = docente.Id;
        //    docente1.Nombre = docente.Nombre;
        //    docente1.Telefono = docente.Telefono;
        //}

        public void eliminar_docente(string NumeroSalon)
        {

            Salon salon1 = col_salones.Where(d => d.Numsalon == NumeroSalon).FirstOrDefault();
            col_salones.Remove(salon1);
        }
    }
}
