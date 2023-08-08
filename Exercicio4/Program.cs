internal class Program
{
    private static void Main(string[] args)
    {
        int[] vetor = new int[100];
        Random random = new Random();

        for (int i = 0; i < vetor.Length; i++)
        {
            vetor[i] = random.Next();
        }

        int maiorNumero = vetor[0];
        int menorNumero = vetor[0];
        int posicaoMaior = 0;
        int posicaoMenor = 0;

        for (int i = 1; i < vetor.Length; i++)
        {
            if (vetor[i] > maiorNumero)
            {
                maiorNumero = vetor[i];
                posicaoMaior = i;
            }

            if (vetor[i] < menorNumero)
            {
                menorNumero = vetor[i];
                posicaoMenor = i;
            }
        }

        Console.WriteLine($"Maior número: {maiorNumero}, posição: {posicaoMaior}");
        Console.WriteLine($"Menor número: {menorNumero}, posição: {posicaoMenor}");
    }
}