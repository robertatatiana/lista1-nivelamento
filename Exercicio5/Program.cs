internal class Program
{
    private static void Main(string[] args)
    {
        int alcool = 0, gasolina = 0, diesel = 0;
        int codigo;

        while (true)
        {
            Console.WriteLine("Digite o código do combustível abastecido:");
            Console.WriteLine("1. Álcool");
            Console.WriteLine("2. Gasolina");
            Console.WriteLine("3. Diesel");
            Console.WriteLine("4. Fim");
            codigo = int.Parse(Console.ReadLine()!);

            switch (codigo)
            {
                case 1:
                    alcool++;
                    break;
                case 2:
                    gasolina++;
                    break;
                case 3:
                    diesel++;
                    break;
                case 4:
                    Console.WriteLine("MUITO OBRIGADO");
                    break;
                default:
                    Console.WriteLine("Código inválido. Digite novamente.");
                    continue;
            }

            if (codigo == 4)
                break;
        }

        Console.WriteLine($"Álcool: {alcool}");
        Console.WriteLine($"Gasolina: {gasolina}");
        Console.WriteLine($"Diesel: {diesel}");
    }
}
