using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaDatos;
using capaEntidades;

namespace capaNegocio
{
    public class logicaDatoComentario
    {
         accesoDatoComentarios ac = new accesoDatoComentarios();

        public int insertarComentario(clsComentariosEntity co)
        {
            return ac.insertarComentarios(co);
        }

        public List<clsComentariosEntity> listarComentarios()
        {
            return ac.listarComentarios();
        }

        public int eliminarComentario(int idComent)
        {
            return ac.eliminarComentarios(idComent);
        }

        public int editarComentario(clsComentariosEntity co)
        {
            return ac.editarComentarios(co);
        }

        public List<clsComentariosEntity> buscarComentario(string dato)
        {
            return ac.buscarComentarios(dato);
        }
    }
}
