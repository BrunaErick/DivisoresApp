public class DivisorProgram
{
    public DivisorProgram()
    {
    }

    public static void Main(string[] args)
    {
        for (int i = 0; i < 10; i++) {
            contas();
        }
    }

    public static void contas()
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

    public static string contasWebApi(string? digito)
    {
        string resultado = "";
        int numero = int.Parse(digito);

        List<int> divisores = EncontrarDivisores(numero);

        resultado += $"Divisores de {numero}: ";
        foreach (int divisor in divisores)
        {
            resultado += $"{divisor} ";
            if (EhPrimo(divisor))
            {
                resultado += "(primo) ";
            }
            resultado += ", ";
        }

        return resultado;
    }

    public static List<int> EncontrarDivisores(int numero)
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

    public static bool EhPrimo(int numero)
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
