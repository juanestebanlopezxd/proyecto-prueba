using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Lista_Materias
    {
        private List<Materia> col_materias = new List<Materia>();


        public void agg_materia(Materia materia)
        {
            col_materias.Add(materia);
        }

        public List<Materia> coleccion_materias()
        {
            return col_materias;

        }

        //public void actualizar_docente(Docente docente)
        //{

        //    Docente docente1 = col_docentes.Where(d => d.Id == docente.Id).FirstOrDefault();
        //    docente1.Id = docente.Id;
        //    docente1.Nombre = docente.Nombre;
        //    docente1.Telefono = docente.Telefono;
        //}

        public void eliminar_materia(string Idmate)
        {

            Materia materia1 = col_materias.Where(d => d.Id == Idmate).FirstOrDefault();
            col_materias.Remove(materia1);
        }

    }
}
