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

namespace _06Publicaciones.Views.Autores
{
    public partial class frm_autores : Form
    {
        private AutorController autorController;
        public frm_autores()
        {
            InitializeComponent();
            autorController = new AutorController();
        }

        private void frm_Autores_Load(object sender, EventArgs e)
        {
            CargarAutores();
        }

        private void CargarAutores()
        {
            var autores = autorController.ObtenerTodosLosAutores();
            lst_Autores.DataSource = autores;
            lst_Autores.DisplayMember = "NombreCompleto";
            lst_Autores.ValueMember = "IdAutor";
        }

        private bool validarcampos(params TextBox[] cajadetexto)
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

        private void btn_Insertar_Click(object sender, EventArgs e)
        {
            try
            {

                if (!validarcampos(txt_Apellido, txt_Ciudad, txt_CodigoPostal, txt_Direccion, txt_Estado, txt_IdAutor, txt_Nombre))
                {
                    return;
                }

                var autor = new Autor
                {
                    IdAutor = txt_IdAutor.Text,
                    Apellido = txt_Apellido.Text,
                    Nombre = txt_Nombre.Text,
                    Telefono = txt_Telefono.Text,
                    Direccion = txt_Direccion.Text,
                    Ciudad = txt_Ciudad.Text,
                    Estado = txt_Estado.Text,
                    CodigoPostal = txt_CodigoPostal.Text
                };

                var insertado = autorController.InsertarAutor(autor);

                if (insertado != null)
                {
                    CargarAutores();
                    ErrorHandler.ManejarInsertar();

                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.ManejarErrorGeneral(ex, "Error al intentar agregar el autor.");
            }

        }
        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            txt_IdAutor.Clear();
            txt_Apellido.Clear();
            txt_Nombre.Clear();
            txt_Telefono.Clear();
            txt_Direccion.Clear();
            txt_Ciudad.Clear();
            txt_Estado.Clear();
            txt_CodigoPostal.Clear();

        }


        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (lst_Autores.SelectedValue != null)
            {
                var autor = autorController.ObtenerAutorPorId(lst_Autores.SelectedValue.ToString());
                if (autor != null)
                {
                    txt_IdAutor.Text = autor.IdAutor;
                    txt_Apellido.Text = autor.Apellido;
                    txt_Nombre.Text = autor.Nombre;
                    txt_Telefono.Text = autor.Telefono;
                    txt_Direccion.Text = autor.Direccion;
                    txt_Ciudad.Text = autor.Ciudad;
                    txt_Estado.Text = autor.Estado;
                    txt_CodigoPostal.Text = autor.CodigoPostal;
                }
                else
                {
                    ErrorHandler.ManejarErrorGeneral(null, "No se encontro el autor seleccionado.");
                }
            }
            else
            {
                ErrorHandler.ManejarErrorGeneral(null, "Seleccione un item de la lista.");
            }
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!validarcampos(txt_Apellido, txt_Ciudad, txt_CodigoPostal, txt_Direccion, txt_Estado, txt_IdAutor, txt_Nombre))
                {
                    return;
                }
                string idAutorOriginal = txt_IdAutor.Text;

                var autor = new Autor
                {
                    IdAutor = idAutorOriginal,
                    Apellido = txt_Apellido.Text,
                    Nombre = txt_Nombre.Text,
                    Telefono = txt_Telefono.Text,
                    Direccion = txt_Direccion.Text,
                    Ciudad = txt_Ciudad.Text,
                    Estado = txt_Estado.Text,
                    CodigoPostal = txt_CodigoPostal.Text
                };

                var resultado = autorController.ActualizarAutor(autor);

                if (resultado == "OK")
                {
                    ErrorHandler.ManejarActualizar();
                    CargarAutores();
                }
                else
                {
                    ErrorHandler.ManejarErrorGeneral(null, "No se pudo actualizar el autor.");
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.ManejarErrorGeneral(ex, "Error al actualizar el autor.");

            }
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (lst_Autores.SelectedItem == null)
                {
                    ErrorHandler.ManejarErrorGeneral(null, "Seleccione un autor de la lista para eliminar.");
                    return;
                }

                var idAutor = lst_Autores.SelectedValue.ToString();
                var resultado = autorController.EliminarAutor(idAutor);

                if (resultado == "OK")
                {
                    ErrorHandler.ManejarEliminar();
                    CargarAutores();

                }
                else if (resultado == "Error de restricción de clave foranea")
                {
                    MessageBox.Show("No se puede eliminar el autor debido a restricciones de clave foranea de la Base de Datos", "Error de Eliminacion", MessageBoxButtons.OK);
                }
                else
                {
                    ErrorHandler.ManejarErrorGeneral(null, "No se pudo eliminar el autor.");
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.ManejarErrorGeneral(ex, "Error al eliminar el autor.");
            }
        }
    }
}
