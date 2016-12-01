using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class formCalculadora : Form
    {
        public formCalculadora()
        {
            InitializeComponent();
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            //double rdo = 0;
            string operador = cmbOperacion.Text;
            Numero num1 = new Numero(txtNumero1.Text);
            Numero num2 = new Numero(txtNumero2.Text);
            operador = Calculadora.validarOperador(operador);
            if (cmbOperacion.Text == "")
            {
                cmbOperacion.Text = "+";
            }
            lblResultado.Text = Calculadora.operar(num1, num2, operador).ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNumero1.Clear();
            txtNumero2.Clear();
            cmbOperacion.SelectedIndex = 0;
            lblResultado.Text = "";
        }

        private void txtNumero1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Solo permite ingresar numeros 
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (Char.IsControl(e.KeyChar)) //Permite presionar tecla retroceso
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
        }
        private void txtNumero2_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Solo permite ingresar numeros 
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (Char.IsControl(e.KeyChar)) //Permite presionar tecla retroceso
                {
                    e.Handled = false;
                }
                else
                {                    
                    e.Handled = true;
                }
            }
        }
    }
}
