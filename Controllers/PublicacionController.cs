using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using _06Publicaciones.Models;

namespace _06Publicaciones.Controllers
{
    class PublicacionController
    {
        public List<PublicacionesModel> ObtenerTodasLasPublicaciones()
        {
            return PublicacionesModel.ObtenerTodos();
        }
    }
}
