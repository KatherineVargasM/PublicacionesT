
namespace _06Publicaciones.Views.Trabajos
{
    partial class frm_trabajo
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
            this.lst_Trabajos = new System.Windows.Forms.ListBox();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.btn_Insertar = new System.Windows.Forms.Button();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.txt_NivelMaximo = new System.Windows.Forms.TextBox();
            this.txt_NivelMinimo = new System.Windows.Forms.TextBox();
            this.txt_Descripcion = new System.Windows.Forms.TextBox();
            this.lbl_NivelMaximo = new System.Windows.Forms.Label();
            this.lbl_NivelMinimo = new System.Windows.Forms.Label();
            this.lbl_Descripcion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(355, 290);
            this.btn_Eliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(112, 36);
            this.btn_Eliminar.TabIndex = 70;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Location = new System.Drawing.Point(235, 290);
            this.btn_Modificar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(112, 36);
            this.btn_Modificar.TabIndex = 69;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // lbl_Lista
            // 
            this.lbl_Lista.AutoSize = true;
            this.lbl_Lista.Location = new System.Drawing.Point(515, 71);
            this.lbl_Lista.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Lista.Name = "lbl_Lista";
            this.lbl_Lista.Size = new System.Drawing.Size(134, 20);
            this.lbl_Lista.TabIndex = 68;
            this.lbl_Lista.Text = "Lista de Trabajos:";
            // 
            // lst_Trabajos
            // 
            this.lst_Trabajos.FormattingEnabled = true;
            this.lst_Trabajos.ItemHeight = 20;
            this.lst_Trabajos.Location = new System.Drawing.Point(519, 94);
            this.lst_Trabajos.Name = "lst_Trabajos";
            this.lst_Trabajos.Size = new System.Drawing.Size(318, 124);
            this.lst_Trabajos.TabIndex = 67;
            this.lst_Trabajos.DoubleClick += new System.EventHandler(this.lst_Trabajos_DoubleClick);
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.Location = new System.Drawing.Point(227, 46);
            this.lbl_Titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(251, 29);
            this.lbl_Titulo.TabIndex = 50;
            this.lbl_Titulo.Text = "Gestión de Trabajos";
            // 
            // btn_Insertar
            // 
            this.btn_Insertar.Location = new System.Drawing.Point(235, 244);
            this.btn_Insertar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Insertar.Name = "btn_Insertar";
            this.btn_Insertar.Size = new System.Drawing.Size(112, 36);
            this.btn_Insertar.TabIndex = 65;
            this.btn_Insertar.Text = "Grabar";
            this.btn_Insertar.UseVisualStyleBackColor = true;
            this.btn_Insertar.Click += new System.EventHandler(this.btn_Insertar_Click);
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.Location = new System.Drawing.Point(355, 244);
            this.btn_Limpiar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(112, 36);
            this.btn_Limpiar.TabIndex = 66;
            this.btn_Limpiar.Text = "Limpiar";
            this.btn_Limpiar.UseVisualStyleBackColor = true;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            // 
            // txt_NivelMaximo
            // 
            this.txt_NivelMaximo.Location = new System.Drawing.Point(205, 193);
            this.txt_NivelMaximo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_NivelMaximo.Name = "txt_NivelMaximo";
            this.txt_NivelMaximo.Size = new System.Drawing.Size(298, 26);
            this.txt_NivelMaximo.TabIndex = 61;
            // 
            // txt_NivelMinimo
            // 
            this.txt_NivelMinimo.Location = new System.Drawing.Point(204, 144);
            this.txt_NivelMinimo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_NivelMinimo.Name = "txt_NivelMinimo";
            this.txt_NivelMinimo.Size = new System.Drawing.Size(298, 26);
            this.txt_NivelMinimo.TabIndex = 60;
            // 
            // txt_Descripcion
            // 
            this.txt_Descripcion.Location = new System.Drawing.Point(204, 97);
            this.txt_Descripcion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Descripcion.Name = "txt_Descripcion";
            this.txt_Descripcion.Size = new System.Drawing.Size(298, 26);
            this.txt_Descripcion.TabIndex = 59;
            // 
            // lbl_NivelMaximo
            // 
            this.lbl_NivelMaximo.AutoSize = true;
            this.lbl_NivelMaximo.Location = new System.Drawing.Point(35, 193);
            this.lbl_NivelMaximo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_NivelMaximo.Name = "lbl_NivelMaximo";
            this.lbl_NivelMaximo.Size = new System.Drawing.Size(161, 20);
            this.lbl_NivelMaximo.TabIndex = 53;
            this.lbl_NivelMaximo.Text = "Nivel Maximo Trabajo:";
            // 
            // lbl_NivelMinimo
            // 
            this.lbl_NivelMinimo.AutoSize = true;
            this.lbl_NivelMinimo.Location = new System.Drawing.Point(39, 144);
            this.lbl_NivelMinimo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_NivelMinimo.Name = "lbl_NivelMinimo";
            this.lbl_NivelMinimo.Size = new System.Drawing.Size(157, 20);
            this.lbl_NivelMinimo.TabIndex = 52;
            this.lbl_NivelMinimo.Text = "Nivel Minimo Trabajo:";
            // 
            // lbl_Descripcion
            // 
            this.lbl_Descripcion.AutoSize = true;
            this.lbl_Descripcion.Location = new System.Drawing.Point(43, 97);
            this.lbl_Descripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Descripcion.Name = "lbl_Descripcion";
            this.lbl_Descripcion.Size = new System.Drawing.Size(153, 20);
            this.lbl_Descripcion.TabIndex = 51;
            this.lbl_Descripcion.Text = "Descripción Trabajo:";
            // 
            // frm_trabajo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 361);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.lbl_Lista);
            this.Controls.Add(this.lst_Trabajos);
            this.Controls.Add(this.lbl_Titulo);
            this.Controls.Add(this.btn_Insertar);
            this.Controls.Add(this.btn_Limpiar);
            this.Controls.Add(this.txt_NivelMaximo);
            this.Controls.Add(this.txt_NivelMinimo);
            this.Controls.Add(this.txt_Descripcion);
            this.Controls.Add(this.lbl_NivelMaximo);
            this.Controls.Add(this.lbl_NivelMinimo);
            this.Controls.Add(this.lbl_Descripcion);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_trabajo";
            this.Text = "Trabajos";
            this.Load += new System.EventHandler(this.frm_trabajo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Label lbl_Lista;
        private System.Windows.Forms.ListBox lst_Trabajos;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.Button btn_Insertar;
        private System.Windows.Forms.Button btn_Limpiar;
        private System.Windows.Forms.TextBox txt_NivelMaximo;
        private System.Windows.Forms.TextBox txt_NivelMinimo;
        private System.Windows.Forms.TextBox txt_Descripcion;
        private System.Windows.Forms.Label lbl_NivelMaximo;
        private System.Windows.Forms.Label lbl_NivelMinimo;
        private System.Windows.Forms.Label lbl_Descripcion;
    }
}