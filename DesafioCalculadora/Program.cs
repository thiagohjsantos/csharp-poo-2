using DesafioCalculadora;

var calculadora = new Calculadora();
bool loop = true;

while (loop)
{
    Console.Clear();
    Console.WriteLine("Desafio calculadora\n");

    Console.WriteLine("Digite o primeiro valor: ");
    var input1 = Console.ReadLine();

    bool isFirstInputValid = double.TryParse(input1, out double v1);

    if (isFirstInputValid == false)
    {
        Console.WriteLine("Primeiro valor não é um número!");
        Thread.Sleep(3000);
        return;
    }

    Console.WriteLine("Digite o segundo valor: ");
    var input2 = Console.ReadLine();

    bool isSecondInputValid = double.TryParse(input2, out double v2);

    if (isSecondInputValid == false)
    {
        Console.WriteLine("Segundo valor não é um número!");
        Thread.Sleep(3000);
        return;
    }

    Console.WriteLine("\nResultados: ");

    Console.WriteLine($"\n{v1} mais {v2} é igual a: {calculadora.Adicao.Calcular(v1, v2)}\n");
    Console.WriteLine($"{v1} menos {v2} é igual a: {calculadora.Subtracao.Calcular(v1, v2)}\n");
    calculadora.Divisao.Calcular(v1, v2);
    Console.WriteLine($"\n{v1} vezes {v2} é igual a: {calculadora.Multiplicacao.Calcular(v1, v2)}");

    Thread.Sleep(7500);

}

