using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidades
{
    public class clsUsuarioEntity
    {
        public int idUsuario { get; set; }
        public String cedula { get; set; }
        public String nombre { get; set; }
        public String apellidos { get; set; }
        public String email { get; set; }
        public String telefono { get; set; }
    }
}
