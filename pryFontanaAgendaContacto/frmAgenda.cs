namespace pryFontanaAgendaContacto
{
    public partial class frmAgenda : Form
    {
        string[] contactos = new string[5];
        string[] telefonos = new string[5];

        int indice = 0;

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
            if (indice >= 5)
            {
                indice = 0;
            }

            contactos[indice] = txtContacto.Text;
            telefonos[indice] = mtxtNumero.Text;

            //lstDatos.Items.Add(txtContacto.Text + " | " + mtxtNumero.Text);
            Contactos += 1;
            indice++;

            lblNumContactos.Text = Convert.ToString(Contactos);
            txtContacto.Text = "";
            mtxtNumero.Text = "";
            btnCargar.Enabled = false;
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
            if (mtxtNumero.MaskFull)
            {
                btnCargar.Enabled = true;
            }
            else
            {
                btnCargar.Enabled = false;

            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            indice = 0;
            while (indice < 5)
            {
                if (contactos[indice] != null)
                {
                    lstDatos.Items.Add(contactos[indice] + " | " + telefonos[indice]);
                }
                indice++;

            }

            for (int indice = 0; indice < 5; indice++)
            {
                contactos[indice] = null;
                telefonos[indice] = null;
            }
        }
    }
}
