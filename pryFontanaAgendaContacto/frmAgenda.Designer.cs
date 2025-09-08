namespace pryFontanaAgendaContacto
{
    partial class frmAgenda
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
            grbContacto = new GroupBox();
            btnCancelar = new Button();
            mtxtNumero = new MaskedTextBox();
            btnCargar = new Button();
            txtContacto = new TextBox();
            lblNumero = new Label();
            lblContacto = new Label();
            lblAgendaContacto = new Label();
            lstDatos = new ListBox();
            btnLimpiar = new Button();
            grbContacto.SuspendLayout();
            SuspendLayout();
            // 
            // grbContacto
            // 
            grbContacto.Controls.Add(btnCancelar);
            grbContacto.Controls.Add(mtxtNumero);
            grbContacto.Controls.Add(btnCargar);
            grbContacto.Controls.Add(txtContacto);
            grbContacto.Controls.Add(lblNumero);
            grbContacto.Controls.Add(lblContacto);
            grbContacto.Location = new Point(100, 83);
            grbContacto.Name = "grbContacto";
            grbContacto.Size = new Size(267, 180);
            grbContacto.TabIndex = 3;
            grbContacto.TabStop = false;
            grbContacto.Text = "Gestión";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(156, 120);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // mtxtNumero
            // 
            mtxtNumero.Enabled = false;
            mtxtNumero.Location = new Point(131, 73);
            mtxtNumero.Mask = "(999)000-0000";
            mtxtNumero.Name = "mtxtNumero";
            mtxtNumero.Size = new Size(100, 23);
            mtxtNumero.TabIndex = 1;
            mtxtNumero.MaskChanged += mtxtNumero_MaskChanged;
            mtxtNumero.MaskInputRejected += mtxtNumero_MaskInputRejected;
            mtxtNumero.KeyDown += mtxtNumero_KeyDown;
            // 
            // btnCargar
            // 
            btnCargar.Enabled = false;
            btnCargar.Location = new Point(21, 120);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(75, 23);
            btnCargar.TabIndex = 2;
            btnCargar.Text = "Cargar";
            btnCargar.UseVisualStyleBackColor = true;
            btnCargar.Click += btnCargar_Click;
            // 
            // txtContacto
            // 
            txtContacto.Location = new Point(131, 33);
            txtContacto.MaxLength = 47;
            txtContacto.Name = "txtContacto";
            txtContacto.Size = new Size(100, 23);
            txtContacto.TabIndex = 0;
            txtContacto.TextChanged += txtContacto_TextChanged;
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(21, 81);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(51, 15);
            lblNumero.TabIndex = 1;
            lblNumero.Text = "Numero";
            // 
            // lblContacto
            // 
            lblContacto.AutoSize = true;
            lblContacto.Location = new Point(21, 36);
            lblContacto.Name = "lblContacto";
            lblContacto.Size = new Size(56, 15);
            lblContacto.TabIndex = 0;
            lblContacto.Text = "Contacto";
            // 
            // lblAgendaContacto
            // 
            lblAgendaContacto.AutoSize = true;
            lblAgendaContacto.Font = new Font("Segoe UI", 20F);
            lblAgendaContacto.Location = new Point(121, 24);
            lblAgendaContacto.Name = "lblAgendaContacto";
            lblAgendaContacto.Size = new Size(224, 37);
            lblAgendaContacto.TabIndex = 0;
            lblAgendaContacto.Text = "Agenda Contacto";
            // 
            // lstDatos
            // 
            lstDatos.FormattingEnabled = true;
            lstDatos.ItemHeight = 15;
            lstDatos.Location = new Point(100, 284);
            lstDatos.Name = "lstDatos";
            lstDatos.Size = new Size(267, 94);
            lstDatos.TabIndex = 2;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(279, 397);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(88, 30);
            btnLimpiar.TabIndex = 3;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // frmAgenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 461);
            Controls.Add(btnLimpiar);
            Controls.Add(lstDatos);
            Controls.Add(lblAgendaContacto);
            Controls.Add(grbContacto);
            MaximumSize = new Size(500, 500);
            Name = "frmAgenda";
            Text = "Agenda de Contactos";
            Load += frmAgenda_Load;
            grbContacto.ResumeLayout(false);
            grbContacto.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grbContacto;
        private TextBox txtContacto;
        private Label lblNumero;
        private Label lblContacto;
        private Label lblAgendaContacto;
        private MaskedTextBox mtxtNumero;
        private Button btnCancelar;
        private Button btnCargar;
        private ListBox lstDatos;
        private Button btnLimpiar;
    }
}
