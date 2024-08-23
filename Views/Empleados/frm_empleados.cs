using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _06Publicaciones.config;
using _06Publicaciones.Controllers;
using _06Publicaciones.Models;

namespace _06Publicaciones.Views.Empleados
{
    public partial class frm_empleados : Form
    {
        private EmpleadoController empleadoController;
        public frm_empleados()
        {
            InitializeComponent();
            empleadoController = new EmpleadoController();
        }
        
        private void frm_empleados_Load(object sender, EventArgs e)
        {
            CargarEmpleados();
        }

        private void CargarEmpleados()
        {
            var listaEmpleados = empleadoController.ObtenerTodosLosEmpleados();
            lst_Empleados.DataSource = null;
            lst_Empleados.DataSource = listaEmpleados;
            lst_Empleados.DisplayMember = "NombreCompleto";
            lst_Empleados.ValueMember = "IdEmpleado";
        }

        private bool ValidarCampos(params TextBox[] cajadetexto)
        {
            foreach (var caja in cajadetexto)
            {
                if (string.IsNullOrWhiteSpace(caja.Text))
                {
                    ErrorHandler.ManejarErrorGeneral(null, "Complete la informacion");
                    return false;
                }
            }
            return true;
        }
        private bool EsEmpIdValido(string empId)
        {
            var patron = @"^[A-Z]{3}[1-9][0-9]{4}[FM]$|^[A-Z]-[A-Z][1-9][0-9]{4}[FM]$";
            return System.Text.RegularExpressions.Regex.IsMatch(empId, patron);
        }

        private void btn_Insertar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarCampos(txt_IDempleado, txt_Nombre, txt_InicialN, txt_Apellido, txt_IDtrabajo, txt_NivelTrabajo, txt_IDpublicacion))
                {
                    return;
                }

                if (!EsEmpIdValido(txt_IDempleado.Text))
                {
                    MessageBox.Show("El formato del ID de empleado no es valido.", "Error", MessageBoxButtons.OK);
                    return;
                }

                var empleado = new EmpleadosModel
                {
                    IdEmpleado = txt_IDempleado.Text,
                    Nombre = txt_Nombre.Text,
                    Inicial2doNombre = txt_InicialN.Text,
                    Apellido = txt_Apellido.Text,
                    IdTrabajo = Convert.ToInt32(txt_IDtrabajo.Text),
                    NivelTrabajo = Convert.ToInt32(txt_NivelTrabajo.Text),
                    IdPublicacion = txt_IDpublicacion.Text,
                    FechaContratacion = dtp_FechaContratacion.Value
                };

                empleadoController.InsertarEmpleado(empleado);
                CargarEmpleados();
                ErrorHandler.ManejarInsertar();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar empleado: {ex.Message}", "Error", MessageBoxButtons.OK);
            }
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarCampos(txt_IDempleado, txt_Nombre, txt_InicialN, txt_Apellido, txt_IDtrabajo, txt_NivelTrabajo, txt_IDpublicacion))
                {
                    return;
                }

                var empleado = new EmpleadosModel
                {
                    IdEmpleado = txt_IDempleado.Text,
                    Nombre = txt_Nombre.Text,
                    Inicial2doNombre = txt_InicialN.Text,
                    Apellido = txt_Apellido.Text,
                    IdTrabajo = Convert.ToInt32(txt_IDtrabajo.Text),
                    NivelTrabajo = Convert.ToInt32(txt_NivelTrabajo.Text),
                    IdPublicacion = txt_IDpublicacion.Text,
                    FechaContratacion = dtp_FechaContratacion.Value
                };

                var resultado = empleadoController.ActualizarEmpleado(empleado);

                if (resultado == "OK")
                {
                    CargarEmpleados();
                    ErrorHandler.ManejarActualizar();
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar el empleado.", "Error", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar empleado: {ex.Message}", "Error", MessageBoxButtons.OK);
            }
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (lst_Empleados.SelectedItem == null)
                {
                    ErrorHandler.ManejarErrorGeneral(null, "Seleccione un empleado de la lista para eliminar.");
                    return;
                }

                var idEmpleado = lst_Empleados.SelectedValue.ToString();
                var resultado = empleadoController.EliminarEmpleado(idEmpleado);

                if (resultado == "OK")
                {
                    ErrorHandler.ManejarEliminar();
                    CargarEmpleados();
                }
                else if (resultado.Contains("Error de restricción de clave foranea"))
                {
                    MessageBox.Show("No se puede eliminar el empleado debido a restricciones de clave foránea en la Base de Datos.", "Error de Eliminación", MessageBoxButtons.OK);
                }
                else
                {
                    ErrorHandler.ManejarErrorGeneral(null, "No se pudo eliminar el empleado: " + resultado);
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.ManejarErrorGeneral(ex, "Error al eliminar el empleado.");
            }
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            txt_IDempleado.Clear();
            txt_Nombre.Clear();
            txt_InicialN.Clear();
            txt_Apellido.Clear();
            txt_IDtrabajo.Clear();
            txt_NivelTrabajo.Clear();
            txt_IDpublicacion.Clear();
            dtp_FechaContratacion.Value = DateTime.Now;
        }

        private void lst_Empleados_DoubleClick(object sender, EventArgs e)
        {
            if (lst_Empleados.SelectedValue != null)
            {
                var empleado = empleadoController.ObtenerEmpleadoPorId(lst_Empleados.SelectedValue.ToString());

                if (empleado != null)
                {
                    txt_IDempleado.Text = empleado.IdEmpleado;
                    txt_Nombre.Text = empleado.Nombre;
                    txt_InicialN.Text = empleado.Inicial2doNombre;
                    txt_Apellido.Text = empleado.Apellido;
                    txt_IDtrabajo.Text = empleado.IdTrabajo.ToString();
                    txt_NivelTrabajo.Text = empleado.NivelTrabajo.ToString();
                    txt_IDpublicacion.Text = empleado.IdPublicacion;
                    dtp_FechaContratacion.Value = empleado.FechaContratacion;
                }
                else
                {
                    ErrorHandler.ManejarErrorGeneral(null, "No se encontro el empleado seleccionado.");
                }
            }
            else
            {
                ErrorHandler.ManejarErrorGeneral(null, "Seleccione un item de la lista.");
            }
        }
    }
}
