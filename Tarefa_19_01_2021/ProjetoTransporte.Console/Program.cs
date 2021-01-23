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
            Viagens _viagens = new Viagens();

            _veiculos.incluir(new Veiculo(1, "BRASIL-1", 30));
            _veiculos.incluir(new Veiculo(2, "BRASIL-2", 30));
            _veiculos.incluir(new Veiculo(3, "BRASIL-3", 30));
            _veiculos.incluir(new Veiculo(4, "BRASIL-4", 30));
            _veiculos.incluir(new Veiculo(5, "BRASIL-5", 30));
            _veiculos.incluir(new Veiculo(6, "BRASIL-6", 30));
            _veiculos.incluir(new Veiculo(7, "BRASIL-7", 30));
            _veiculos.incluir(new Veiculo(8, "BRASIL-8", 30));
            _garagens.Garagems.Add(new Garagem(1, "guarulhos"));
            _garagens.Garagems.Add(new Garagem(2, "congonhas"));

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
                                                         
                                Console.Write("Placa do Veiculos: ");
                                string placa = Console.ReadLine();

                                Console.Write("Quantidade de Passageiros permitidos: ");
                                int lotacao = int.Parse(Console.ReadLine());
                                 _veiculos.incluir(new Veiculo(id, placa, lotacao));                
                             
                        }
                        catch (Exception)
                        {}
                        break;
                    case 2:
                        try
                        {
                            Console.Write("Local da garagem: ");
                            var local = Console.ReadLine();
                            int codGaragem =_garagens.Garagems.Count + 1;
                            _garagens.Garagems.Add(new Garagem(codGaragem, local));

                        }
                        catch (Exception)
                        {

                         
                        }
                        break;
                    case 3:
                        try
                        {
                            var counts = _veiculos.VeiculosList.Count;
                            double distribuicao = _veiculos.VeiculosList.Count / _garagens.Garagems.Count;
                            var seila = (distribuicao * _garagens.Garagems.Count) == _veiculos.VeiculosList.Count ? true : false;
                            int popula = 0;
                            for (int i = 0; i < _garagens.Garagems.Count; i++)
                            {

                                do
                                {
                                    if (popula == distribuicao)
                                    {
                                        popula = 0;
                                    }
                                    if (counts == 0)
                                    {
                                        break;
                                    }
                                    _garagens.Garagems[i].Veiculos.Push(_veiculos.VeiculosList[counts - 1]);
                                    popula++;
                                    counts--;

                                }
                                while (distribuicao != popula);

                            }
                            if (!seila)
                            {
                                for (int j = 0; j < counts; j++)
                                {
                                    if (counts == 0)
                                    {
                                        break;
                                    }
                                    _garagens.Garagems[0].Veiculos.Push(_veiculos.VeiculosList[counts - 1]);
                                };
                            }
                            _garagens.iniciarJornada();
                        }
                        catch (Exception)
                        { }
                        break;
                    case 4: // TRABALHANDO aqui
                        foreach (var veic in _veiculos.VeiculosList)
                        {
                            Console.WriteLine($"Veiculo da placa: {veic.Placa}. Carregou {veic.Lotacao*2} pessoas, entre percurso de ida e volta");
                        }
                        _garagens.encerrarJornada();
                        Console.ReadLine();
                        break;
                    case 5:
                        Console.Write("Origem: ");
                        var origemDesc = Console.ReadLine();

                        if(!_garagens.Garagems.Exists(x => x.Local == origemDesc))
                        {
                            Console.Clear();
                            Console.WriteLine("Origem não existe!");
                            Thread.Sleep(1800);
                            Console.Clear();
                            return;
                        }

                        if (_garagens.Garagems.Find(x => x.Local == origemDesc).Veiculos.Count == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("É necessário que tenha veiculo disponivel");
                            Thread.Sleep(1800);
                            Console.Clear();
                            return;
                        };
                        
                        Console.Write("Destino: ");
                        var destinoDesc = Console.ReadLine();

                        var garagemOrigem = _garagens.Garagems.Find(x => x.Local == origemDesc);
                        var garagemDestino = _garagens.Garagems.Find(x => x.Local == destinoDesc);
                        var veiculoSaida = garagemOrigem.Veiculos.Pop();

                        _viagens.incluir(new Viagem(_viagens.ViagensQueue.Count+1, garagemOrigem, garagemDestino, veiculoSaida));
                        garagemDestino.Veiculos.Push(veiculoSaida);
                        break;
                    default:
                        break;
                }


            } while (result != 0);
        }
    }
}
