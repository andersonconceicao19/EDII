using Projeto_Atendimento.DLL;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Projeto_Atendimento
{
    public partial class Form1 : Form
    {
        Senhas senhas = new Senhas();
        Guiches guiches = new Guiches();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            this.senhas.gerarSenha();
            //lblSenhas.Items.Add(this.senhas.Senha.GetType().GetMethod("dadosParciais()"));

           
        }

        private void btnListarSenhas_Click(object sender, EventArgs e)
        {
            lblSenhas.Items.Clear();
            foreach (var item in this.senhas.Senha)
            {
                lblSenhas.Items.Add(item.dadosParciais());
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            guiches.adicionar(new Guiche());
            lblContador.Text = guiches.GuicheLista.Count.ToString();
        }
    }
}
