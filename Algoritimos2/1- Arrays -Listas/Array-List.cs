using System;
using System.Collections.Generic; // Necessário para usar List

class ArrayList
{
    static void Main()
    {
        // ============================
        // 📦 ARRAY
        // ============================

        // Criando um array com tamanho fixo (3 posições)
        int[] numerosArray = new int[3];

        // Atribuindo valores manualmente por índice
        numerosArray[0] = 10;
        numerosArray[1] = 20;
        numerosArray[2] = 30;

        // Exibindo valores do array
        Console.WriteLine("Array:");
        for (int i = 0; i < numerosArray.Length; i++)
        {
            // Length retorna o tamanho total do array
            Console.WriteLine($"Posição {i}: {numerosArray[i]}");
        }

        // ⚠️ Se tentar adicionar mais um elemento:
        // numerosArray[3] = 40;
        // Isso gera ERRO, pois o array tem tamanho fixo


        // ============================
        // 📋 LIST
        // ============================

        // Criando uma lista dinâmica (sem tamanho definido)
        List<int> numerosList = new List<int>();

        // Adicionando elementos dinamicamente
        numerosList.Add(10);
        numerosList.Add(20);
        numerosList.Add(30);

        // Adicionando mais um elemento (sem erro)
        numerosList.Add(40);

        // Exibindo valores da lista
        Console.WriteLine("\nList:");
        for (int i = 0; i < numerosList.Count; i++)
        {
            // Count retorna a quantidade de elementos da lista
            Console.WriteLine($"Posição {i}: {numerosList[i]}");
        }

        // Removendo um elemento da lista
        numerosList.Remove(20);

        Console.WriteLine("\nList após remover o número 20:");
        foreach (var numero in numerosList)
        {
            // foreach percorre cada item da lista
            Console.WriteLine(numero);
        }


        // ============================
        // 🧠 RESUMO PRÁTICO
        // ============================

        /*
         ARRAY:
         - Tamanho fixo
         - Mais rápido
         - Menos flexível

         LIST:
         - Tamanho dinâmico
         - Mais fácil de usar
         - Ideal para APIs e banco de dados
        */
    }
}