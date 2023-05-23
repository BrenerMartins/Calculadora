namespace Exercicio1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Calculadora");
        Console.WriteLine("-----------");
        Menu();
    }

    static void Menu()
    {
        Console.Clear();

        Console.WriteLine("Escolha uma operação: ");
        Console.WriteLine("----------------------");
        Console.WriteLine("Soma: 1");
        Console.WriteLine("Subtracao: 2");
        Console.WriteLine("Divisao: 3");
        Console.WriteLine("Multiplicacao: 4");
        Console.WriteLine("Sair: 5");
        
        int opcao = int.Parse(Console.ReadLine());//int parse serve para modificar ou converter para o modo da variavel 
        switch (opcao)
        {
            case 1: Soma(); break;
            case 2: Subtracao(); break;
            case 3: Divisao(); break;
            case 4: Multiplicacao(); break;
            case 5: System.Environment.Exit(0); break;
            default: Menu(); break;
        }
    }

    static void Soma()
    {
        Console.WriteLine("Operação: Soma");
        Console.WriteLine("Digite o primeiro numero:");
        float n1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo numero:");
        float n2 = float.Parse(Console.ReadLine());

        float res = n1 + n2;

        Console.WriteLine($"A soma dos numeros é: {res}" );
        Console.ReadKey();
        Menu();
    }

    static void Subtracao()
    {
        Console.WriteLine("Operação: Subtracao");
        Console.WriteLine("Digite o primeiro numero:");
        float n1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo numero:");
        float n2 = float.Parse(Console.ReadLine());

        float res = n1 - n2;

        Console.WriteLine($"A subtracao dos numeros é: {res}" );
        Console.ReadKey();
        Menu();
    }

    static void Divisao()
    {
        Console.WriteLine("Operação: Divisao");
        Console.WriteLine("Digite o primeiro numero:");
        float n1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo numero:");
        float n2 = float.Parse(Console.ReadLine());

        float res = n1 / n2;

        Console.WriteLine($"A Divisao dos numeros é: {res}" );
        Console.ReadKey();
        Menu();
    }

    static void Multiplicacao()
    {
        Console.WriteLine("Operação: Multiplicacao");
        Console.WriteLine("Digite o primeiro numero:");
        float n1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo numero:");
        float n2 = float.Parse(Console.ReadLine());

        float res = n1 * n2;

        Console.WriteLine($"A Multiplicacao dos numeros é: {res}" );
        Console.ReadKey();
        Menu();
    }
}