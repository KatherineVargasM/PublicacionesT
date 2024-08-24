
namespace _06Publicaciones.Views.Empleados
{
    partial class frm_empleados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.lbl_Lista = new System.Windows.Forms.Label();
            this.lst_Empleados = new System.Windows.Forms.ListBox();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.btn_Insertar = new System.Windows.Forms.Button();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.txt_NivelTrabajo = new System.Windows.Forms.TextBox();
            this.txt_Apellido = new System.Windows.Forms.TextBox();
            this.txt_InicialN = new System.Windows.Forms.TextBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.txt_IDempleado = new System.Windows.Forms.TextBox();
            this.lbl_FechaContratacion = new System.Windows.Forms.Label();
            this.lbl_IDpublicacion = new System.Windows.Forms.Label();
            this.lbl_NivelTrabajo = new System.Windows.Forms.Label();
            this.lbl_IDtrabajo = new System.Windows.Forms.Label();
            this.lbl_Apellido = new System.Windows.Forms.Label();
            this.lbl_InicialN = new System.Windows.Forms.Label();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.lbl_IDempleado = new System.Windows.Forms.Label();
            this.dtp_FechaContratacion = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_IdPublicacion = new System.Windows.Forms.ComboBox();
            this.cmb_IdTrabajo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(357, 515);
            this.btn_Eliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(112, 36);
            this.btn_Eliminar.TabIndex = 44;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Location = new System.Drawing.Point(237, 515);
            this.btn_Modificar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(112, 36);
            this.btn_Modificar.TabIndex = 43;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // lbl_Lista
            // 
            this.lbl_Lista.AutoSize = true;
            this.lbl_Lista.Location = new System.Drawing.Point(524, 61);
            this.lbl_Lista.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Lista.Name = "lbl_Lista";
            this.lbl_Lista.Size = new System.Drawing.Size(153, 20);
            this.lbl_Lista.TabIndex = 42;
            this.lbl_Lista.Text = "Lista de Empleados:";
            // 
            // lst_Empleados
            // 
            this.lst_Empleados.FormattingEnabled = true;
            this.lst_Empleados.ItemHeight = 20;
            this.lst_Empleados.Location = new System.Drawing.Point(528, 84);
            this.lst_Empleados.Name = "lst_Empleados";
            this.lst_Empleados.Size = new System.Drawing.Size(318, 344);
            this.lst_Empleados.TabIndex = 41;
            this.lst_Empleados.DoubleClick += new System.EventHandler(this.lst_Empleados_DoubleClick);
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.Location = new System.Drawing.Point(216, 32);
            this.lbl_Titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(279, 29);
            this.lbl_Titulo.TabIndex = 23;
            this.lbl_Titulo.Text = "Gestión de Empleados";
            // 
            // btn_Insertar
            // 
            this.btn_Insertar.Location = new System.Drawing.Point(237, 469);
            this.btn_Insertar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Insertar.Name = "btn_Insertar";
            this.btn_Insertar.Size = new System.Drawing.Size(112, 36);
            this.btn_Insertar.TabIndex = 39;
            this.btn_Insertar.Text = "Grabar";
            this.btn_Insertar.UseVisualStyleBackColor = true;
            this.btn_Insertar.Click += new System.EventHandler(this.btn_Insertar_Click);
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.Location = new System.Drawing.Point(357, 469);
            this.btn_Limpiar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(112, 36);
            this.btn_Limpiar.TabIndex = 40;
            this.btn_Limpiar.Text = "Limpiar";
            this.btn_Limpiar.UseVisualStyleBackColor = true;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            // 
            // txt_NivelTrabajo
            // 
            this.txt_NivelTrabajo.Location = new System.Drawing.Point(207, 317);
            this.txt_NivelTrabajo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_NivelTrabajo.Name = "txt_NivelTrabajo";
            this.txt_NivelTrabajo.Size = new System.Drawing.Size(298, 26);
            this.txt_NivelTrabajo.TabIndex = 36;
            // 
            // txt_Apellido
            // 
            this.txt_Apellido.Location = new System.Drawing.Point(207, 232);
            this.txt_Apellido.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Apellido.Name = "txt_Apellido";
            this.txt_Apellido.Size = new System.Drawing.Size(298, 26);
            this.txt_Apellido.TabIndex = 34;
            // 
            // txt_InicialN
            // 
            this.txt_InicialN.Location = new System.Drawing.Point(207, 190);
            this.txt_InicialN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_InicialN.Name = "txt_InicialN";
            this.txt_InicialN.Size = new System.Drawing.Size(298, 26);
            this.txt_InicialN.TabIndex = 33;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(207, 146);
            this.txt_Nombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(298, 26);
            this.txt_Nombre.TabIndex = 32;
            // 
            // txt_IDempleado
            // 
            this.txt_IDempleado.Location = new System.Drawing.Point(208, 84);
            this.txt_IDempleado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_IDempleado.Name = "txt_IDempleado";
            this.txt_IDempleado.Size = new System.Drawing.Size(298, 26);
            this.txt_IDempleado.TabIndex = 31;
            // 
            // lbl_FechaContratacion
            // 
            this.lbl_FechaContratacion.AutoSize = true;
            this.lbl_FechaContratacion.Location = new System.Drawing.Point(29, 413);
            this.lbl_FechaContratacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_FechaContratacion.Name = "lbl_FechaContratacion";
            this.lbl_FechaContratacion.Size = new System.Drawing.Size(175, 20);
            this.lbl_FechaContratacion.TabIndex = 30;
            this.lbl_FechaContratacion.Text = "Fecha de Contratación:";
            // 
            // lbl_IDpublicacion
            // 
            this.lbl_IDpublicacion.AutoSize = true;
            this.lbl_IDpublicacion.Location = new System.Drawing.Point(89, 367);
            this.lbl_IDpublicacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_IDpublicacion.Name = "lbl_IDpublicacion";
            this.lbl_IDpublicacion.Size = new System.Drawing.Size(114, 20);
            this.lbl_IDpublicacion.TabIndex = 29;
            this.lbl_IDpublicacion.Text = "ID Publicación:";
            // 
            // lbl_NivelTrabajo
            // 
            this.lbl_NivelTrabajo.AutoSize = true;
            this.lbl_NivelTrabajo.Location = new System.Drawing.Point(79, 317);
            this.lbl_NivelTrabajo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_NivelTrabajo.Name = "lbl_NivelTrabajo";
            this.lbl_NivelTrabajo.Size = new System.Drawing.Size(125, 20);
            this.lbl_NivelTrabajo.TabIndex = 28;
            this.lbl_NivelTrabajo.Text = "Nivel de Trabajo:";
            // 
            // lbl_IDtrabajo
            // 
            this.lbl_IDtrabajo.AutoSize = true;
            this.lbl_IDtrabajo.Location = new System.Drawing.Point(116, 276);
            this.lbl_IDtrabajo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_IDtrabajo.Name = "lbl_IDtrabajo";
            this.lbl_IDtrabajo.Size = new System.Drawing.Size(87, 20);
            this.lbl_IDtrabajo.TabIndex = 27;
            this.lbl_IDtrabajo.Text = "ID Trabajo:";
            // 
            // lbl_Apellido
            // 
            this.lbl_Apellido.AutoSize = true;
            this.lbl_Apellido.Location = new System.Drawing.Point(139, 232);
            this.lbl_Apellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Apellido.Name = "lbl_Apellido";
            this.lbl_Apellido.Size = new System.Drawing.Size(69, 20);
            this.lbl_Apellido.TabIndex = 26;
            this.lbl_Apellido.Text = "Apellido:";
            // 
            // lbl_InicialN
            // 
            this.lbl_InicialN.AutoSize = true;
            this.lbl_InicialN.Location = new System.Drawing.Point(60, 190);
            this.lbl_InicialN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_InicialN.Name = "lbl_InicialN";
            this.lbl_InicialN.Size = new System.Drawing.Size(144, 20);
            this.lbl_InicialN.TabIndex = 25;
            this.lbl_InicialN.Text = "Inicial 2do Nombre:";
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Location = new System.Drawing.Point(134, 146);
            this.lbl_Nombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(69, 20);
            this.lbl_Nombre.TabIndex = 24;
            this.lbl_Nombre.Text = "Nombre:";
            // 
            // lbl_IDempleado
            // 
            this.lbl_IDempleado.AutoSize = true;
            this.lbl_IDempleado.Location = new System.Drawing.Point(97, 87);
            this.lbl_IDempleado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_IDempleado.Name = "lbl_IDempleado";
            this.lbl_IDempleado.Size = new System.Drawing.Size(106, 20);
            this.lbl_IDempleado.TabIndex = 22;
            this.lbl_IDempleado.Text = "ID Empleado:";
            // 
            // dtp_FechaContratacion
            // 
            this.dtp_FechaContratacion.Location = new System.Drawing.Point(207, 413);
            this.dtp_FechaContratacion.Name = "dtp_FechaContratacion";
            this.dtp_FechaContratacion.Size = new System.Drawing.Size(297, 26);
            this.dtp_FechaContratacion.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(243, 115);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "Formato: [A-Z] [A-Z] [A-Z] [1-9] [0-9] [0-9] [0-9] [0-9] [M]";
            // 
            // cmb_IdPublicacion
            // 
            this.cmb_IdPublicacion.FormattingEnabled = true;
            this.cmb_IdPublicacion.Location = new System.Drawing.Point(208, 364);
            this.cmb_IdPublicacion.Name = "cmb_IdPublicacion";
            this.cmb_IdPublicacion.Size = new System.Drawing.Size(297, 28);
            this.cmb_IdPublicacion.TabIndex = 49;
            // 
            // cmb_IdTrabajo
            // 
            this.cmb_IdTrabajo.FormattingEnabled = true;
            this.cmb_IdTrabajo.Location = new System.Drawing.Point(207, 273);
            this.cmb_IdTrabajo.Name = "cmb_IdTrabajo";
            this.cmb_IdTrabajo.Size = new System.Drawing.Size(297, 28);
            this.cmb_IdTrabajo.TabIndex = 50;
            // 
            // frm_empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 614);
            this.Controls.Add(this.cmb_IdTrabajo);
            this.Controls.Add(this.cmb_IdPublicacion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtp_FechaContratacion);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.lbl_Lista);
            this.Controls.Add(this.lst_Empleados);
            this.Controls.Add(this.lbl_Titulo);
            this.Controls.Add(this.btn_Insertar);
            this.Controls.Add(this.btn_Limpiar);
            this.Controls.Add(this.txt_NivelTrabajo);
            this.Controls.Add(this.txt_Apellido);
            this.Controls.Add(this.txt_InicialN);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.txt_IDempleado);
            this.Controls.Add(this.lbl_FechaContratacion);
            this.Controls.Add(this.lbl_IDpublicacion);
            this.Controls.Add(this.lbl_NivelTrabajo);
            this.Controls.Add(this.lbl_IDtrabajo);
            this.Controls.Add(this.lbl_Apellido);
            this.Controls.Add(this.lbl_InicialN);
            this.Controls.Add(this.lbl_Nombre);
            this.Controls.Add(this.lbl_IDempleado);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_empleados";
            this.Text = "Empleados";
            this.Load += new System.EventHandler(this.frm_empleados_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Label lbl_Lista;
        private System.Windows.Forms.ListBox lst_Empleados;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.Button btn_Insertar;
        private System.Windows.Forms.Button btn_Limpiar;
        private System.Windows.Forms.TextBox txt_NivelTrabajo;
        private System.Windows.Forms.TextBox txt_Apellido;
        private System.Windows.Forms.TextBox txt_InicialN;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.TextBox txt_IDempleado;
        private System.Windows.Forms.Label lbl_FechaContratacion;
        private System.Windows.Forms.Label lbl_IDpublicacion;
        private System.Windows.Forms.Label lbl_NivelTrabajo;
        private System.Windows.Forms.Label lbl_IDtrabajo;
        private System.Windows.Forms.Label lbl_Apellido;
        private System.Windows.Forms.Label lbl_InicialN;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.Label lbl_IDempleado;
        private System.Windows.Forms.DateTimePicker dtp_FechaContratacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_IdPublicacion;
        private System.Windows.Forms.ComboBox cmb_IdTrabajo;
    }
}