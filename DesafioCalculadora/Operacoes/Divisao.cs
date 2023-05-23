namespace DesafioCalculadora.Operacoes
{
    public class Divisao
    {
        public bool Calcular(double primeiroValor, double segundoValor)
        {
            if (segundoValor == 0)
            {
                Console.WriteLine("Não é possível dividir por zero.");
                return false;
            }
            else
            {
                var total = primeiroValor / segundoValor;
                Console.WriteLine($"{primeiroValor} dividido por {segundoValor} é igual a: {total}");
                return true;
            }

        }
    }
}
