using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Docente
    {
        public string Nombre { get; set; }
        public DateTime FechaIngreso { get; set; }
        public string Id { get; set; }
        public string Telefono { get; set; }
        public string SalonAsig { get; set; }

        public Docente()
        {

        }

        public Docente(string nombre, DateTime fechaIngreso, string id, string telefono, string salonAsig)
        {
            Nombre = nombre;
            FechaIngreso = fechaIngreso;
            Id = id;
            Telefono = telefono;
            SalonAsig = salonAsig;
        }
        public Docente(string id, string nombre, string telefono)
        {
            Nombre = nombre;
            Id = id;
            Telefono = telefono;
        }
        public Docente(string id)
        {
            Id = id;

        }
    }
}
