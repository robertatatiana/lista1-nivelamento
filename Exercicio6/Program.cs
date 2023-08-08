internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Digite a quantidade de valores a serem lidos:");
        int n = int.Parse(Console.ReadLine()!);

        int dentroDoIntervalo = 0;
        int foraDoIntervalo = 0;

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Digite o valor {i + 1}:");
            int x = int.Parse(Console.ReadLine()!);

            if (x >= 10 && x <= 20)
                dentroDoIntervalo++;
            else
                foraDoIntervalo++;
        }

        Console.WriteLine($"{dentroDoIntervalo} in");
        Console.WriteLine($"{foraDoIntervalo} out");
    }
}