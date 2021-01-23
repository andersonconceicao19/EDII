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
    public partial class CadastrarVeiculos : Form
    {
        Veiculos _veiculos = new Veiculos();

        public CadastrarVeiculos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int id = _veiculos.VeiculosList.Count + 1;
                string placa = txtPlaca.Text;
                int lotacao = int.Parse(txtLotacao.Text);
                var result = _veiculos.incluir(new Veiculo(id, placa, lotacao));
                if (result)
                {
                    MessageBox.Show("Salvo");
                    txtPlaca.Text = "";
                    txtLotacao.Text = "";
                }

            }
            catch (Exception)
            {

                throw;
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
