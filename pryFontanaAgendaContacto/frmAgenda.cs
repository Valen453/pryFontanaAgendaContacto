namespace pryFontanaAgendaContacto
{
    public partial class frmAgenda : Form
    {

        int Contactos = 0;
        public frmAgenda()
        {
            InitializeComponent();
        }

        private void txtContacto_TextChanged(object sender, EventArgs e)
        {
            if (txtContacto.Text != "")
            {
                mtxtNumero.Enabled = true;
            }
            else
            {
                mtxtNumero.Enabled = false;
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            lstDatos.Items.Add(txtContacto.Text + " | " + mtxtNumero.Text);
            Contactos += 1;
            lblNumContactos.Text = Convert.ToString(Contactos);
        }

        private void mtxtNumero_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mtxtNumero_MaskChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtContacto.Text = "";
            mtxtNumero.Text = "";
            btnCargar.Enabled = false;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lstDatos.Items.Clear();
            Contactos = 0;
            lblNumContactos.Text = "0";
        }

        private void frmAgenda_Load(object sender, EventArgs e)
        {
            txtContacto.Focus();
        }

        private void mtxtNumero_TextChanged(object sender, EventArgs e)
        {
            if (mtxtNumero.Text != "")
            {
                btnCargar.Enabled = true;
            }
            else
            {
                btnCargar.Enabled = false;
            }
        }
    }
}
