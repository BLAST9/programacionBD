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
    public class accesoDatoUsuario
    {
        SqlConnection cnx; //Conexion
        clsUsuarioEntity S = new clsUsuarioEntity();
        conexion cn = new conexion();
        SqlCommand cm = null;
        int indicador = 0;
        SqlDataReader dr = null;
        List<clsUsuarioEntity> ListaUsuario = null;

        public int insertarUsuario(clsUsuarioEntity co)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("Usuario", cnx);
                cm.Parameters.AddWithValue("@B", 1);
                cm.Parameters.AddWithValue("@IdUsuario", "");
                cm.Parameters.AddWithValue("@Cedula", co.cedula);
                cm.Parameters.AddWithValue("@Nombres", co.nombre);
                cm.Parameters.AddWithValue("@Apellidos", co.apellidos);
                cm.Parameters.AddWithValue("@Email", co.email);
                cm.Parameters.AddWithValue("@Telefono", co.telefono);

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

        public List<clsUsuarioEntity> listarUsuario()
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("Usuario", cnx);
                cm.Parameters.AddWithValue("@B", 1);
                cm.Parameters.AddWithValue("@IdUsuario", "");
                cm.Parameters.AddWithValue("@Cedula", "");
                cm.Parameters.AddWithValue("@Nombres", "");
                cm.Parameters.AddWithValue("@Apellidos", "");
                cm.Parameters.AddWithValue("@Email", "");
                cm.Parameters.AddWithValue("@Telefono", "");


                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                ListaUsuario = new List<clsUsuarioEntity>();
                while (dr.Read())
                {
                    clsUsuarioEntity c = new clsUsuarioEntity();
                    c.idUsuario = Convert.ToInt32(dr["IdUsuario"].ToString());
                    c.cedula = dr["Cedula"].ToString();
                    c.nombre = dr["Nombres"].ToString();
                    c.apellidos = dr["Apellidos"].ToString();
                    c.email = dr["Email"].ToString();
                    c.telefono = dr["Telefono"].ToString();
                    ListaUsuario.Add(c);
                }
            }
            catch (Exception e)
            {
                e.Message.ToString();
                ListaUsuario = null;
            }
            finally
            {
                cm.Connection.Close();
            }
            return ListaUsuario;
        }

        public int eliminarUsuario(int idUser)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("Usuario", cnx);
                cm.Parameters.AddWithValue("@B", 1);
                cm.Parameters.AddWithValue("@IdUsuario", idUser);
                cm.Parameters.AddWithValue("@Cedula", "");
                cm.Parameters.AddWithValue("@Nombres", "");
                cm.Parameters.AddWithValue("@Apellidos", "");
                cm.Parameters.AddWithValue("@Email", "");
                cm.Parameters.AddWithValue("@Telefono", "");

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

        public int editarUsuario(clsUsuarioEntity idUser)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("Usuario", cnx);
                cm.Parameters.AddWithValue("@B", 1);
                cm.Parameters.AddWithValue("@IdUsuario", idUser);
                cm.Parameters.AddWithValue("@Cedula", "");
                cm.Parameters.AddWithValue("@Nombres", "");
                cm.Parameters.AddWithValue("@Apellidos", "");
                cm.Parameters.AddWithValue("@Email", "");
                cm.Parameters.AddWithValue("@Telefono", "");

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

        public List<clsUsuarioEntity> buscarUsuario(string dato)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("Usuario", cnx);
                cm.Parameters.AddWithValue("@B", 1);
                cm.Parameters.AddWithValue("@IdUsuario", "");
                cm.Parameters.AddWithValue("@Cedula", dato);
                cm.Parameters.AddWithValue("@Nombres", dato);
                cm.Parameters.AddWithValue("@Apellidos", dato);
                cm.Parameters.AddWithValue("@Email", "");
                cm.Parameters.AddWithValue("@Telefono", "");

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                ListaUsuario = new List<clsUsuarioEntity>();
                while (dr.Read())
                {
                    clsUsuarioEntity c = new clsUsuarioEntity();
                    c.idUsuario = Convert.ToInt32(dr["IdUsuario"].ToString());
                    c.cedula = dr["Cedula"].ToString();
                    c.nombre = dr["Nombres"].ToString();
                    c.apellidos = dr["Apellidos"].ToString();
                    c.email = dr["Email"].ToString();
                    c.telefono = dr["Telefono"].ToString();
                    ListaUsuario.Add(c);
                }
            }
            catch (Exception e)
            {
                e.Message.ToString();
                ListaUsuario = null;
            }

            finally
            {
                cm.Connection.Close();
            }

            return ListaUsuario;
        }
    }
}
