using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using _06Publicaciones.config;

namespace _06Publicaciones.Models
{
    internal class EmpleadosModel
    {
        public string IdEmpleado { get; set; }
        public string Nombre { get; set; }
        public string Inicial2doNombre { get; set; }
        public string Apellido { get; set; }
        public int IdTrabajo { get; set; }
        public int NivelTrabajo { get; set; }
        public string IdPublicacion { get; set; }
        public DateTime FechaContratacion { get; set; }

        public static EmpleadosModel Insertar(EmpleadosModel empleado)
        {
            try
            {
                using (var conexion = ConexionBDD.GetConnection())
                {
                    var consulta = "INSERT INTO employee (emp_id, fname, minit, lname, job_id, job_lvl, pub_id, hire_date) " +
                                   "OUTPUT INSERTED.emp_id, INSERTED.fname, INSERTED.minit, INSERTED.lname, INSERTED.job_id, " +
                                   "INSERTED.job_lvl, INSERTED.pub_id, INSERTED.hire_date " +
                                   "VALUES (@IdEmpleado, @Nombre, @Inicial2doNombre, @Apellido, @IdTrabajo, @NivelTrabajo, @IdPublicacion, @FechaContratacion)";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@IdEmpleado", empleado.IdEmpleado);
                        comando.Parameters.AddWithValue("@Nombre", empleado.Nombre);
                        comando.Parameters.AddWithValue("@Inicial2doNombre", empleado.Inicial2doNombre);
                        comando.Parameters.AddWithValue("@Apellido", empleado.Apellido);
                        comando.Parameters.AddWithValue("@IdTrabajo", empleado.IdTrabajo);
                        comando.Parameters.AddWithValue("@NivelTrabajo", empleado.NivelTrabajo);
                        comando.Parameters.AddWithValue("@IdPublicacion", empleado.IdPublicacion);
                        comando.Parameters.AddWithValue("@FechaContratacion", empleado.FechaContratacion);

                        using (var lector = comando.ExecuteReader())
                        {
                            if (lector.Read())
                            {
                                return new EmpleadosModel
                                {
                                    IdEmpleado = lector["emp_id"].ToString(),
                                    Nombre = lector["fname"].ToString(),
                                    Inicial2doNombre = lector["minit"].ToString(),
                                    Apellido = lector["lname"].ToString(),
                                    IdTrabajo = Convert.ToInt32(lector["job_id"]),
                                    NivelTrabajo = Convert.ToInt32(lector["job_lvl"]),
                                    IdPublicacion = lector["pub_id"].ToString(),
                                    FechaContratacion = Convert.ToDateTime(lector["hire_date"])
                                };
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                ErrorHandler.ManejarErrorSql(ex, "Error al insertar el empleado.");
            }
            catch (Exception ex)
            {
                ErrorHandler.ManejarErrorGeneral(ex, "Error al insertar el empleado.");
            }
            return null;
        }

        public string NombreCompleto
        {
            get { return $"{Nombre} {Apellido}"; }
        }


        public static string Actualizar(EmpleadosModel empleado)
        {
            try
            {
                using (var conexion = ConexionBDD.GetConnection())
                {
                    var consulta = "UPDATE employee SET fname = @Nombre, minit = @Inicial2doNombre, lname = @Apellido, " +
                                   "job_id = @IdTrabajo, job_lvl = @NivelTrabajo, pub_id = @IdPublicacion, hire_date = @FechaContratacion " +
                                   "WHERE emp_id = @IdEmpleado";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@IdEmpleado", empleado.IdEmpleado);
                        comando.Parameters.AddWithValue("@Nombre", empleado.Nombre);
                        comando.Parameters.AddWithValue("@Inicial2doNombre", empleado.Inicial2doNombre);
                        comando.Parameters.AddWithValue("@Apellido", empleado.Apellido);
                        comando.Parameters.AddWithValue("@IdTrabajo", empleado.IdTrabajo);
                        comando.Parameters.AddWithValue("@NivelTrabajo", empleado.NivelTrabajo);
                        comando.Parameters.AddWithValue("@IdPublicacion", empleado.IdPublicacion);
                        comando.Parameters.AddWithValue("@FechaContratacion", empleado.FechaContratacion);

                        comando.ExecuteNonQuery();
                    }
                }
                return "OK";
            }
            catch (SqlException ex)
            {
                ErrorHandler.ManejarErrorSql(ex, "Error al actualizar el empleado.");
                return "Error SQL";
            }
            catch (Exception ex)
            {
                ErrorHandler.ManejarErrorGeneral(ex, "Error al actualizar el empleado.");
                return "Error";
            }
        }
    

        public static string Eliminar(string idEmpleado)
        {
            try
            {
                using (var conexion = ConexionBDD.GetConnection())
                {
                    var consulta = "DELETE FROM employee WHERE emp_id = @IdEmpleado";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@IdEmpleado", idEmpleado);
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

        public static EmpleadosModel ObtenerPorId(string idEmpleado)
        {
            try
            {
                using (var conexion = ConexionBDD.GetConnection())
                {
                    var consulta = "SELECT * FROM employee WHERE emp_id = @IdEmpleado";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@IdEmpleado", idEmpleado);

                        using (var lector = comando.ExecuteReader())
                        {
                            if (lector.Read())
                            {
                                return new EmpleadosModel
                                {
                                    IdEmpleado = lector["emp_id"].ToString(),
                                    Nombre = lector["fname"].ToString(),
                                    Inicial2doNombre = lector["minit"].ToString(),
                                    Apellido = lector["lname"].ToString(),
                                    IdTrabajo = Convert.ToInt32(lector["job_id"]),
                                    NivelTrabajo = Convert.ToInt32(lector["job_lvl"]),
                                    IdPublicacion = lector["pub_id"].ToString(),
                                    FechaContratacion = Convert.ToDateTime(lector["hire_date"])
                                };
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                ErrorHandler.ManejarErrorSql(ex, "Error al obtener el empleado.");
            }
            catch (Exception ex)
            {
                ErrorHandler.ManejarErrorGeneral(ex, "Error al obtener el empleado.");
            }
            return null;
        }

        public static List<EmpleadosModel> ObtenerTodos()
        {
            var empleados = new List<EmpleadosModel>();

            try
            {
                using (var conexion = ConexionBDD.GetConnection())
                {
                    var consulta = "SELECT * FROM employee";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        using (var lector = comando.ExecuteReader())
                        {
                            while (lector.Read())
                            {
                                empleados.Add(new EmpleadosModel
                                {
                                    IdEmpleado = lector["emp_id"].ToString(),
                                    Nombre = lector["fname"].ToString(),
                                    Inicial2doNombre = lector["minit"].ToString(),
                                    Apellido = lector["lname"].ToString(),
                                    IdTrabajo = Convert.ToInt32(lector["job_id"]),
                                    NivelTrabajo = Convert.ToInt32(lector["job_lvl"]),
                                    IdPublicacion = lector["pub_id"].ToString(),
                                    FechaContratacion = Convert.ToDateTime(lector["hire_date"])
                                });
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                ErrorHandler.ManejarErrorSql(ex, "Error al obtener la lista de empleados.");
            }
            catch (Exception ex)
            {
                ErrorHandler.ManejarErrorGeneral(ex, "Error al obtener la lista de empleados.");
            }

            return empleados;
        }
    }

}
