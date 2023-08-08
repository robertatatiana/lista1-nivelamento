internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Digite o valor para calcular imposto: ");
        double valor = double.Parse(Console.ReadLine()!);

        double imposto;

        if (valor <= 1200)
        {
            imposto = 0;
        }
        else if (valor <= 2500)
        {
            imposto = valor * 0.1;
        }
        else if (valor <= 5000)
        {
            imposto = valor * 0.15;
        }
        else
        {
            imposto = valor * 0.2;
        }

        Console.WriteLine($"Imposto a pagar: {imposto:C}");
    }
}