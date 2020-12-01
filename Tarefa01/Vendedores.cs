
using System;
using System.Linq;

namespace Tarefa01
{
    public class Vendedores 
    {

        private Vendedor[] osVendedores;
        private int max = 3;
        private int qtde = 0;


        public Vendedores()
        {
            osVendedores = new Vendedor[max];
            for (int i = 0; i < max; ++i)
            {
                osVendedores[i] = new Vendedor(-1, "...", 0);
            }
        }

        public double valorVendasPorFuncionario(int id)
        {
            var v = searchVendedor(id);
            return somaVendas(v);
        }
        private double somaVendas(Vendedor v)
        {
            var som = 0.0;
            foreach (var item in v.AsVendas)
            {
                som += (item.Valor * item.Quantidade);
            }
            return som;
        }
        public double valorVendas()
        {

            return 1.1;
        }
        public double valorPorVendedorComissao(Vendedor v)
        {
            return SumComissao(v);
        }
        public double valorComissao()
        {
            return 1.1;
        }
        public Vendedor[] PegarTodosVendores()
        {
            return osVendedores;
        }
        public void MostrarDetalhesTodosVendedores(Vendedor[] getVendedor)
        {
            int c = 0;
            double sumTotalComissao = 0.0;
            for (int i = 0; i < getVendedor.Length; i++)
            {
                if (getVendedor[i].Id > -1)
                {
                    sumTotalComissao += SumComissao(getVendedor[i]);
                    MostraDetalhesPorVendedor(getVendedor[i]);
                    c++;
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Soma total da comissão de todos os vendedores: {sumTotalComissao}");
            Console.WriteLine(c == 0 ? "Nao há vendedor cadastrado" : "");
        }
        public bool addVendedor(Vendedor v)
        {
            if(qtde < 3)           
            {
                for (int i = 0; i < osVendedores.Length; i++)
                {
                    if (osVendedores[i].Id == -1)
                    {
                        osVendedores[i] = v;
                        qtde++;
                        break;
                    }                    
                   
                }
                return true;
            }    
            return false;     
        }

        public bool delVendedor(int id)
        {
            var vendedor = PegarVendedorPorId(id);
            bool deletar = (qtde > 0);

            if (deletar)
            {
                for (int i = 0; i < osVendedores.Length; i++)
                {
                    foreach (var item in vendedor.AsVendas)
                    {
                        if (item.Dia > 0)
                        {
                            return false;
                        }
                        break;
                      
                    }
                }

                for (int i = 0; i < osVendedores.Length; i++)
                {

                    if (osVendedores[i] == vendedor)
                    {
                        vendedor = new Vendedor(-1, "...", 0);
                        osVendedores[i] = vendedor;
                        qtde--;
                        deletar =  true;
                    }
                }               
            }
            return deletar;

        }

        public Vendedor searchVendedor(int id)
        {         
            return PegarVendedorPorId(id);
        }

        public void registrarVenda(int id, Venda venda)
        {
            var vendedor = PegarVendedorPorId(id);

            for (int i = 0; i < 1; i++)
            {
            }
            for (int i = 0; i < vendedor.AsVendas.Length; i++)
            {
                if (vendedor.AsVendas[i].Dia == 0)
                {
                    vendedor.AsVendas[i] = venda;
                    break;
                }
            }
            
        }
   
        private Vendedor PegarVendedorPorId(int id)
        {
            foreach (var item in osVendedores)
            {
                if (item.Id == id)
                {
                    return item;
                }
            }
            return null;
        }
        
        public void MostraDetalhesPorVendedor(Vendedor v)
        {
            Console.Write($"\nId: {v.Id}, Nome: {v.Nome} \n");
            foreach (var item in v.AsVendas)
            {
                Console.Write(item.Dia != 0 ? $"Dia da venda: {item.Dia}, Quantidade: {item.Quantidade}, Valor: {item.Valor} \n" : "");
            }
            Console.Write($"Valor total de vendas = { valorVendasPorFuncionario(v.Id) } \n" +
                $"Valor total das comissões = { valorPorVendedorComissao(v)} \n" +
                $""
                );
        }
        private double SumComissao(Vendedor v)
        {
            var sum = 0.0;
            foreach (var item in v.AsVendas)
            {
                sum += ((v.PercComissao / 100) * ( item.Quantidade * item.Valor));
            }
            return sum;
        }
        
    }
}