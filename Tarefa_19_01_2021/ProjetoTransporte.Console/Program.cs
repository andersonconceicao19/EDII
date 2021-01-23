using ProjetoTransporte.Domain;
using System;
using System.Threading;
using System.Windows.Forms;

namespace ProjetoTransporte.Cons
{
    class Program
    {
        static void Main(string[] args)
        {
            int result;
            Veiculos _veiculos = new Veiculos();
            Garagens _garagens = new Garagens();
            do
            {
                Console.Clear();
                Console.WriteLine(
                    "1. Cadastrar veículo \n" +
                    "2. Cadastrar garagem \n" +
                    "3. Iniciar jornada \n" +
                    "4. Encerrar jornada \n" +
                    "5. Liberar viagem de uma determinada origem para um determinado destino \n" +
                    "6. Listar veículos em determinada garagem (informando a qtde de veículos e seu potencial de transporte) \n" +
                    "7. Informar qtde de viagens efetuadas de uma determinada origem para um determinado destino \n" +
                    "8. Listar viagens efetuadas de uma determinada origem para um determinado destino \n" +
                    "9. Informar qtde de passageiros transportados de uma determinada origem para um determinado destino \n");
                Console.Write("O que deseja fazer?: ");
                result = int.Parse(Console.ReadLine());

                switch (result)
                {
                    case 1:
                        try
                        {
                            int id = _veiculos.VeiculosList.Count + 1;
                            if (id < 9)
                            {                               
                                Console.Write("Placa do Veiculos: ");
                                string placa = Console.ReadLine();

                                Console.Write("Quantidade de Passageiros permitidos: ");
                                int lotacao = int.Parse(Console.ReadLine());
                                 _veiculos.incluir(new Veiculo(id, placa, lotacao));

                              
                                for (int i = _veiculos.VeiculosList.Count; i <= _veiculos.VeiculosList.Count; i++)
                                {
                                    if ((i % 2) == 0) 
                                    {
                                        _garagens.Garagems[0].Veiculos.Push(_veiculos.VeiculosList[i-1]);
                                    }
                                    if ((i % 2) != 0)
                                    {
                                        _garagens.Garagems[1].Veiculos.Push(_veiculos.VeiculosList[i-1]);
                                    }

                                }                                
                                
                            }
                            else
                            {
                                Console.WriteLine("Excedeu o limite de veiculos cadastrados, entre em contato com adm!");
                                Thread.Sleep(1500);
                            }
                        }
                        catch (Exception)
                        {

                           
                        }

                        break;
                    case 2:
                        try
                        {
                            
                            if(_garagens.Garagems.Count == 0)
                            {
                                _garagens.Garagems.Add(new Garagem(1, "Guarulhos"));                                
                                _garagens.Garagems.Add(new Garagem(2, "Congonhas"));
                                Console.WriteLine("Cadastrados!");
                                Thread.Sleep(1500);
                            }
                            else
                            {
                                
                               Console.WriteLine("Já foram cadastradas o maximo de garagens possiveis!");
                                Thread.Sleep(1500);
                            }
                        }
                        catch (Exception)
                        {

                         
                        }
                        break;
                    case 6:
                        Console.Clear();
                        Console.Write($"Garagem de guarulhos:\n");
                        foreach (var item in _garagens.Garagems[0].Veiculos)
                        {
                            Console.WriteLine($"Placa: {item.Placa}, Lotação: {item.Lotacao}");
                        }
                        Console.Write($"Garagem de Congonhas:\n\n");
                        foreach (var item in _garagens.Garagems[1].Veiculos)
                        {
                            Console.WriteLine($"Placa: {item.Placa}, Lotação: {item.Lotacao}");
                        }

                        Console.WriteLine("\n--------Aperte qualquer tecla para prosseguir!");
                        Console.ReadLine();
                        break;
                    default:
                        break;
                }


            } while (result != 0);
        }
    }
}
