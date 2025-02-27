using System;

class Program
{
    static void Main()
    {
        // Criar o array com 6 elementos
        int[] arrayMaior = { 5, 12, 7, 20, 15, 3 };

        // Inicializar o maior valor com o primeiro elemento
        int maiorValor = arrayMaior[0];

        // Encontrar o maior valor
        for (int i = 1; i < arrayMaior.Length; i++)
        {
            if (arrayMaior[i] > maiorValor)
            {
                maiorValor = arrayMaior[i];
            }
        }

        // Exibir o maior valor
        Console.WriteLine("O maior valor no array é: " + maiorValor);
    }
}