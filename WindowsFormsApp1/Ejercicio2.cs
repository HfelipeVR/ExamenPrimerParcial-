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
    public partial class Ejercicio2 : Form
    {
        public Ejercicio2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            Double precio = Convert.ToDouble(precioTXT.Text);
            Double cantidad = Convert.ToDouble(cantidadTXT.Text);


           Double descuento = await descuentoAsincrono(precio, cantidad);
           Double Total = await pagoAsincrono(precio, cantidad);

            DescTxt.Text = descuento.ToString();
            TotalTxt.Text = Total.ToString();


        }
        private async Task<Double> descuentoAsincrono(Double precio, Double x)
        {
            var descuentoFinal = await Task.Run(() =>
            {
                return (precio * x) * 0.15;
            });
            return descuentoFinal;
        }

        private async Task<Double> pagoAsincrono(Double precio, Double x)
        {
            double subFinal = (precio * x), descuento = ((precio * x) * 0.15);
            var totalFinal = await Task.Run(() =>
            {
                return subFinal - descuento;
            });
            return totalFinal;


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
