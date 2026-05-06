using System;

class Matrizes
{
    static void Main()
    {
        // =====================================================
        // 🧮 MATRIZ 2D (LINHAS x COLUNAS)
        // =====================================================

        /*
         MATRIZ 2D:
         - Representa uma tabela (linha e coluna)
         - Usa dois índices: [linha, coluna]
        */

        int[,] matriz2D =
        {
            { 1, 2, 3 },   // linha 0
            { 4, 5, 6 },   // linha 1
            { 7, 8, 9 }    // linha 2
        };

        Console.WriteLine("=== MATRIZ 2D ===");

        // Percorrendo linhas
        for (int i = 0; i < matriz2D.GetLength(0); i++)
        {
            // Percorrendo colunas
            for (int j = 0; j < matriz2D.GetLength(1); j++)
            {
                // Acessa posição [linha, coluna]
                Console.Write(matriz2D[i, j] + " ");
            }

            Console.WriteLine(); // quebra de linha por linha da matriz
        }

        Console.WriteLine("\n");


        // =====================================================
        // 🧊 MATRIZ 3D (CAMADAS x LINHAS x COLUNAS)
        // =====================================================

        /*
         MATRIZ 3D:
         - Representa "camadas de tabelas"
         - Usa três índices: [camada, linha, coluna]
         - Pense como vários andares de tabelas empilhadas
        */

        int[,,] matriz3D =
        {
            {
                { 1, 2 },   // camada 0, linha 0
                { 3, 4 }    // camada 0, linha 1
            },
            {
                { 5, 6 },   // camada 1, linha 0
                { 7, 8 }    // camada 1, linha 1
            }
        };

        Console.WriteLine("=== MATRIZ 3D ===");

        // Percorre camadas
        for (int k = 0; k < matriz3D.GetLength(0); k++)
        {
            Console.WriteLine($"Camada {k}:");

            // Percorre linhas
            for (int i = 0; i < matriz3D.GetLength(1); i++)
            {
                // Percorre colunas
                for (int j = 0; j < matriz3D.GetLength(2); j++)
                {
                    // Acessa posição [camada, linha, coluna]
                    Console.Write(matriz3D[k, i, j] + " ");
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }

        // =====================================================
        // 🧠 RESUMO FINAL
        // =====================================================

        /*
         MATRIZ 2D:
         - [linha, coluna]
         - Ex: tabela (Excel, grade)

         MATRIZ 3D:
         - [camada, linha, coluna]
         - Ex: vários andares ou níveis de dados

         DIFERENÇA PRINCIPAL:
         - 2D = plano (tabela)
         - 3D = volume (camadas de tabelas)
        */
    }
}