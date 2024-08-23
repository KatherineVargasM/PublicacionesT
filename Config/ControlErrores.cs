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
            MessageBox.Show("Autor agregado con exito.", "Informacion", MessageBoxButtons.OK);
        }

        public static void ManejarActualizar()
        {
            MessageBox.Show("Autor actualizado con exito.", "Información", MessageBoxButtons.OK); ;
        }

        public static void ManejarEliminar()
        {
            MessageBox.Show("Autor eliminado con exito.", "Informacion", MessageBoxButtons.OK);
        }
    }
}
