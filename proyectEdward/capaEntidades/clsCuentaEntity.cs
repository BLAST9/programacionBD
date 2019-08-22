using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidades
{
    public class clsCuentaEntity
    {
        public int idCuenta { get; set; }
        public String nombreUser { get; set; }
        public String clave { get; set; }
        public String rol { get; set; }
        public int idUsuario { get; set; }
    }
}
