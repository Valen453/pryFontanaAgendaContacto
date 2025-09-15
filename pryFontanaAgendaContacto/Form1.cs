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

        frmVerContactos vContactos = contacto
        public frmVerContactos()
        {
            InitializeComponent();
            
        }

        private void frmVerContactos_Load(object sender, EventArgs e)
        {

        }
     
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            indice = 0;
            while (indice < 5)
            {
                if (contactos[indice] != null)
                {
                    //lstDatos.Items.Add(contactos[indice] + " | " + telefonos[indice]);
                }
                indice++;

            }

            for (int indice = 0; indice < 5; indice++)
            {
                contactos[indice] = null;
                telefonos[indice] = null;
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {

            if (indiceMostrar > 0)
            {
                indiceMostrar--;
                lblNombreContacto.Text = contactos[indiceMostrar];
                lblNumeroContacto.Text = telefonos[indiceMostrar];

            }
            else
            {
                indiceMostrar = contactos.Length - 1;
                while (contactos[indiceMostrar] == null)
                {
                    indiceMostrar--;
                }
                { }

                lblNombreContacto.Text = contactos[indiceMostrar];
                lblNumeroContacto.Text = telefonos[indiceMostrar];
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (indiceMostrar < contactos.Length - 1)
            {
                indiceMostrar++;

                // Si da null vuelve al principio ya que no puede haber datos
                if (contactos[indiceMostrar] == null)
                {
                    indiceMostrar = 0;
                }
                lblNombreContacto.Text = contactos[indiceMostrar];
                lblNumeroContacto.Text = telefonos[indiceMostrar];
            }
            else
            {
                indiceMostrar = 0;
                lblNombreContacto.Text = contactos[indiceMostrar];
                lblNumeroContacto.Text = telefonos[indiceMostrar];
            }
        }
    }
}
