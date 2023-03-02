using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApp3
{
    internal class Persona
    {
        public string Name { get; set; }
        public DateTime DateBirth { get; set; }
        public string Chocolate { get; set; }
        public string Tipo { get; set; }
        public string Color { get; set; }
        public string Numero { get; set; }
    

        public void saludar( string name)
        {
            MessageBox.Show("Hola " + name);
        }

    }
}
