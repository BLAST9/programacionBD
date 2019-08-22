using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using capaEntidades;
using System.Data;

namespace capaDatos
{
    public class accesoDatoCuenta
    {
        SqlConnection cnx; //Conexion
        clsCuentaEntity S = new clsCuentaEntity();
        conexion cn = new conexion();
        SqlCommand cm = null;
        int indicador = 0;
        SqlDataReader dr = null;
        List<clsCuentaEntity> ListaCuenta = null;

        public int insertarCuentas(clsCuentaEntity co)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("Cuenta", cnx);
                cm.Parameters.AddWithValue("@B", 1);
                cm.Parameters.AddWithValue("@IdCuenta", "");
                cm.Parameters.AddWithValue("@Nombresuser", co.nombreUser);
                cm.Parameters.AddWithValue("@Clave", co.clave);
                cm.Parameters.AddWithValue("@Rol", co.rol);
                cm.Parameters.AddWithValue("@IdUsuario", co.idUsuario);

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                cm.ExecuteNonQuery();
                indicador = 1;
            }
            catch (Exception e)
            {
                e.Message.ToString();
                indicador = 0;
            }
            finally
            {
                cm.Connection.Close();
            }
            return indicador;
        }

        public List<clsCuentaEntity> listarCuenta()
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("Cuenta", cnx);
                cm.Parameters.AddWithValue("@B", 1);
                cm.Parameters.AddWithValue("@IdCuenta", "");
                cm.Parameters.AddWithValue("@Nombresuser", "");
                cm.Parameters.AddWithValue("@Clave", "");
                cm.Parameters.AddWithValue("@Rol", "");
                cm.Parameters.AddWithValue("@IdUsuario", "");


                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                ListaCuenta = new List<clsCuentaEntity>();
                while (dr.Read())
                {
                    clsCuentaEntity c = new clsCuentaEntity();
                    c.idCuenta = Convert.ToInt32(dr["IdCuenta"].ToString());
                    c.nombreUser = dr["Nombresuser"].ToString();
                    c.clave = dr["Clave"].ToString();
                    c.rol = dr["Rol"].ToString();
                    c.idUsuario = Convert.ToInt32(dr["IdUsuario"].ToString());
                    ListaCuenta.Add(c);
                }
            }
            catch (Exception e)
            {
                e.Message.ToString();
                ListaCuenta = null;
            }
            finally
            {
                cm.Connection.Close();
            }
            return ListaCuenta;
        }

        public int eliminarCuentas(int idCuent)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("Cuenta", cnx);
                cm.Parameters.AddWithValue("@B", 1);
                cm.Parameters.AddWithValue("@IdCuenta", idCuent);
                cm.Parameters.AddWithValue("@Nombresuser", "");
                cm.Parameters.AddWithValue("@Clave", "");
                cm.Parameters.AddWithValue("@Rol", "");
                cm.Parameters.AddWithValue("@IdUsuario", "");

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                cm.ExecuteNonQuery();
                indicador = 1;
            }
            catch (Exception e)
            {
                e.Message.ToString();
                indicador = 0;
            }
            finally
            {
                cm.Connection.Close();
            }
            return indicador;
        }

        public int editarCuentas(clsCuentaEntity idCuent)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("Cuenta", cnx);
                cm.Parameters.AddWithValue("@B", 1);
                cm.Parameters.AddWithValue("@IdCuenta", idCuent);
                cm.Parameters.AddWithValue("@Nombresuser", "");
                cm.Parameters.AddWithValue("@Clave", "");
                cm.Parameters.AddWithValue("@Rol", "");
                cm.Parameters.AddWithValue("@IdUsuario", "");

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                cm.ExecuteNonQuery();
                indicador = 1;
            }
            catch (Exception e)
            {
                e.Message.ToString();
                indicador = 0;
            }
            finally
            {
                cm.Connection.Close();
            }
            return indicador;
        }

        public List<clsCuentaEntity> buscarCuenta(string dato)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("Cuenta", cnx);
                cm.Parameters.AddWithValue("@B", 1);
                cm.Parameters.AddWithValue("@IdCuenta", "");
                cm.Parameters.AddWithValue("@Nombresuser", dato);
                cm.Parameters.AddWithValue("@Clave", "");
                cm.Parameters.AddWithValue("@Rol", dato);
                cm.Parameters.AddWithValue("@IdUsuario", "");

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                ListaCuenta = new List<clsCuentaEntity>();
                while (dr.Read())
                {
                    clsCuentaEntity c = new clsCuentaEntity();
                    c.idCuenta = Convert.ToInt32(dr["IdCuenta"].ToString());
                    c.nombreUser = dr["Nombresuser"].ToString();
                    c.clave = dr["Clave"].ToString();
                    c.rol = dr["Rol"].ToString();
                    c.idUsuario = Convert.ToInt32(dr["IdUsuario"].ToString());
                    ListaCuenta.Add(c);
                }
            }
            catch (Exception e)
            {
                e.Message.ToString();
                ListaCuenta = null;
            }

            finally
            {
                cm.Connection.Close();
            }

            return ListaCuenta;
        }
    }
}
