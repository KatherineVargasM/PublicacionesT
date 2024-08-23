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

namespace _06Publicaciones.Views.Trabajos
{
    public partial class frm_trabajo : Form
    {
        private TrabajoController trabajosController;
        public frm_trabajo()
        {
            InitializeComponent();
            trabajosController = new TrabajoController();
        }

        private void frm_trabajo_Load(object sender, EventArgs e)
        {
            CargarTrabajos();
        }

        private void CargarTrabajos()
        {
            var listaTrabajos = trabajosController.ObtenerTodosLosTrabajos();
            lst_Trabajos.DataSource = null;
            lst_Trabajos.DataSource = listaTrabajos;
            lst_Trabajos.DisplayMember = "DescripcionTrabajo";
            lst_Trabajos.ValueMember = "IdTrabajo";
        }

        private bool ValidarCampos(params TextBox[] cajadetexto)
        {
            foreach (var caja in cajadetexto)
            {
                if (string.IsNullOrWhiteSpace(caja.Text))
                {
                    MessageBox.Show("Complete la informacion", "Error", MessageBoxButtons.OK);
                    return false;
                }
            }
            return true;
        }

        private void btn_Insertar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarCampos(txt_Descripcion, txt_NivelMinimo, txt_NivelMaximo))
                {
                    return;
                }

                if (!int.TryParse(txt_NivelMinimo.Text, out int nivelMinimo) ||
                    !int.TryParse(txt_NivelMaximo.Text, out int nivelMaximo))
                {
                    MessageBox.Show("Solo se aceptan caracteres numericos.", "Error", MessageBoxButtons.OK);
                    return;
                }

                var trabajo = new TrabajosModel
                {
                    DescripcionTrabajo = txt_Descripcion.Text,
                    NivelMinimo = nivelMinimo,
                    NivelMaximo = nivelMaximo
                };

                var resultado = trabajosController.InsertarTrabajo(trabajo);

                if (resultado == "OK")
                {
                    CargarTrabajos();
                    ErrorHandler.ManejarInsertar();
                }
                else
                {
                    MessageBox.Show($"Error al agregar el trabajo: {resultado}", "Error", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar trabajo: {ex.Message}", "Error", MessageBoxButtons.OK);
            }
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarCampos(txt_Descripcion, txt_NivelMinimo, txt_NivelMaximo))
                {
                    return;
                }

                if (!int.TryParse(txt_NivelMinimo.Text, out int nivelMinimo) ||
                    !int.TryParse(txt_NivelMaximo.Text, out int nivelMaximo))
                {
                    MessageBox.Show("Solo se aceptan caracteres numericos.", "Error", MessageBoxButtons.OK);
                    return;
                }

                int idTrabajoSeleccionado = ObtenerIdTrabajoSeleccionado();

                var trabajo = new TrabajosModel
                {
                    IdTrabajo = idTrabajoSeleccionado,
                    DescripcionTrabajo = txt_Descripcion.Text,
                    NivelMinimo = nivelMinimo,
                    NivelMaximo = nivelMaximo
                };

                var resultado = trabajosController.ActualizarTrabajo(trabajo);

                if (resultado == "OK")
                {
                    CargarTrabajos();
                    ErrorHandler.ManejarActualizar();
                }
                else
                {
                    MessageBox.Show($"Error al actualizar el trabajo: {resultado}", "Error", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar trabajo: {ex.Message}", "Error", MessageBoxButtons.OK);
            }
        }

        private int ObtenerIdTrabajoSeleccionado()
        {
            if (lst_Trabajos.SelectedItem == null)
            {
                throw new Exception("Debe seleccionar un trabajo de la lista para modificar.");
            }
            return int.Parse(lst_Trabajos.SelectedValue.ToString());
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (lst_Trabajos.SelectedItem == null)
                {
                    MessageBox.Show("Seleccione un trabajo de la lista para eliminar.", "Error", MessageBoxButtons.OK);
                    return;
                }

                var idTrabajo = Convert.ToInt32(lst_Trabajos.SelectedValue);
                var resultado = trabajosController.EliminarTrabajo(idTrabajo);

                if (resultado == "OK")
                {
                    CargarTrabajos();
                    ErrorHandler.ManejarEliminar();
                }
                else
                {
                    MessageBox.Show($"Error al eliminar el trabajo: {resultado}", "Error", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar trabajo: {ex.Message}", "Error", MessageBoxButtons.OK);
            }
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            txt_Descripcion.Clear();
            txt_NivelMinimo.Clear();
            txt_NivelMaximo.Clear();
        }

        private void lst_Trabajos_DoubleClick(object sender, EventArgs e)
        {
            if (lst_Trabajos.SelectedValue != null)
            {
                var trabajo = trabajosController.ObtenerTrabajoPorId(Convert.ToInt32(lst_Trabajos.SelectedValue));

                if (trabajo != null)
                {
                    txt_Descripcion.Text = trabajo.DescripcionTrabajo;
                    txt_NivelMinimo.Text = trabajo.NivelMinimo.ToString();
                    txt_NivelMaximo.Text = trabajo.NivelMaximo.ToString();
                }
                else
                {
                    MessageBox.Show("Trabajo no encontrado.", "Error", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un item de la lista.", "Error", MessageBoxButtons.OK);
            }
        }
    }
}
