namespace Clase05
{
    partial class FrmClase05
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAceptar = new Button();
            txtNombre = new TextBox();
            lblNombre = new Label();
            lblApellido = new Label();
            txtApellido = new TextBox();
            grpDatos = new GroupBox();
            lstNombres = new ListBox();
            grpDatos.SuspendLayout();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(31, 35);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(226, 70);
            btnAceptar.TabIndex = 0;
            btnAceptar.Text = "Abrir Segundo Form";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(6, 52);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Nombre:";
            txtNombre.Size = new Size(157, 23);
            txtNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(6, 34);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(178, 34);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(54, 15);
            lblApellido.TabIndex = 4;
            lblApellido.Text = "Apellido:";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(178, 52);
            txtApellido.Name = "txtApellido";
            txtApellido.PlaceholderText = "Apellido:";
            txtApellido.Size = new Size(157, 23);
            txtApellido.TabIndex = 3;
            // 
            // grpDatos
            // 
            grpDatos.Controls.Add(lblNombre);
            grpDatos.Controls.Add(lblApellido);
            grpDatos.Controls.Add(txtNombre);
            grpDatos.Controls.Add(txtApellido);
            grpDatos.Location = new Point(12, 219);
            grpDatos.Name = "grpDatos";
            grpDatos.Size = new Size(525, 176);
            grpDatos.TabIndex = 5;
            grpDatos.TabStop = false;
            grpDatos.Text = "Datos";
            // 
            // lstNombres
            // 
            lstNombres.FormattingEnabled = true;
            lstNombres.ItemHeight = 15;
            lstNombres.Location = new Point(609, 64);
            lstNombres.Name = "lstNombres";
            lstNombres.Size = new Size(157, 319);
            lstNombres.TabIndex = 6;
            // 
            // FrmClase05
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstNombres);
            Controls.Add(grpDatos);
            Controls.Add(btnAceptar);
            Name = "FrmClase05";
            Text = "Formulario Clase 05";
            FormClosing += FrmClase05_FormClosing;
            grpDatos.ResumeLayout(false);
            grpDatos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnAceptar;
        private TextBox txtNombre;
        private Label lblNombre;
        private Label lblApellido;
        private TextBox txtApellido;
        private GroupBox grpDatos;
        private ListBox lstNombres;
    }
}