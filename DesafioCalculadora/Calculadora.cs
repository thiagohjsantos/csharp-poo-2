using DesafioCalculadora.Operacoes;

namespace DesafioCalculadora
{
    public class Calculadora
    {
        public Adicao Adicao { get; private set; }
        public Subtracao Subtracao { get; private set; }
        public Divisao Divisao { get; private set; }
        public Multiplicacao Multiplicacao { get; private set; }

        public Calculadora()
        {
            Adicao = new Adicao();
            Subtracao = new Subtracao();
            Divisao = new Divisao();
            Multiplicacao = new Multiplicacao();

        }
    }
}
