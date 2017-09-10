using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tp_laboratorio_2;

namespace tp_laboratorio_2
{
    public partial class FormCalculadora : Form
    {
        static Numero numero1;
        static Numero numero2;
        static Numero resultado;
        static String operador = String.Empty;
        //bool flagOperador1 = false;
        //bool flagOperador1 = s;

        public FormCalculadora()
        {
            numero1 = new Numero();
            numero2 = new Numero();
            InitializeComponent();
        }

        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            textBoxOperador1.Text = "0";
            textBoxOperador2.Text = "0";
            lblResultado.Text = "0";
            comboBox1.Text = "+";
        }

        private void buttonIgual_Click(object sender, EventArgs e)
        {
            numero1 = new Numero(textBoxOperador1.Text);
            numero2 = new Numero(textBoxOperador2.Text);
            operador = comboBox1.Text;
            resultado = new Numero(Calculadora.Operar(numero1, numero2,operador));
            textBoxOperador1.Text = numero1.GetNumero().ToString();
            textBoxOperador2.Text = numero2.GetNumero().ToString();
            lblResultado.Text = resultado.GetNumero().ToString();
            textBoxOperador1.Text = "0";
            textBoxOperador2.Text = "0";
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxOperador1.Text = "0";
            textBoxOperador2.Text = "0";
            lblResultado.Text = "0";
            comboBox1.Text = "+";
        }
    }
}

