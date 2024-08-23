using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _06Publicaciones.Models;

namespace _06Publicaciones.Controllers
{
    internal class TrabajoController
    {
        public string InsertarTrabajo(TrabajosModel trabajo)
        {
            return TrabajosModel.Insertar(trabajo);
        }

        public string ActualizarTrabajo(TrabajosModel trabajo)
        {
            return TrabajosModel.Actualizar(trabajo);
        }

        public string EliminarTrabajo(int idTrabajo)
        {
            return TrabajosModel.Eliminar(idTrabajo);
        }

        public TrabajosModel ObtenerTrabajoPorId(int idTrabajo)
        {
            return TrabajosModel.ObtenerPorId(idTrabajo);
        }

        public List<TrabajosModel> ObtenerTodosLosTrabajos()
        {
            return TrabajosModel.ObtenerTodos();
        }
    }
}
