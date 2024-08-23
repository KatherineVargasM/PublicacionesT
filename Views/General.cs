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

    }
}
