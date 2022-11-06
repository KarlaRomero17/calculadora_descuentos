using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora_descuentos
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
               double isss = 0.03;
            double afp = 0.0725;
            double renta = 1;
            */

            double descuento_iss;
            double descuento_afp;
            double descuento_renta;
            double salario;
            double total_salario_bruto;
            salario = double.Parse(textBox1.Text);
            //salario_bruto = double.Parse(textBox5.Text);

            descuento_iss = salario * 0.03;
            descuento_afp = salario * 0.0725;
            descuento_renta = salario * 0.1;
            double suma_descuento;

            textBox2.Text = descuento_iss.ToString();

            textBox3.Text = descuento_afp.ToString();

            textBox4.Text = descuento_renta.ToString();

            suma_descuento = descuento_iss + descuento_renta + descuento_afp;
            total_salario_bruto = salario- suma_descuento;

            textBox5.Text = total_salario_bruto.ToString();
        }
    }
}
