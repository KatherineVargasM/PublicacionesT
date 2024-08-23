using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _06Publicaciones.Models;

namespace _06Publicaciones.Controllers
{
    internal class EmpleadoController
    {
        public EmpleadosModel InsertarEmpleado(EmpleadosModel empleado)
        {
            return EmpleadosModel.Insertar(empleado);
        }

        public string ActualizarEmpleado(EmpleadosModel empleado)
        {
            return EmpleadosModel.Actualizar(empleado);
        }

        public string EliminarEmpleado(string idEmpleado)
        {
            return EmpleadosModel.Eliminar(idEmpleado);
        }

        public EmpleadosModel ObtenerEmpleadoPorId(string idEmpleado)
        {
            return EmpleadosModel.ObtenerPorId(idEmpleado);
        }

        public List<EmpleadosModel> ObtenerTodosLosEmpleados()
        {
            return EmpleadosModel.ObtenerTodos();
        }
    }
}
