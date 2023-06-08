namespace FrmView
{
    partial class FrmView
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
            lblHora = new Label();
            txtIngreso = new TextBox();
            btnIniciar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.Font = new Font("Segoe UI", 40F, FontStyle.Bold, GraphicsUnit.Point);
            lblHora.Location = new Point(12, 24);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(169, 72);
            lblHora.TabIndex = 0;
            lblHora.Text = "Hora:";
            // 
            // txtIngreso
            // 
            txtIngreso.Location = new Point(12, 206);
            txtIngreso.Name = "txtIngreso";
            txtIngreso.Size = new Size(252, 23);
            txtIngreso.TabIndex = 1;
            // 
            // btnIniciar
            // 
            btnIniciar.Location = new Point(12, 249);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(226, 62);
            btnIniciar.TabIndex = 2;
            btnIniciar.Text = "Iniciar";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(244, 249);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(226, 62);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FrmView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(543, 343);
            Controls.Add(btnCancelar);
            Controls.Add(btnIniciar);
            Controls.Add(txtIngreso);
            Controls.Add(lblHora);
            Name = "FrmView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tasks";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHora;
        private TextBox txtIngreso;
        private Button btnIniciar;
        private Button btnCancelar;
    }
}