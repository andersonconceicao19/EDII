using Agenda.Domain;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AgendaWinForms
{
    public partial class Form1 : Form
    {
        Contatos contatos = new Contatos();
        bool isUpdate = false;
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
            txtAno.Text = "";
            txtDia.Text = "";
            txtMes.Text = "";
            txtEmail.Text = "";
            txtFone.Text = "";
            txtNome.Text = "";
            isUpdate = false;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            bool result;
            if (!isUpdate)
            {
                result = contatos.Adicionar(new Contato(txtNome.Text, txtEmail.Text, txtFone.Text, new Data(int.Parse(txtDia.Text), int.Parse(txtMes.Text), int.Parse(txtAno.Text))));
                MessageBox.Show(result ? "Cadastrado!" : "Não foi possivel cadatrar, verifique se preencheou corretamente");
                listContatos.Items.Clear();

            }
            else
            {
                result = contatos.Alterar((new Contato(txtNome.Text, txtEmail.Text, txtFone.Text, new Data(int.Parse(txtDia.Text), int.Parse(txtMes.Text), int.Parse(txtAno.Text)))));
                MessageBox.Show(result ? "Alterado!" : "Não foi possivel alterar");
                isUpdate = false;
                listar();
            }
           

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            listar();
        }

        private void listContatos_DoubleClick(object sender, EventArgs e)
        {
            object result = listContatos.SelectedItem;
            var DataNascimento = result.GetType().GetProperty("DtNascimento").GetValue(result, null);

            txtNome.Text = result.GetType().GetProperty("Nome").GetValue(result, null).ToString();
            txtEmail.Text = result.GetType().GetProperty("Email").GetValue(result, null).ToString();
            txtFone.Text = result.GetType().GetProperty("Telefone").GetValue(result, null).ToString();
            txtDia.Text = DataNascimento.GetType().GetProperty("Dia").GetValue(DataNascimento, null).ToString();
            txtMes.Text = DataNascimento.GetType().GetProperty("Mes").GetValue(DataNascimento, null).ToString();
            txtAno.Text = DataNascimento.GetType().GetProperty("Ano").GetValue(DataNascimento, null).ToString();

            isUpdate = true;


        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            var ObjetoPesquisa = contatos.Pesquisar(new Contato("nome", txtEmail.Text, "telefone", new Data(1, 1, 1)));
            listContatos.Items.Clear();

            foreach (var item in ObjetoPesquisa)
            {
                listContatos.Items.Add(item);
            }

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
           var excluiu = contatos.Remover(new Contato(txtNome.Text, txtEmail.Text, txtFone.Text, new Data(int.Parse(txtDia.Text), int.Parse(txtMes.Text), int.Parse(txtAno.Text))));
            MessageBox.Show(excluiu ? "Excluido!" : "Não foi possivel excluir, cabaço!");
            listar();
        }
        private void listar()
        {
            listContatos.Items.Clear();
            foreach (var item in contatos.getAllContacts())
            {
                listContatos.Items.Add(item);
            }
        }
    }
}
