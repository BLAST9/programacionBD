using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaDatos;
using capaEntidades;

namespace capaNegocio
{
    public class logicaDatoRecursos
    {
        accesoDatoRecurso ac = new accesoDatoRecurso();

        public int insertarRecurso(clsRecursosEntity co)
        {
            return ac.insertarRecursos(co);
        }

        public List<clsRecursosEntity> listarRecurso()
        {
            return ac.listarRecursos();
        }

        public int eliminarRecurso(int idRecur)
        {
            return ac.eliminarRecursos(idRecur);
        }

        public int editarRecurso(clsRecursosEntity co)
        {
            return ac.editarRecursos(co);
        }

        public List<clsRecursosEntity> buscarRecurso(string dato)
        {
            return ac.buscarRecursos(dato);
        }
    }
}
