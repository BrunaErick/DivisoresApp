public class Program
{
    public Program()
    {
    }

    static void Main(string[] args)
    {
        Console.Write("Digite um número: ");
        int numero = int.Parse(Console.ReadLine());

        List<int> divisores = EncontrarDivisores(numero);

        Console.WriteLine($"Divisores de {numero}:");
        foreach (int divisor in divisores)
        {
            Console.Write($"{divisor} ");
            if (EhPrimo(divisor))
            {
                Console.Write("(primo) ");
            }
            Console.WriteLine();
        }
    }

    static List<int> EncontrarDivisores(int numero)
    {
        List<int> divisores = new List<int>();

        for (int i = 1; i <= numero; i++)
        {
            if (numero % i == 0)
            {
                divisores.Add(i);
            }
        }

        return divisores;
    }

    static bool EhPrimo(int numero)
    {
        if (numero <= 1) return false;
        if (numero == 2) return true;
        if (numero % 2 == 0) return false;

        for (int i = 3; i <= Math.Sqrt(numero); i += 2)
        {
            if (numero % i == 0) return false;
        }

        return true;
    }
}
