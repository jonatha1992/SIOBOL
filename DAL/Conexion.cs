using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Npgsql;

namespace DAL
{
    public class Conexion
    {

        static private NpgsqlConnection cn;
        static private NpgsqlCommand cmd;
        static private NpgsqlTransaction npgsqlTransaction;
        //static string ConexionsString = "Host=localhost;Port=5432;Username=postgres;Password=1q2w3e4r;Database=BDSIGEHA";
        static string ConexionsString = "Host=containers-us-west-156.railway.app;Port=6621;Username=postgres;Password=vik31Dmhwgh9lTMQVont;Database=railway";

        public bool TestConection()
        {
            try
            {
                cn = new NpgsqlConnection(ConexionsString);

                cn.Open();

                if (cn.State == ConnectionState.Open)
                {
                    return true;
                }
                return false;
            }
            catch (Exception e)
            {
                throw new Exception("Ocurrió una excepción en la conexion al servidor: " + e.Message, e );
            }
        }

        public DataTable Listar(string consulta, List<NpgsqlParameter> parametros)
        {
            DataTable dt = new DataTable();
            cmd = new NpgsqlCommand(consulta, cn);
            cmd.CommandType = CommandType.Text;
            try
            {
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);

                if (parametros != null)
                {
                    cmd.Parameters.AddRange(parametros.ToArray());
                }
                da.Fill(dt);
            }
            catch (NpgsqlException ex)
            {
                throw new Exception(ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cn.Close();
            }
            return dt;
        }

        public DataSet LeerDS(string consulta)
        {
            DataSet ds = new DataSet();
            try
            {
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(consulta, cn);
                da.Fill(ds);
            }
            catch (NpgsqlException ex)
            {
                throw new Exception(ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cn.Close();
            }
            return ds;
        }

        public bool Eliminar(string consulta, List<NpgsqlParameter> parametros)
        {
            if (cn.State == ConnectionState.Closed)
            {
                cn.Open();
            }
            try
            {
                npgsqlTransaction = cn.BeginTransaction();
                cmd = new NpgsqlCommand(consulta, cn, npgsqlTransaction);
                cmd.CommandType = CommandType.StoredProcedure;
                if (parametros != null)
                {
                    cmd.Parameters.AddRange(parametros.ToArray());
                }
                cmd.ExecuteNonQuery();
                npgsqlTransaction.Commit();
                return true;
            }
            catch (NpgsqlException ex)
            {
                npgsqlTransaction.Rollback();
                throw new Exception($"{ex.Message}");
            }
            catch (Exception ex)
            {
                npgsqlTransaction.Rollback();
                throw new Exception(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        public int? Agregar(string consulta, List<NpgsqlParameter> parametros)
        {
            if (cn.State == ConnectionState.Closed)
            {
                cn.Open();
            }
            try
            {
                npgsqlTransaction = cn.BeginTransaction();
                cmd = new NpgsqlCommand(consulta, cn, npgsqlTransaction);
                cmd.CommandType = CommandType.Text;
                if (parametros != null)
                {
                    cmd.Parameters.AddRange(parametros.ToArray());
                }

                // Usar ExecuteScalar para obtener el valor devuelto
                object result = cmd.ExecuteScalar();
                npgsqlTransaction.Commit();

                // Convertir el resultado a int y devolverlo
                return (result != null && result != DBNull.Value) ? (int?)result : null;
            }
            catch (NpgsqlException ex)
            {
                npgsqlTransaction.Rollback();
                throw new Exception($"{ex.Message}");
            }
            catch (Exception ex)
            {
                npgsqlTransaction.Rollback();
                throw new Exception(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        public bool Actualizar(string consulta, List<NpgsqlParameter> parametros)
        {
            if (cn.State == ConnectionState.Closed)
            {
                cn.Open();
            }
            try
            {
                npgsqlTransaction = cn.BeginTransaction();
                cmd = new NpgsqlCommand(consulta, cn, npgsqlTransaction);
                cmd.CommandType = CommandType.StoredProcedure;
                if (parametros != null)
                {
                    cmd.Parameters.AddRange(parametros.ToArray());
                }
                cmd.ExecuteNonQuery();
                npgsqlTransaction.Commit();
                return true;
            }
            catch (NpgsqlException ex)
            {
                npgsqlTransaction.Rollback();
                throw new Exception($"{ex.Message}");
            }
            catch (Exception ex)
            {
                npgsqlTransaction.Rollback();
                throw new Exception(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
