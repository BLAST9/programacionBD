using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidades
{
    public class clsSolicitudEntity
    {
        public int idSolicitudes { get; set; }
        public String aula { get; set; }
        public String nivel { get; set; }
        public String fechaSolicitud { get; set; }
        public String fechaUso { get; set; }
        public String horarioInicio { get; set; }
        public String horaFinal { get; set; }
        public String carrera { get; set; }
        public String asignatura { get; set; }
        public int idrecurso { get; set; }
        public int idUsuario { get; set; }
    }
}
