namespace pryFontanaAgendaContacto
{
    partial class frmVerContactos
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
            btnAnterior = new Button();
            btnSiguiente = new Button();
            lblDatosDeContacto = new Label();
            lblNumeroContacto = new Label();
            lblNombreContacto = new Label();
            lblNumContactos = new Label();
            lblContactos = new Label();
            btnLimpiar = new Button();
            SuspendLayout();
            // 
            // btnAnterior
            // 
            btnAnterior.Location = new Point(100, 162);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(75, 23);
            btnAnterior.TabIndex = 18;
            btnAnterior.Text = "<";
            btnAnterior.UseVisualStyleBackColor = true;
            btnAnterior.Click += btnAnterior_Click_1;
            // 
            // btnSiguiente
            // 
            btnSiguiente.Location = new Point(249, 162);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(75, 23);
            btnSiguiente.TabIndex = 17;
            btnSiguiente.Text = ">";
            btnSiguiente.UseVisualStyleBackColor = true;
            btnSiguiente.Click += btnSiguiente_Click_1;
            // 
            // lblDatosDeContacto
            // 
            lblDatosDeContacto.AutoSize = true;
            lblDatosDeContacto.Location = new Point(168, 62);
            lblDatosDeContacto.Name = "lblDatosDeContacto";
            lblDatosDeContacto.Size = new Size(105, 15);
            lblDatosDeContacto.TabIndex = 16;
            lblDatosDeContacto.Text = "Datos de Contacto";
            // 
            // lblNumeroContacto
            // 
            lblNumeroContacto.AutoSize = true;
            lblNumeroContacto.Location = new Point(205, 121);
            lblNumeroContacto.Name = "lblNumeroContacto";
            lblNumeroContacto.Size = new Size(12, 15);
            lblNumeroContacto.TabIndex = 15;
            lblNumeroContacto.Text = "-";
            // 
            // lblNombreContacto
            // 
            lblNombreContacto.AutoSize = true;
            lblNombreContacto.Location = new Point(205, 87);
            lblNombreContacto.Name = "lblNombreContacto";
            lblNombreContacto.Size = new Size(12, 15);
            lblNombreContacto.TabIndex = 14;
            lblNombreContacto.Text = "-";
            // 
            // lblNumContactos
            // 
            lblNumContactos.AutoSize = true;
            lblNumContactos.Location = new Point(210, 214);
            lblNumContactos.Name = "lblNumContactos";
            lblNumContactos.Size = new Size(13, 15);
            lblNumContactos.TabIndex = 13;
            lblNumContactos.Text = "0";
            // 
            // lblContactos
            // 
            lblContactos.AutoSize = true;
            lblContactos.Location = new Point(74, 214);
            lblContactos.Name = "lblContactos";
            lblContactos.Size = new Size(129, 15);
            lblContactos.TabIndex = 12;
            lblContactos.Text = "Cantidad de contactos:";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(236, 206);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(88, 30);
            btnLimpiar.TabIndex = 11;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // frmVerContactos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAnterior);
            Controls.Add(btnSiguiente);
            Controls.Add(lblDatosDeContacto);
            Controls.Add(lblNumeroContacto);
            Controls.Add(lblNombreContacto);
            Controls.Add(lblNumContactos);
            Controls.Add(lblContactos);
            Controls.Add(btnLimpiar);
            Name = "frmVerContactos";
            Text = "Form1";
            Load += frmVerContactos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAnterior;
        private Button btnSiguiente;
        private Label lblDatosDeContacto;
        private Label lblNumeroContacto;
        private Label lblNombreContacto;
        private Label lblNumContactos;
        private Label lblContactos;
        private Button btnLimpiar;
    }
}