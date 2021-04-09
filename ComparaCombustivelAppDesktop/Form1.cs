using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VerificaCombustivel;

namespace ComparaCombustivelAppDesktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            bool check = CheckEmpty();
            if (check == true)
            {
                MessageBox.Show("Nada para limpar", "Aviso!");
            }
            else Clear();
        }
        public bool CheckEmpty()
        {
            bool vazio;
            if (txtEtanol.Text == String.Empty && txtGasolina.Text == String.Empty)
            {
                return true;
            }
            else return false;
        }
        public void Clear()
        {
            txtEtanol.Clear();
            txtGasolina.Clear();
            txtResultado.Clear();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            bool check = CheckEmpty();
            if (check == true)
            {
                MessageBox.Show("Insira os valores para calcular!", "Alerta");
            }
            else
            {
                Calculo cal = new Calculo();
                try
                {
                    double media = cal.media(txtEtanol.Text, txtGasolina.Text);

                    if (media > 0.7)
                    {
                        txtResultado.Text = "Vale a pena abastecer com Gasolina!";
                    }
                    else if (media < 0.7)
                    {
                        txtResultado.Text = "Vale a pena abastecer com Etanol!";
                    }
                    else txtResultado.Text = "Tanto faz abastecer com Etanol ou Gasolina!";
                    return;
                }
                catch (FormatException)
                {
                    MessageBox.Show("Os campo de Etanol e Gasolina devem ser somente numeros!", "Valor incorreto");
                    Clear();
                }
            }
        }

        private void txtGasolina_TextChanged(object sender, EventArgs e)
        {
            this.AcceptButton = btnCalcular;
        }
    }
}
