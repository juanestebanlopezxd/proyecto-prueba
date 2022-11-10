using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Grupo
    {
        public string Nombre { get; set; }
        public List<Estudiante> Estudiantes { get; set; }
        public string Id { get; set; }
        public Docente Docente { get; set; }
        public string Horario { get; set; }
        public Materia Materia { get; set; }
        public Salon Salon { get; set; }

        public string Dsemana { get; set; }

    }
}
