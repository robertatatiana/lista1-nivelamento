internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Digite o número de horas trabalhadas em um mês: ");
        int horasTrabalhadas = int.Parse(Console.ReadLine()!);

        Console.Write("Digite o salário por hora: ");
        double salarioHora = double.Parse(Console.ReadLine()!);

        const int horasSemana = 40;
        const int semanasMes = 4;

        double salarioTotal = salarioHora * horasSemana * semanasMes;

        if (horasTrabalhadas > horasSemana * semanasMes)
        {
            int horasExtras = horasTrabalhadas - (horasSemana * semanasMes);
            double valorHoraExtra = salarioHora * 1.5;
            double salarioHoraExtra = valorHoraExtra * horasExtras;
            salarioTotal += salarioHoraExtra;

            Console.WriteLine($"Horas extras em um mês: {horasExtras}");
            Console.WriteLine($"Valor das horas extras: R$ {salarioHoraExtra:F2}");
        }
        else
        {
            Console.WriteLine($"Horas trabalhadas em um mês: {horasTrabalhadas}");
            Console.WriteLine("Não foram realizadas horas extras neste mês.");
        }

        Console.WriteLine(Environment.NewLine + $"Salário total do funcionário: R$ {salarioTotal:F2}");
    }
}
