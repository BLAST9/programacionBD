using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaDatos;
using capaEntidades;

namespace capaNegocio
{
    public class logicaDatoCuenta
    {
        accesoDatoCuenta ac = new accesoDatoCuenta();

        public int insertarCuenta(clsCuentaEntity co)
        {
            return ac.insertarCuentas(co);
        }

        public List<clsCuentaEntity> listarCuenta()
        {
            return ac.listarCuenta();
        }

        public int eliminarCuenta(int idCuent)
        {
            return ac.eliminarCuentas(idCuent);
        }

        public int editarCuenta(clsCuentaEntity co)
        {
            return ac.editarCuentas(co);
        }

        public List<clsCuentaEntity> buscarCuenta(string dato)
        {
            return ac.buscarCuenta(dato);
        }
    }
}
