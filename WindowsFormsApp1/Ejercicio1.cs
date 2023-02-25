using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Ejercicio1 : Form
    {
        public Ejercicio1()
        {
            InitializeComponent();
        }

        private void Calcularbutton_Click(object sender, EventArgs e)
        {
            string fecha_mia = "30/01/2023";
            DateTime fechaNow = new DateTime();
            fechaNow = DateTime.Parse(fecha_mia.ToString());

            for (int i = 0; i < 12; i++)
            {
                listBox1.Items.Add(fechaNow.AddMonths(i) + " = " + "El interés del mes es: " + (200000 * 0.015) * (i + 1));

            }

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Ejercicio1_Load(object sender, EventArgs e)
        {

        }
    }
}
