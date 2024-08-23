
namespace _06Publicaciones.Views.Autores
{
    partial class frm_autores
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
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.lbl_Autor = new System.Windows.Forms.Label();
            this.lbl_Apellido = new System.Windows.Forms.Label();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.lbl_Telefono = new System.Windows.Forms.Label();
            this.lbl_Direccion = new System.Windows.Forms.Label();
            this.lbl_Ciudad = new System.Windows.Forms.Label();
            this.lbl_Estado = new System.Windows.Forms.Label();
            this.lbl_CodigoPostal = new System.Windows.Forms.Label();
            this.txt_IdAutor = new System.Windows.Forms.TextBox();
            this.txt_Apellido = new System.Windows.Forms.TextBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.txt_Telefono = new System.Windows.Forms.TextBox();
            this.txt_Direccion = new System.Windows.Forms.TextBox();
            this.txt_Ciudad = new System.Windows.Forms.TextBox();
            this.txt_Estado = new System.Windows.Forms.TextBox();
            this.txt_CodigoPostal = new System.Windows.Forms.TextBox();
            this.btn_Insertar = new System.Windows.Forms.Button();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.lst_Autores = new System.Windows.Forms.ListBox();
            this.lbl_Lista = new System.Windows.Forms.Label();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.Location = new System.Drawing.Point(173, 37);
            this.lbl_Titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(236, 29);
            this.lbl_Titulo.TabIndex = 0;
            this.lbl_Titulo.Text = "Gestión de Autores";
            // 
            // lbl_Autor
            // 
            this.lbl_Autor.AutoSize = true;
            this.lbl_Autor.Location = new System.Drawing.Point(61, 89);
            this.lbl_Autor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Autor.Name = "lbl_Autor";
            this.lbl_Autor.Size = new System.Drawing.Size(73, 20);
            this.lbl_Autor.TabIndex = 0;
            this.lbl_Autor.Text = "ID Autor:";
            // 
            // lbl_Apellido
            // 
            this.lbl_Apellido.AutoSize = true;
            this.lbl_Apellido.Location = new System.Drawing.Point(66, 144);
            this.lbl_Apellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Apellido.Name = "lbl_Apellido";
            this.lbl_Apellido.Size = new System.Drawing.Size(69, 20);
            this.lbl_Apellido.TabIndex = 1;
            this.lbl_Apellido.Text = "Apellido:";
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Location = new System.Drawing.Point(66, 188);
            this.lbl_Nombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(69, 20);
            this.lbl_Nombre.TabIndex = 2;
            this.lbl_Nombre.Text = "Nombre:";
            // 
            // lbl_Telefono
            // 
            this.lbl_Telefono.AutoSize = true;
            this.lbl_Telefono.Location = new System.Drawing.Point(60, 235);
            this.lbl_Telefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Telefono.Name = "lbl_Telefono";
            this.lbl_Telefono.Size = new System.Drawing.Size(75, 20);
            this.lbl_Telefono.TabIndex = 3;
            this.lbl_Telefono.Text = "Teléfono:";
            // 
            // lbl_Direccion
            // 
            this.lbl_Direccion.AutoSize = true;
            this.lbl_Direccion.Location = new System.Drawing.Point(56, 285);
            this.lbl_Direccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Direccion.Name = "lbl_Direccion";
            this.lbl_Direccion.Size = new System.Drawing.Size(79, 20);
            this.lbl_Direccion.TabIndex = 4;
            this.lbl_Direccion.Text = "Dirección:";
            // 
            // lbl_Ciudad
            // 
            this.lbl_Ciudad.AutoSize = true;
            this.lbl_Ciudad.Location = new System.Drawing.Point(71, 329);
            this.lbl_Ciudad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Ciudad.Name = "lbl_Ciudad";
            this.lbl_Ciudad.Size = new System.Drawing.Size(63, 20);
            this.lbl_Ciudad.TabIndex = 5;
            this.lbl_Ciudad.Text = "Ciudad:";
            // 
            // lbl_Estado
            // 
            this.lbl_Estado.AutoSize = true;
            this.lbl_Estado.Location = new System.Drawing.Point(71, 376);
            this.lbl_Estado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Estado.Name = "lbl_Estado";
            this.lbl_Estado.Size = new System.Drawing.Size(64, 20);
            this.lbl_Estado.TabIndex = 6;
            this.lbl_Estado.Text = "Estado:";
            // 
            // lbl_CodigoPostal
            // 
            this.lbl_CodigoPostal.AutoSize = true;
            this.lbl_CodigoPostal.Location = new System.Drawing.Point(24, 424);
            this.lbl_CodigoPostal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_CodigoPostal.Name = "lbl_CodigoPostal";
            this.lbl_CodigoPostal.Size = new System.Drawing.Size(111, 20);
            this.lbl_CodigoPostal.TabIndex = 7;
            this.lbl_CodigoPostal.Text = "Código Postal:";
            // 
            // txt_IdAutor
            // 
            this.txt_IdAutor.Location = new System.Drawing.Point(143, 86);
            this.txt_IdAutor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_IdAutor.Name = "txt_IdAutor";
            this.txt_IdAutor.Size = new System.Drawing.Size(298, 26);
            this.txt_IdAutor.TabIndex = 8;
            // 
            // txt_Apellido
            // 
            this.txt_Apellido.Location = new System.Drawing.Point(143, 144);
            this.txt_Apellido.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Apellido.Name = "txt_Apellido";
            this.txt_Apellido.Size = new System.Drawing.Size(298, 26);
            this.txt_Apellido.TabIndex = 9;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(143, 188);
            this.txt_Nombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(298, 26);
            this.txt_Nombre.TabIndex = 10;
            // 
            // txt_Telefono
            // 
            this.txt_Telefono.Location = new System.Drawing.Point(144, 235);
            this.txt_Telefono.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Telefono.Name = "txt_Telefono";
            this.txt_Telefono.Size = new System.Drawing.Size(298, 26);
            this.txt_Telefono.TabIndex = 11;
            // 
            // txt_Direccion
            // 
            this.txt_Direccion.Location = new System.Drawing.Point(143, 285);
            this.txt_Direccion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Direccion.Name = "txt_Direccion";
            this.txt_Direccion.Size = new System.Drawing.Size(298, 26);
            this.txt_Direccion.TabIndex = 12;
            // 
            // txt_Ciudad
            // 
            this.txt_Ciudad.Location = new System.Drawing.Point(143, 329);
            this.txt_Ciudad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Ciudad.Name = "txt_Ciudad";
            this.txt_Ciudad.Size = new System.Drawing.Size(298, 26);
            this.txt_Ciudad.TabIndex = 13;
            // 
            // txt_Estado
            // 
            this.txt_Estado.Location = new System.Drawing.Point(143, 376);
            this.txt_Estado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Estado.Name = "txt_Estado";
            this.txt_Estado.Size = new System.Drawing.Size(298, 26);
            this.txt_Estado.TabIndex = 14;
            // 
            // txt_CodigoPostal
            // 
            this.txt_CodigoPostal.Location = new System.Drawing.Point(143, 424);
            this.txt_CodigoPostal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_CodigoPostal.Name = "txt_CodigoPostal";
            this.txt_CodigoPostal.Size = new System.Drawing.Size(298, 26);
            this.txt_CodigoPostal.TabIndex = 15;
            // 
            // btn_Insertar
            // 
            this.btn_Insertar.Location = new System.Drawing.Point(169, 472);
            this.btn_Insertar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Insertar.Name = "btn_Insertar";
            this.btn_Insertar.Size = new System.Drawing.Size(112, 36);
            this.btn_Insertar.TabIndex = 16;
            this.btn_Insertar.Text = "Grabar";
            this.btn_Insertar.UseVisualStyleBackColor = true;
            this.btn_Insertar.Click += new System.EventHandler(this.btn_Insertar_Click);
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.Location = new System.Drawing.Point(289, 472);
            this.btn_Limpiar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(112, 36);
            this.btn_Limpiar.TabIndex = 17;
            this.btn_Limpiar.Text = "Limpiar";
            this.btn_Limpiar.UseVisualStyleBackColor = true;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            // 
            // lst_Autores
            // 
            this.lst_Autores.FormattingEnabled = true;
            this.lst_Autores.ItemHeight = 20;
            this.lst_Autores.Location = new System.Drawing.Point(485, 86);
            this.lst_Autores.Name = "lst_Autores";
            this.lst_Autores.Size = new System.Drawing.Size(348, 344);
            this.lst_Autores.TabIndex = 18;
            this.lst_Autores.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // lbl_Lista
            // 
            this.lbl_Lista.AutoSize = true;
            this.lbl_Lista.Location = new System.Drawing.Point(481, 52);
            this.lbl_Lista.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Lista.Name = "lbl_Lista";
            this.lbl_Lista.Size = new System.Drawing.Size(125, 20);
            this.lbl_Lista.TabIndex = 19;
            this.lbl_Lista.Text = "Lista de Autores";
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Location = new System.Drawing.Point(169, 518);
            this.btn_Modificar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(112, 36);
            this.btn_Modificar.TabIndex = 20;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(289, 518);
            this.btn_Eliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(112, 36);
            this.btn_Eliminar.TabIndex = 21;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(331, 117);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Formato: 000-00-0000";
            // 
            // frm_autores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 573);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.lbl_Lista);
            this.Controls.Add(this.lst_Autores);
            this.Controls.Add(this.lbl_Titulo);
            this.Controls.Add(this.btn_Insertar);
            this.Controls.Add(this.btn_Limpiar);
            this.Controls.Add(this.txt_CodigoPostal);
            this.Controls.Add(this.txt_Estado);
            this.Controls.Add(this.txt_Ciudad);
            this.Controls.Add(this.txt_Direccion);
            this.Controls.Add(this.txt_Telefono);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.txt_Apellido);
            this.Controls.Add(this.txt_IdAutor);
            this.Controls.Add(this.lbl_CodigoPostal);
            this.Controls.Add(this.lbl_Estado);
            this.Controls.Add(this.lbl_Ciudad);
            this.Controls.Add(this.lbl_Direccion);
            this.Controls.Add(this.lbl_Telefono);
            this.Controls.Add(this.lbl_Nombre);
            this.Controls.Add(this.lbl_Apellido);
            this.Controls.Add(this.lbl_Autor);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_autores";
            this.Text = "Autores";
            this.Load += new System.EventHandler(this.frm_Autores_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Titulo;
       
        private System.Windows.Forms.Label lbl_Autor;
        private System.Windows.Forms.Label lbl_Apellido;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.Label lbl_Telefono;
        private System.Windows.Forms.Label lbl_Direccion;
        private System.Windows.Forms.Label lbl_Ciudad;
        private System.Windows.Forms.Label lbl_Estado;
        private System.Windows.Forms.Label lbl_CodigoPostal;
        private System.Windows.Forms.TextBox txt_IdAutor;
        private System.Windows.Forms.TextBox txt_Apellido;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.TextBox txt_Telefono;
        private System.Windows.Forms.TextBox txt_Direccion;
        private System.Windows.Forms.TextBox txt_Ciudad;
        private System.Windows.Forms.TextBox txt_Estado;
        private System.Windows.Forms.TextBox txt_CodigoPostal;
        private System.Windows.Forms.Button btn_Insertar;
        private System.Windows.Forms.Button btn_Limpiar;
        private System.Windows.Forms.ListBox lst_Autores;
        private System.Windows.Forms.Label lbl_Lista;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Label label1;
    }
}