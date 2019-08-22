using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaDatos;
using capaEntidades;

namespace capaNegocio
{
    public class logicaDatoSolicitud
    {
        accesoDatoSolicitud ac = new accesoDatoSolicitud();

        public int insertarSolicitud(clsSolicitudEntity co)
        {
            return ac.insertarSolicitud(co);
        }

        public List<clsSolicitudEntity> listarSolicitud()
        {
            return ac.listarSolicitud();
        }

        public int eliminarSolicitud(int idSolic)
        {
            return ac.eliminarSolicitud(idSolic);
        }

        public int editarSolicitud(clsSolicitudEntity co)
        {
            return ac.editarSolicitud(co);
        }

        public List<clsSolicitudEntity> buscarSolicitud(string dato)
        {
            return ac.buscarSolicitud(dato);
        }
    }
}
