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
    public class accesoDatoSolicitud
    {

        SqlConnection cnx; //Conexion
        clsSolicitudEntity S = new clsSolicitudEntity();
        conexion cn = new conexion();
        SqlCommand cm = null;
        int indicador = 0;
        SqlDataReader dr = null;
        List<clsSolicitudEntity> ListaSolicitud = null;

        public int insertarSolicitud(clsSolicitudEntity co)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("SolicitudPros", cnx);
                cm.Parameters.AddWithValue("@B", 1);
                cm.Parameters.AddWithValue("@IdSolicitud", "");
                cm.Parameters.AddWithValue("@Aula", co.aula);
                cm.Parameters.AddWithValue("@Nivel", co.nivel);
                cm.Parameters.AddWithValue("@FechaSolicitud", co.fechaSolicitud);
                cm.Parameters.AddWithValue("@Fechauso", co.fechaUso);
                cm.Parameters.AddWithValue("@Horainicio", co.horarioInicio);
                cm.Parameters.AddWithValue("@Horafinal", co.horaFinal);
                cm.Parameters.AddWithValue("@Carrera", co.carrera);
                cm.Parameters.AddWithValue("@Asignatura", co.asignatura);
                cm.Parameters.AddWithValue("@Idrecurso", co.idrecurso);
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

        public List<clsSolicitudEntity> listarSolicitud()
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("SolicitudPros", cnx);
                cm.Parameters.AddWithValue("@B", 1);
                cm.Parameters.AddWithValue("@IdSolicitud", "");
                cm.Parameters.AddWithValue("@Aula", "");
                cm.Parameters.AddWithValue("@Nivel", "");
                cm.Parameters.AddWithValue("@FechaSolicitud", "");
                cm.Parameters.AddWithValue("@Fechauso", "");
                cm.Parameters.AddWithValue("@Horainicio", "");
                cm.Parameters.AddWithValue("@Horafinal", "");
                cm.Parameters.AddWithValue("@Carrera", "");
                cm.Parameters.AddWithValue("@Asignatura", "");
                cm.Parameters.AddWithValue("@Idrecurso", "");
                cm.Parameters.AddWithValue("@IdUsuario", "");


                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                ListaSolicitud = new List<clsSolicitudEntity>();
                while (dr.Read())
                {
                    clsSolicitudEntity c = new clsSolicitudEntity();
                    c.idSolicitudes = Convert.ToInt32(dr["IdCuenta"].ToString());
                    c.aula = dr["Nombresuser"].ToString();
                    c.nivel = dr["Clave"].ToString();
                    c.fechaSolicitud = dr["Rol"].ToString();
                    c.fechaUso = dr["Nombresuser"].ToString();
                    c.horarioInicio = dr["Clave"].ToString();
                    c.horaFinal = dr["Rol"].ToString();
                    c.carrera = dr["Nombresuser"].ToString();
                    c.asignatura = dr["Clave"].ToString();
                    c.idrecurso = Convert.ToInt32(dr["IdUsuario"].ToString());
                    c.idUsuario = Convert.ToInt32(dr["IdUsuario"].ToString());
                    ListaSolicitud.Add(c);
                }
            }
            catch (Exception e)
            {
                e.Message.ToString();
                ListaSolicitud = null;
            }
            finally
            {
                cm.Connection.Close();
            }
            return ListaSolicitud;
        }

        public int eliminarSolicitud(int idSolic)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("SolicitudPros", cnx);
                cm.Parameters.AddWithValue("@B", 1);
                cm.Parameters.AddWithValue("@IdSolicitud", idSolic);
                cm.Parameters.AddWithValue("@Aula", "");
                cm.Parameters.AddWithValue("@Nivel", "");
                cm.Parameters.AddWithValue("@FechaSolicitud", "");
                cm.Parameters.AddWithValue("@Fechauso", "");
                cm.Parameters.AddWithValue("@Horainicio", "");
                cm.Parameters.AddWithValue("@Horafinal", "");
                cm.Parameters.AddWithValue("@Carrera", "");
                cm.Parameters.AddWithValue("@Asignatura", "");
                cm.Parameters.AddWithValue("@Idrecurso", "");
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

        public int editarSolicitud(clsSolicitudEntity idSolic)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("SolicitudPros", cnx);
                cm.Parameters.AddWithValue("@B", 1);
                cm.Parameters.AddWithValue("@IdSolicitud", idSolic);
                cm.Parameters.AddWithValue("@Aula", "");
                cm.Parameters.AddWithValue("@Nivel", "");
                cm.Parameters.AddWithValue("@FechaSolicitud", "");
                cm.Parameters.AddWithValue("@Fechauso", "");
                cm.Parameters.AddWithValue("@Horainicio", "");
                cm.Parameters.AddWithValue("@Horafinal", "");
                cm.Parameters.AddWithValue("@Carrera", "");
                cm.Parameters.AddWithValue("@Asignatura", "");
                cm.Parameters.AddWithValue("@Idrecurso", "");
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

        public List<clsSolicitudEntity> buscarSolicitud(string dato)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("SolicitudPros", cnx);
                cm.Parameters.AddWithValue("@B", 1);
                cm.Parameters.AddWithValue("@IdSolicitud", "");
                cm.Parameters.AddWithValue("@Aula", dato);
                cm.Parameters.AddWithValue("@Nivel", "");
                cm.Parameters.AddWithValue("@FechaSolicitud", dato);
                cm.Parameters.AddWithValue("@Fechauso", "");
                cm.Parameters.AddWithValue("@Horainicio", "");
                cm.Parameters.AddWithValue("@Horafinal", "");
                cm.Parameters.AddWithValue("@Carrera", dato);
                cm.Parameters.AddWithValue("@Asignatura", dato);
                cm.Parameters.AddWithValue("@Idrecurso", "");
                cm.Parameters.AddWithValue("@IdUsuario", "");

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                ListaSolicitud = new List<clsSolicitudEntity>();
                while (dr.Read())
                {
                    clsSolicitudEntity c = new clsSolicitudEntity();
                    c.idSolicitudes = Convert.ToInt32(dr["IdCuenta"].ToString());
                    c.aula = dr["Nombresuser"].ToString();
                    c.nivel = dr["Clave"].ToString();
                    c.fechaSolicitud = dr["Rol"].ToString();
                    c.fechaUso = dr["Nombresuser"].ToString();
                    c.horarioInicio = dr["Clave"].ToString();
                    c.horaFinal = dr["Rol"].ToString();
                    c.carrera = dr["Nombresuser"].ToString();
                    c.asignatura = dr["Clave"].ToString();
                    c.idrecurso = Convert.ToInt32(dr["IdUsuario"].ToString());
                    c.idUsuario = Convert.ToInt32(dr["IdUsuario"].ToString());
                    ListaSolicitud.Add(c);
                }
            }
            catch (Exception e)
            {
                e.Message.ToString();
                ListaSolicitud = null;
            }

            finally
            {
                cm.Connection.Close();
            }

            return ListaSolicitud;
        }
    }
}
