namespace Agenda.Domain
{
    public class Data
    {
        public Data(int dia, int mes, int ano)
        {
            Dia = dia;
            Mes = mes;
            Ano = ano;
        }
        public Data()
        {
            Dia = 0;
            Mes = 0;
            Ano = 0;
        }
        public int Dia { get; private set; }
        public int Mes { get; private set; }
        public int Ano { get; private set; }

        public void SetData(int dia, int mes, int ano)
        {
            Dia = dia;
            Mes = mes;
            Ano = ano;
        }
        public override string ToString()
        {
            return $"{Dia}/{Mes}/{Ano}";
        }
    }
}
