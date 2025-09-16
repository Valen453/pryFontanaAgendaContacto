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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgenda));
            grbContacto = new GroupBox();
            btnCancelar = new Button();
            mtxtNumero = new MaskedTextBox();
            btnCargar = new Button();
            txtContacto = new TextBox();
            lblNumero = new Label();
            lblContacto = new Label();
            lblAgendaContacto = new Label();
            btnLimpiar = new Button();
            lblNumContactos = new Label();
            lblContactos = new Label();
            btnVer = new Button();
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
            grbContacto.Location = new Point(17, 74);
            grbContacto.Name = "grbContacto";
            grbContacto.Size = new Size(267, 180);
            grbContacto.TabIndex = 3;
            grbContacto.TabStop = false;
            grbContacto.Text = "Gestión";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(54, 125);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 0;
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
            mtxtNumero.TextChanged += mtxtNumero_TextChanged;
            // 
            // btnCargar
            // 
            btnCargar.Enabled = false;
            btnCargar.Location = new Point(135, 125);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(75, 23);
            btnCargar.TabIndex = 1;
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
            lblAgendaContacto.Location = new Point(38, 15);
            lblAgendaContacto.Name = "lblAgendaContacto";
            lblAgendaContacto.Size = new Size(224, 37);
            lblAgendaContacto.TabIndex = 0;
            lblAgendaContacto.Text = "Agenda Contacto";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(174, 410);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(88, 30);
            btnLimpiar.TabIndex = 3;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // lblNumContactos
            // 
            lblNumContactos.AutoSize = true;
            lblNumContactos.Location = new Point(148, 418);
            lblNumContactos.Name = "lblNumContactos";
            lblNumContactos.Size = new Size(13, 15);
            lblNumContactos.TabIndex = 5;
            lblNumContactos.Text = "0";
            lblNumContactos.Click += lblNumContactos_Click;
            // 
            // lblContactos
            // 
            lblContactos.AutoSize = true;
            lblContactos.Location = new Point(12, 418);
            lblContactos.Name = "lblContactos";
            lblContactos.Size = new Size(129, 15);
            lblContactos.TabIndex = 4;
            lblContactos.Text = "Cantidad de contactos:";
            // 
            // btnVer
            // 
            btnVer.Enabled = false;
            btnVer.Location = new Point(148, 334);
            btnVer.Name = "btnVer";
            btnVer.Size = new Size(89, 33);
            btnVer.TabIndex = 6;
            btnVer.Text = "Ver Contactos";
            btnVer.UseVisualStyleBackColor = true;
            btnVer.Click += btnVer_Click_1;
            // 
            // frmAgenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(306, 461);
            Controls.Add(btnVer);
            Controls.Add(lblNumContactos);
            Controls.Add(lblContactos);
            Controls.Add(btnLimpiar);
            Controls.Add(lblAgendaContacto);
            Controls.Add(grbContacto);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(500, 500);
            Name = "frmAgenda";
            StartPosition = FormStartPosition.CenterScreen;
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
        private Button btnLimpiar;
        private Label lblNumContactos;
        private Label lblContactos;
        private Button btnVer;
    }
}
