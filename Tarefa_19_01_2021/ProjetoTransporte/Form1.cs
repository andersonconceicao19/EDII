using ProjetoTransporte.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoTransporte
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CadastrarVeiculos formCadastro = new CadastrarVeiculos();
            formCadastro.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Garagens _garagens = new Garagens();
            _garagens.Garagems.Add(new Garagem(1, "Guarulhos"));
            _garagens.Garagems.Add(new Garagem(2, "Congonhas"));
            btnCadastroGaragem.Enabled = false;
            MessageBox.Show("Cadastrado as garagens de:\nGuarulhos \nCongonhas ");
            
        }

    }
}
