using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaDatos;
using capaEntidades;

namespace capaNegocio
{
    class logicaDatoUsuario
    {
        accesoDatoUsuario ac = new accesoDatoUsuario();

        public int insertarUsuario(clsUsuarioEntity co)
        {
            return ac.insertarUsuario(co);
        }

        public List<clsUsuarioEntity> listarUsuario()
        {
            return ac.listarUsuario();
        }

        public int eliminarUsuario(int idUsua)
        {
            return ac.eliminarUsuario(idUsua);
        }

        public int editarUsuario(clsUsuarioEntity co)
        {
            return ac.editarUsuario(co);
        }

        public List<clsUsuarioEntity> buscarUsuario(string dato)
        {
            return ac.buscarUsuario(dato);
        }
    }
}
