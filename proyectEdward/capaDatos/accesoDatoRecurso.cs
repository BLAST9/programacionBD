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
    public class accesoDatoRecurso
    {
        SqlConnection cnx; //Conexion
        clsRecursosEntity S = new clsRecursosEntity();
        conexion cn = new conexion();
        SqlCommand cm = null;
        int indicador = 0;
        SqlDataReader dr = null;
        List<clsRecursosEntity> ListaRecursos = null;

        public int insertarRecursos(clsRecursosEntity co)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("Recurso", cnx);
                cm.Parameters.AddWithValue("@B", 1);
                cm.Parameters.AddWithValue("@IdRecursos", "");
                cm.Parameters.AddWithValue("@Nombres", co.nombre);
                cm.Parameters.AddWithValue("@Codigo", co.codigo);
                cm.Parameters.AddWithValue("@Descripcion", co.descripcion);

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

        public List<clsRecursosEntity> listarRecursos()
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("Recurso", cnx);
                cm.Parameters.AddWithValue("@B", 6);
                cm.Parameters.AddWithValue("@IdRecursos", "");
                cm.Parameters.AddWithValue("@Nombres", "");
                cm.Parameters.AddWithValue("@Codigo", "");
                cm.Parameters.AddWithValue("@Descripcion", "");

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                ListaRecursos = new List<clsRecursosEntity>();
                while (dr.Read())
                {
                    clsRecursosEntity c = new clsRecursosEntity();
                    c.idRecursos = Convert.ToInt32(dr["idrecursois"].ToString());
                    c.nombre = dr["nombrer"].ToString();
                    c.codigo = dr["codigo"].ToString();
                    c.descripcion = dr["descripcion"].ToString();
                    ListaRecursos.Add(c);
                }
            }
            catch (Exception e)
            {
                e.Message.ToString();
                ListaRecursos = null;
            }
            finally
            {
                cm.Connection.Close();
            }
            return ListaRecursos;
        }

        public int eliminarRecursos(int idRecurs)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("Recurso", cnx);
                cm.Parameters.AddWithValue("@B", 2);
                cm.Parameters.AddWithValue("@IdRecursos", idRecurs);
                cm.Parameters.AddWithValue("@Nombres", "");
                cm.Parameters.AddWithValue("@Codigo", "");
                cm.Parameters.AddWithValue("@Descripcion", "");

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

        public int editarRecursos(clsRecursosEntity re)
        {
            try
            {
                SqlConnection cnx = cn.conectar();
                cm = new SqlCommand("Recurso", cnx);
                cm.Parameters.AddWithValue("@B", 3);
                cm.Parameters.AddWithValue("@IdRecursos", re.idRecursos);
                cm.Parameters.AddWithValue("@Nombres", re.nombre);
                cm.Parameters.AddWithValue("@Codigo", re.codigo);
                cm.Parameters.AddWithValue("@Descripcion", re.descripcion);

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

        public List<clsRecursosEntity> buscarRecursos(string dato)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("Recurso", cnx);
                cm.Parameters.AddWithValue("@B", 5);
                cm.Parameters.AddWithValue("@IdRecursos", "");
                cm.Parameters.AddWithValue("@Nombres", dato);
                cm.Parameters.AddWithValue("@Codigo", "");
                cm.Parameters.AddWithValue("@Descripcion", "");

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                ListaRecursos = new List<clsRecursosEntity>();
                while (dr.Read())
                {
                    clsRecursosEntity c = new clsRecursosEntity();
                    c.idRecursos = Convert.ToInt32(dr["idrecursois"].ToString());
                    c.nombre = dr["nombrer"].ToString();
                    c.codigo = dr["codigo"].ToString();
                    c.descripcion = dr["descripcion"].ToString();
                    ListaRecursos.Add(c);
                }
            
            }
            catch (Exception e)
            {
                e.Message.ToString();
                ListaRecursos = null;
            }

            finally
            {
                cm.Connection.Close();
            }

            return ListaRecursos;
        }
    }
}
