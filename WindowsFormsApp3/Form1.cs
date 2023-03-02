using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // El pepe
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string elemento = txtNombre.Text;
            lvElemento.Items.Add(elemento);
            txtNombre.Text = "";
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboColor.Items.Add("Amarillo");
            cboColor.Items.Add("Azul");
            cboColor.Items.Add("Morado");


        }


        Persona p1 = new Persona();

        private void btnVer_Click(object sender, EventArgs e)
        {
            p1.Name = txtNombre.Text;
            p1.DateBirth = fechaNacimiento.Value;
            p1.Chocolate = chkBox.Checked == true ? "Sí le gusta el chocolate" : "No le gusta el chocolate";
            if ( rbtWizard.Checked )
            {
                p1.Tipo = "Wizard";
            } else if ( rbtMuggle.Checked )
            {
                p1.Tipo = "Muggle";
            } else
            {
                p1.Tipo = "Squibs";
            }
            p1.Color = cboColor.SelectedItem.ToString();
            p1.Numero = numbFavorito.Value.ToString();

            MessageBox.Show("Nombre: " + p1.Name + " Fecha de nacimiento: " + p1.DateBirth + " " + p1.Chocolate + " Tipo: " + p1.Tipo + " Color Favorito: " + p1.Color + " Número Favorito: " + p1.Numero);
        }

        private void saludar_Click(object sender, EventArgs e)
        {
            p1.saludar(txtNombre.Text);
        }
    }
}
