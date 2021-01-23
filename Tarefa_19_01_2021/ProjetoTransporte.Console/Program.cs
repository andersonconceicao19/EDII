using ProjetoTransporte.Domain;
using System;
using System.Windows.Forms;

namespace ProjetoTransporte.Cons
{
    class Program
    {
        static void Main(string[] args)
        {
            int result;
            Veiculos _veiculos = new Veiculos();
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
                                var res = _veiculos.incluir(new Veiculo(id, placa, lotacao));
                            }                          
                        }
                        catch (Exception)
                        {

                           
                        }

                        break;
                    case 2:
                        try
                        {
                            Garagens _garagens = new Garagens();
                            _garagens.Garagems.Add(new Garagem(1, "Guarulhos"));
                            _garagens.Garagems.Add(new Garagem(2, "Congonhas"));
                        }
                        catch (Exception)
                        {

                         
                        }
                        break;
                    case 3:
                        break;
                    default:
                        break;
                }


            } while (result != 0);
        }
    }
}
