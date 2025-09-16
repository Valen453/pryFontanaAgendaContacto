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
            lblDatosDeContacto = new Label();
            lblContactos = new Label();
            lblNumContactos = new Label();
            lblNombreContacto = new Label();
            lblNumeroContacto = new Label();
            btnAnterior = new Button();
            btnSiguiente = new Button();
            SuspendLayout();
            // 
            // lblDatosDeContacto
            // 
            lblDatosDeContacto.AutoSize = true;
            lblDatosDeContacto.Location = new Point(82, 23);
            lblDatosDeContacto.Name = "lblDatosDeContacto";
            lblDatosDeContacto.Size = new Size(105, 15);
            lblDatosDeContacto.TabIndex = 16;
            lblDatosDeContacto.Text = "Datos de Contacto";
            // 
            // lblContactos
            // 
            lblContactos.AutoSize = true;
            lblContactos.Location = new Point(58, 170);
            lblContactos.Name = "lblContactos";
            lblContactos.Size = new Size(129, 15);
            lblContactos.TabIndex = 12;
            lblContactos.Text = "Cantidad de contactos:";
            // 
            // lblNumContactos
            // 
            lblNumContactos.AutoSize = true;
            lblNumContactos.Location = new Point(194, 170);
            lblNumContactos.Name = "lblNumContactos";
            lblNumContactos.Size = new Size(13, 15);
            lblNumContactos.TabIndex = 13;
            lblNumContactos.Text = "0";
            // 
            // lblNombreContacto
            // 
            lblNombreContacto.AutoSize = true;
            lblNombreContacto.Location = new Point(119, 48);
            lblNombreContacto.Name = "lblNombreContacto";
            lblNombreContacto.Size = new Size(12, 15);
            lblNombreContacto.TabIndex = 14;
            lblNombreContacto.Text = "-";
            // 
            // lblNumeroContacto
            // 
            lblNumeroContacto.AutoSize = true;
            lblNumeroContacto.Location = new Point(119, 82);
            lblNumeroContacto.Name = "lblNumeroContacto";
            lblNumeroContacto.Size = new Size(12, 15);
            lblNumeroContacto.TabIndex = 15;
            lblNumeroContacto.Text = "-";
            // 
            // btnAnterior
            // 
            btnAnterior.Location = new Point(27, 124);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(75, 23);
            btnAnterior.TabIndex = 18;
            btnAnterior.Text = "<";
            btnAnterior.UseVisualStyleBackColor = true;
            btnAnterior.Click += btnAnterior_Click_1;
            // 
            // btnSiguiente
            // 
            btnSiguiente.Location = new Point(142, 124);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(75, 23);
            btnSiguiente.TabIndex = 17;
            btnSiguiente.Text = ">";
            btnSiguiente.UseVisualStyleBackColor = true;
            btnSiguiente.Click += btnSiguiente_Click_1;
            // 
            // frmVerContactos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(254, 233);
            Controls.Add(btnAnterior);
            Controls.Add(btnSiguiente);
            Controls.Add(lblDatosDeContacto);
            Controls.Add(lblNumeroContacto);
            Controls.Add(lblNombreContacto);
            Controls.Add(lblNumContactos);
            Controls.Add(lblContactos);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmVerContactos";
            Text = "Contactos";
            Load += frmVerContactos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDatosDeContacto;
        private Label lblContactos;
        private Label lblNumContactos;
        private Label lblNombreContacto;
        private Label lblNumeroContacto;
        private Button btnAnterior;
        private Button btnSiguiente;
    }
}