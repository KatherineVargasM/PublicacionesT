using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _06Publicaciones.Views.Empleados;
using _06Publicaciones.Views.Autores;
using _06Publicaciones.Views.Trabajos;
using _06Publicaciones.Views.Publicaciones;
using _06Publicaciones.Views.Ventas;
using _06Publicaciones.Views.Titulos;
using _06Publicaciones.Views.Titulo_Autor;
using _06Publicaciones.Views.Tiendas;
using _06Publicaciones.Views.Regalias;
using _06Publicaciones.Views.Descuentos;
using _06Publicaciones.Views.Editorial;


namespace _06Publicaciones.Views
{
    public partial class General : Form
    {
        public General()
        {
            InitializeComponent();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_empleados _Empleados = new frm_empleados();
            _Empleados.ShowDialog();
        }

        private void trabajosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_trabajo _Trabajos = new frm_trabajo();
            _Trabajos.ShowDialog();
        }

        private void publicacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_publicaciones _Publicaciones = new frm_publicaciones();
            _Publicaciones.ShowDialog();
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ventas _Ventas = new frm_ventas();
            _Ventas.ShowDialog();
        }

        private void autoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_autores _Autores = new frm_autores();
            _Autores.ShowDialog();

        }

        private void General_Resize(object sender, EventArgs e)
        {
            picture.Left = (this.ClientSize.Width - picture.Width) / 2;
            picture.Top = (this.ClientSize.Height - picture.Height) / 2;
        }

        private void publicacionesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frm_publicaciones _Publicaciones = new frm_publicaciones();
            _Publicaciones.ShowDialog();
        }

        private void títulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_titulo _Titulo = new frm_titulo();
            _Titulo.ShowDialog();
        }

        private void tituloAutorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_tituloAutor _TituloAutor = new frm_tituloAutor();
            _TituloAutor.ShowDialog();
        }

        private void tiendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_tiendas _Tiendas = new frm_tiendas();
            _Tiendas.ShowDialog();
        }

        private void regaliasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_regalias _Regalias = new frm_regalias();
            _Regalias.ShowDialog();
        }

        private void descuentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_descuentos _Descuentos = new frm_descuentos();
            _Descuentos.ShowDialog();
        }

        private void editorialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_editorial _Editorial = new frm_editorial();
            _Editorial.ShowDialog();
        }
    }
}
