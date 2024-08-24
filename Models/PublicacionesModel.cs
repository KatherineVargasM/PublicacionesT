using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using _06Publicaciones.config;

namespace _06Publicaciones.Models
{
    public class PublicacionesModel
    {
        public string IdPublicacion { get; set; }
        public string Logo { get; set; }
        public string Informacion { get; set; }

        public static List<PublicacionesModel> ObtenerTodos()
        {
            var listaPublicaciones = new List<PublicacionesModel>();
            using (var conexion = ConexionBDD.GetConnection())
            {
                var comando = new SqlCommand("SELECT pub_id, logo, pr_info FROM pub_info", conexion);
                using (var reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        listaPublicaciones.Add(new PublicacionesModel
                        {
                            IdPublicacion = reader["pub_id"] != DBNull.Value ? reader["pub_id"].ToString() : string.Empty, // Cambiado de Convert.ToInt32 a ToString()
                            Logo = reader["logo"]?.ToString() ?? string.Empty,
                            Informacion = reader["pr_info"]?.ToString() ?? string.Empty
                        });
                    }
                }
            }

            return listaPublicaciones;
        }
    }

}



