using Agenda.Domain;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AgendaWinForms
{
    public partial class Form1 : Form
    {
        Contatos contatos = new Contatos();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
           var result = contatos.Adicionar(new Contato(txtNome.Text, txtEmail.Text, txtFone.Text, new Data(int.Parse(txtDia.Text), int.Parse(txtMes.Text), int.Parse(txtAno.Text))));
            MessageBox.Show(result ? "Cadastrado!" : "Não foi possivel cadatrar, verifique se preencheou corretamente");
        }
    }
}
