internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Digite a quantidade atual em estoque: ");
        int quantidadeAtual = int.Parse(Console.ReadLine()!);

        Console.Write("Digite a quantidade máxima em estoque: ");
        int quantidadeMaxima = int.Parse(Console.ReadLine()!);

        Console.Write("Digite a quantidade mínima em estoque: ");
        int quantidadeMinima = int.Parse(Console.ReadLine()!);

        int quantidadeMedia = (quantidadeMaxima + quantidadeMinima) / 2;

        Console.Clear();
        Console.WriteLine($"Quantidade média: {quantidadeMedia}");

        if (quantidadeAtual >= quantidadeMedia)
        {
            Console.WriteLine(Environment.NewLine + "Não efetuar compra");
        }
        else
        {
            Console.WriteLine(Environment.NewLine + "Efetuar compra");
        }
    }
}
