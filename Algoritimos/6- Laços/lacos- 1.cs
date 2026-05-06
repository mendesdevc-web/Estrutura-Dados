using System;

class lacos
{
    static void Main()
    {
        // ===============================
        // FOR → usar quando você SABE quantas vezes vai repetir
        // Exemplo: contar de 1 até 5
        // ===============================
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine($"FOR: {i}");
        }


        // ===============================
        // WHILE → usar quando NÃO sabe quantas vezes vai repetir
        // Depende de uma condição
        // ===============================
        int j = 1;

        while (j <= 5)
        {
            Console.WriteLine($"WHILE: {j}");
            j++;
        }


        // ===============================
        // DO WHILE → usar quando precisa executar PELO MENOS UMA VEZ
        // Mesmo que a condição seja falsa
        // ===============================
        int k = 1;

        do
        {
            Console.WriteLine($"DO WHILE: {k}");
            k++;
        }
        while (k <= 5);


        // ===============================
        // FOREACH → usar para percorrer listas, arrays ou coleções
        // Não precisa de índice (mais simples)
        // ===============================
        int[] numeros = { 10, 20, 30 };

        foreach (int numero in numeros)
        {
            Console.WriteLine($"FOREACH: {numero}");
        }


        // ===============================
        // BREAK → usar para PARAR o loop antes do final
        // ===============================
        for (int x = 1; x <= 5; x++)
        {
            if (x == 3)
            {
                break; // para o loop
            }

            Console.WriteLine($"BREAK: {x}");
        }


        // ===============================
        // CONTINUE → usar para PULAR uma repetição
        // ===============================
        for (int y = 1; y <= 5; y++)
        {
            if (y == 3)
            {
                continue; // pula o número 3
            }

            Console.WriteLine($"CONTINUE: {y}");
        }
    }
}