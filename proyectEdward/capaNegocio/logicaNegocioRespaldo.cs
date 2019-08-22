using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaDatos;
using capaEntidades;

namespace capaNegocio
{
    public class logicaNegocioRespaldo
    {
        accesoDatosRespoaldoBD rbd = new accesoDatosRespoaldoBD();

        public int respladarBD()
        {
            return rbd.respaldarBD();
        }
    }
}
