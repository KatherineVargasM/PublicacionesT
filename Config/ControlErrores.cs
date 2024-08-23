﻿using System;
using System.Windows.Forms;

namespace _06Publicaciones.config
{
    public static class ErrorHandler
    {
        public static void ManejarErrorSql(Exception ex, string mensajePersonalizado = "Ocurrio un error en la base de datos.")
        {
            MessageBox.Show($"{mensajePersonalizado}\n\nDetalles del error:\n{ex.Message}", "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ManejarErrorGeneral(Exception ex=null, string mensajePersonalizado = "Ocurrio un error inesperado.")
        {
            if (ex != null)
            {
                MessageBox.Show($"{mensajePersonalizado}\n\nDetalles del error:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else { 
                MessageBox.Show(mensajePersonalizado);
            }
        }

        public static void ManejarInsertar() {
            MessageBox.Show("Se inserto con exito");
        }

        public static void ManejarActualizar()
        {
            MessageBox.Show("Se actualizo con exito");
        }

        public static void ManejarEliminar()
        {
            MessageBox.Show("Se elimino con exito");
        }
    }
}
