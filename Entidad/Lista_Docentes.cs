using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
   
    public class Lista_Docentes
    {
        private List<Docente> col_docentes = new List<Docente> (); 
        

        public void agg_docente(Docente docente)
        {
            col_docentes.Add (docente);
        }

        public List<Docente> coleccion_docentes() 
        {
        return col_docentes;

        }

        public void actualizar_docente(Docente docente) {

            Docente docente1 = col_docentes.Where(d => d.Id == docente.Id).FirstOrDefault();
            docente1.Id = docente.Id;
            docente1.Nombre = docente.Nombre;
            docente1.Telefono = docente.Telefono;
        }

        public void eliminar_docente(string IDentificacion)
        {

            Docente docente1 = col_docentes.Where(d => d.Id == IDentificacion).FirstOrDefault();
            col_docentes.Remove(docente1);


        }


    }
}
