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
    public class accesoDatoComentarios
    {
        SqlConnection cnx; //Conexion
        clsComentariosEntity S = new clsComentariosEntity();
        conexion cn = new conexion();
        SqlCommand cm = null;
        int indicador = 0;
        SqlDataReader dr = null;
        List<clsComentariosEntity> ListaComentarios = null;

        public int insertarComentarios(clsComentariosEntity co)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("Comentar", cnx);
                cm.Parameters.AddWithValue("@B", 1);
                cm.Parameters.AddWithValue("@IdComentario", "");
                cm.Parameters.AddWithValue("@Nombres", co.nombres);
                cm.Parameters.AddWithValue("@Correo", co.correo);
                cm.Parameters.AddWithValue("@Telefono", co.telefono);
                cm.Parameters.AddWithValue("@Mensaje", co.mensaje);

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

        public List<clsComentariosEntity> listarComentarios()
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("Comentar", cnx);
                cm.Parameters.AddWithValue("@B", 1);
                cm.Parameters.AddWithValue("@IdComentario", "");
                cm.Parameters.AddWithValue("@Nombres", "");
                cm.Parameters.AddWithValue("@Correo", "");
                cm.Parameters.AddWithValue("@Telefono", "");
                cm.Parameters.AddWithValue("@Mensaje", "");

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                ListaComentarios = new List<clsComentariosEntity>();
                while (dr.Read())
                {
                    clsComentariosEntity c = new clsComentariosEntity();
                    c.idComentarios = Convert.ToInt32(dr["IdComentario"].ToString());
                    c.nombres = dr["Nombres"].ToString();
                    c.correo = dr["Correo"].ToString();
                    c.telefono = dr["Telefono"].ToString();
                    c.mensaje = dr["Mensaje"].ToString();
                    ListaComentarios.Add(c);
                }
            }
            catch (Exception e)
            {
                e.Message.ToString();
                ListaComentarios = null;
            }
            finally
            {
                cm.Connection.Close();
            }
            return ListaComentarios;
        }

        public int eliminarComentarios(int idComent)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("Comentar", cnx);
                cm.Parameters.AddWithValue("@B", 1);
                cm.Parameters.AddWithValue("@IdComentario", idComent);
                cm.Parameters.AddWithValue("@Nombres", "");
                cm.Parameters.AddWithValue("@Correo", "");
                cm.Parameters.AddWithValue("@Telefono", "");
                cm.Parameters.AddWithValue("@Mensaje", "");

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

        public int editarComentarios(clsComentariosEntity co)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("Comentar", cnx);
                cm.Parameters.AddWithValue("@B", 1);
                cm.Parameters.AddWithValue("@IdComentario", co.idComentarios);
                cm.Parameters.AddWithValue("@Nombres", "");
                cm.Parameters.AddWithValue("@Correo", "");
                cm.Parameters.AddWithValue("@Telefono", "");
                cm.Parameters.AddWithValue("@Mensaje", "");

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

        public List<clsComentariosEntity> buscarComentarios(string dato)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("Comentar", cnx);
                cm.Parameters.AddWithValue("@B", 1);
                cm.Parameters.AddWithValue("@IdComentario", "");
                cm.Parameters.AddWithValue("@Nombres", dato);
                cm.Parameters.AddWithValue("@Correo", "");
                cm.Parameters.AddWithValue("@Telefono", "");
                cm.Parameters.AddWithValue("@Mensaje", dato);

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                ListaComentarios = new List<clsComentariosEntity>();
                while (dr.Read())
                {
                    clsComentariosEntity c = new clsComentariosEntity();
                    c.idComentarios = Convert.ToInt32(dr["IdComentario"].ToString());
                    c.nombres = dr["Nombres"].ToString();
                    c.correo = dr["Correo"].ToString();
                    c.telefono = dr["Telefono"].ToString();
                    c.mensaje = dr["Mensaje"].ToString();
                    ListaComentarios.Add(c);
                }
            }
            catch (Exception e)
            {
                e.Message.ToString();
                ListaComentarios = null;
            }

            finally
            {
                cm.Connection.Close();
            }

            return ListaComentarios;
        }
    }

}
