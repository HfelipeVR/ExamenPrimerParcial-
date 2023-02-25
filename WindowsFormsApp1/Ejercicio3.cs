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
    public partial class Ejercicio3 : Form
    {
        public Ejercicio3()
        {
            InitializeComponent();
        }

        private void Evaluebutton_Click(object sender, EventArgs e)
        {
            numerosFuncion();
        }

        public void numerosFuncion()
        {
            for (int i = 1; i < 100; i++)
            {
                if (i % 3 == 0)
                {
                    DetalleslistBox1.Items.Add("Numero multiplo de 3:             " +  i  + "        Henry");

                }
                if (i % 5 == 0)
                {
                    DetalleslistBox1.Items.Add("Numero multiplo de 5:             " +  i  + "        Vasquez");

                }

                if (i % 3 == 0 && i % 5 == 0)
                {
                    DetalleslistBox1.Items.Add("Numero multiplo de 3 y 5:        " +  i  + "        Henry Vasquez");

                }

            }
        }

    }
}
