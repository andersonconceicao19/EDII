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

            _veiculos.incluir(new Veiculo(1, "BRASIL-1", 30));
            _veiculos.incluir(new Veiculo(2, "BRASIL-2", 30));
            _veiculos.incluir(new Veiculo(3, "BRASIL-3", 30));
            _veiculos.incluir(new Veiculo(4, "BRASIL-4", 30));
            _veiculos.incluir(new Veiculo(5, "BRASIL-5", 30));
            _veiculos.incluir(new Veiculo(6, "BRASIL-6", 30));
            _veiculos.incluir(new Veiculo(7, "BRASIL-7", 30));
            _veiculos.incluir(new Veiculo(8, "BRASIL-8", 30));
            _garagens.Garagems.Add(new Garagem(1, "Guarulhos"));
            _garagens.Garagems.Add(new Garagem(2, "Congonhas"));

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

                              
                                /*for (int i = _veiculos.VeiculosList.Count; i <= _veiculos.VeiculosList.Count; i++)
                                {
                                    if ((i % 2) == 0) 
                                    {
                                        _garagens.Garagems[0].Veiculos.Push(_veiculos.VeiculosList[i-1]);
                                    }
                                    if ((i % 2) != 0)
                                    {
                                        _garagens.Garagems[1].Veiculos.Push(_veiculos.VeiculosList[i-1]);
                                    }

                                }       */                         
                             
                        }
                        catch (Exception)
                        {

                           
                        }

                        break;
                    case 2:
                        try
                        {
                            Console.WriteLine("Local da garagem: ");
                            var local = Console.ReadLine();
                            int codGaragem =_garagens.Garagems.Count + 1;
                            _garagens.Garagems.Add(new Garagem(codGaragem, local));

                        }
                        catch (Exception)
                        {

                         
                        }
                        break;
                    case 3:
                        var counts = _veiculos.VeiculosList.Count;
                        double distribuicao = _veiculos.VeiculosList.Count / _garagens.Garagems.Count;
                        var seila = (distribuicao * _garagens.Garagems.Count) == _veiculos.VeiculosList.Count ? true : false;
                        int popula = 0;
                        for (int i = 0; i < _garagens.Garagems.Count; i++)
                        {                           
                            
                            do
                            {      
                                if(popula == distribuicao)
                                {
                                    popula = 0;
                                }
                                if(counts == 0)
                                {
                                    break;
                                }
                                _garagens.Garagems[i].Veiculos.Push(_veiculos.VeiculosList[counts - 1]);
                                popula++;
                                counts--;

                            } 
                            while (distribuicao != popula );
                            
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
                        break;
                    default:
                        break;
                }


            } while (result != 0);
        }
    }
}
