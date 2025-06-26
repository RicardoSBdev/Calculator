namespace Calculator;

class Program
{
    static void Main(string[] args)
    {
        //testando commit
        MostrarMenu();
    }

    static void MostrarMenu()
    {
        Console.Clear();

        Console.WriteLine("O que deseja fazer?");
        Console.WriteLine("1 - Somar");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Multiplicação");
        Console.WriteLine("4 - Divisão");
        Console.WriteLine("5 - Sair");
        Console.WriteLine("__________");
        Console.WriteLine("Selecione uma opção: ");

        short res = short.Parse(Console.ReadLine());

        switch (res)
        {
            case 1: Somar(); break;
            case 2: Subtrair(); break;
            case 3: Multiplicar(); break;
            case 4: Dividir(); break;
            case 5: System.Environment.Exit(0); break;
            default: MostrarMenu(); break;
        }
    }
    static void Somar()
    {
        Console.Clear();

        Console.WriteLine("Primeiro valor:");
        float v1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Segundo valor:");
        float v2 = float.Parse(Console.ReadLine());

        Console.WriteLine("");

        float resultado = v1 + v2;
        Console.WriteLine($"O resultado da Somar é {resultado}");
        Console.ReadKey();

        MostrarMenu();
    }

    static void Subtrair()
    {
        Console.Clear();

        Console.WriteLine("Primeiro valor:");
        float v1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Segundo valor:");
        float v2 = float.Parse(Console.ReadLine());

        Console.WriteLine("");

        float resultado = v1 - v2;
        Console.WriteLine($"O resultado da subtração é {resultado}");
        Console.ReadKey();

        MostrarMenu();
    }

    static void Multiplicar()
    {
        Console.Clear();

        Console.WriteLine("Primeiro valor");
        float v1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Segundo valor");
        float v2 = float.Parse(Console.ReadLine());

        Console.WriteLine("");

        float resultado = v1 * v2;
        Console.WriteLine($"O resultado da multiplicação é {resultado}");
        Console.ReadKey();

        MostrarMenu();
    }

    static void Dividir()
    {
        Console.Clear();

        Console.WriteLine("Primerio valor");
        float v1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Segundo valor");
        float v2 = float.Parse(Console.ReadLine());

        Console.WriteLine("");

        float resultado = v1 / v2;
        Console.WriteLine($"O resultado da divisão é {resultado}");
        Console.ReadKey();

        MostrarMenu();
    }
}
