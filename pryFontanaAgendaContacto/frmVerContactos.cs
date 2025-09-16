using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryFontanaAgendaContacto
{
    public partial class frmVerContactos : Form
    {

        int indice = 0;
        int indiceMostrar = 0;
        private string[] vContactos;
        private string[] vTelefonos;

        public frmVerContactos(string[] contactos, string[] telefonos)
        {
            InitializeComponent();
            // Asigna el array recibido a la variable de la clase
            this.vContactos = contactos;
            this.vTelefonos = contactos;
        }

        private void frmVerContactos_Load(object sender, EventArgs e)
        {

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            indice = 0;
            while (indice < 5)
            {
                if (vContactos[indice] != null)
                {
                    //lstDatos.Items.Add(contactos[indice] + " | " + telefonos[indice]);
                }
                indice++;

            }

            for (int indice = 0; indice < 5; indice++)
            {
                vContactos[indice] = null;
                vTelefonos[indice] = null;
            }
        }


        private void btnAnterior_Click_1(object sender, EventArgs e)
        {
            if (indiceMostrar > 0)
            {
                indiceMostrar--;
                lblNombreContacto.Text = vContactos[indiceMostrar];
                lblNumeroContacto.Text = vTelefonos[indiceMostrar];

            }
            else
            {
                indiceMostrar = vContactos.Length - 1;
                while (vContactos[indiceMostrar] == null)
                {
                    indiceMostrar--;
                }
                { }

                lblNombreContacto.Text = vContactos[indiceMostrar];
                lblNumeroContacto.Text = vTelefonos[indiceMostrar];
            }
        }

        private void btnSiguiente_Click_1(object sender, EventArgs e)
        {
            if (indiceMostrar < vContactos.Length - 1)
            {
                indiceMostrar++;

                // Si da null vuelve al principio ya que no puede haber datos
                if (vContactos[indiceMostrar] == null)
                {
                    indiceMostrar = 0;
                }
                lblNombreContacto.Text = vContactos[indiceMostrar];
                lblNumeroContacto.Text = vTelefonos[indiceMostrar];
            }
            else
            {
                indiceMostrar = 0;
                lblNombreContacto.Text = vContactos[indiceMostrar];
                lblNumeroContacto.Text = vTelefonos[indiceMostrar];
            }
            }
    }
}
