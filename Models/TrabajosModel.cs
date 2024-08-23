using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using _06Publicaciones.config;

namespace _06Publicaciones.Models
{
    internal class TrabajosModel
    {
        public int IdTrabajo { get; set; }
        public string DescripcionTrabajo { get; set; }
        public int NivelMinimo { get; set; }
        public int NivelMaximo { get; set; }

        public static string Insertar(TrabajosModel trabajo)
        {
            try
            {
                using (var conexion = ConexionBDD.GetConnection())
                {
                    var consulta = "INSERT INTO jobs (job_desc, min_lvl, max_lvl) " +
                                   "OUTPUT INSERTED.job_id, INSERTED.job_desc, INSERTED.min_lvl, INSERTED.max_lvl " +
                                   "VALUES (@DescripcionTrabajo, @NivelMinimo, @NivelMaximo)";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@DescripcionTrabajo", trabajo.DescripcionTrabajo);
                        comando.Parameters.AddWithValue("@NivelMinimo", trabajo.NivelMinimo);
                        comando.Parameters.AddWithValue("@NivelMaximo", trabajo.NivelMaximo);

                        using (var lector = comando.ExecuteReader())
                        {
                            if (lector.Read())
                            {
                                return "OK";
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                ErrorHandler.ManejarErrorSql(ex, "Error al insertar el trabajo.");
                return $"Error SQL: {ex.Message}";
            }
            catch (Exception ex)
            {
                ErrorHandler.ManejarErrorGeneral(ex, "Error al insertar el trabajo.");
                return $"Error: {ex.Message}";
            }
            return "Error";
        }

        public static string Actualizar(TrabajosModel trabajo)
        {
            try
            {
                using (var conexion = ConexionBDD.GetConnection())
                {
                    var consulta = "UPDATE jobs SET job_desc = @DescripcionTrabajo, min_lvl = @NivelMinimo, max_lvl = @NivelMaximo " +
                                   "WHERE job_id = @IdTrabajo";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@IdTrabajo", trabajo.IdTrabajo);
                        comando.Parameters.AddWithValue("@DescripcionTrabajo", trabajo.DescripcionTrabajo);
                        comando.Parameters.AddWithValue("@NivelMinimo", trabajo.NivelMinimo);
                        comando.Parameters.AddWithValue("@NivelMaximo", trabajo.NivelMaximo);

                        comando.ExecuteNonQuery();
                    }
                }
                return "OK";
            }
            catch (SqlException ex)
            {
                ErrorHandler.ManejarErrorSql(ex, "Error al actualizar el trabajo.");
                return $"Error SQL: {ex.Message}";
            }
            catch (Exception ex)
            {
                ErrorHandler.ManejarErrorGeneral(ex, "Error al actualizar el trabajo.");
                return $"Error: {ex.Message}";
            }
        }

        public static string Eliminar(int idTrabajo)
        {
            try
            {
                using (var conexion = ConexionBDD.GetConnection())
                {
                    var consulta = "DELETE FROM jobs WHERE job_id = @IdTrabajo";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@IdTrabajo", idTrabajo);

                        comando.ExecuteNonQuery();
                    }
                }
                return "OK";
            }
            catch (SqlException ex)
            {
                return $"Error SQL: {ex.Message}";
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";
            }
        }

        public static TrabajosModel ObtenerPorId(int idTrabajo)
        {
            try
            {
                using (var conexion = ConexionBDD.GetConnection())
                {
                    var consulta = "SELECT * FROM jobs WHERE job_id = @IdTrabajo";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@IdTrabajo", idTrabajo);

                        using (var lector = comando.ExecuteReader())
                        {
                            if (lector.Read())
                            {
                                return new TrabajosModel
                                {
                                    IdTrabajo = Convert.ToInt32(lector["job_id"]),
                                    DescripcionTrabajo = lector["job_desc"].ToString(),
                                    NivelMinimo = Convert.ToInt32(lector["min_lvl"]),
                                    NivelMaximo = Convert.ToInt32(lector["max_lvl"])
                                };
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                ErrorHandler.ManejarErrorSql(ex, "Error al obtener el trabajo.");
            }
            catch (Exception ex)
            {
                ErrorHandler.ManejarErrorGeneral(ex, "Error al obtener el trabajo.");
            }
            return null;
        }

        public static List<TrabajosModel> ObtenerTodos()
        {
            var trabajos = new List<TrabajosModel>();

            try
            {
                using (var conexion = ConexionBDD.GetConnection())
                {
                    var consulta = "SELECT * FROM jobs";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        using (var lector = comando.ExecuteReader())
                        {
                            while (lector.Read())
                            {
                                trabajos.Add(new TrabajosModel
                                {
                                    IdTrabajo = Convert.ToInt32(lector["job_id"]),
                                    DescripcionTrabajo = lector["job_desc"].ToString(),
                                    NivelMinimo = Convert.ToInt32(lector["min_lvl"]),
                                    NivelMaximo = Convert.ToInt32(lector["max_lvl"])
                                });
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                ErrorHandler.ManejarErrorSql(ex, "Error al obtener la lista de trabajos.");
            }
            catch (Exception ex)
            {
                ErrorHandler.ManejarErrorGeneral(ex, "Error al obtener la lista de trabajos.");
            }

            return trabajos;
        }
    }
}
