using System;

class Program
{
    static void Main()
    {
        // ===============================
        // EXEMPLO 1: IF SIMPLES
        // Executa apenas se a condição for verdadeira
        // ===============================

        int idade = 20;

        if (idade >= 18)
        {
            Console.WriteLine("Exemplo 1: Você é maior de idade");
        }


        // ===============================
        // EXEMPLO 2: IF + ELSE
        // Executa uma ação se for verdadeiro, outra se for falso
        // ===============================

        if (idade >= 18)
        {
            Console.WriteLine("Exemplo 2: Adulto");
        }
        else
        {
            Console.WriteLine("Exemplo 2: Menor de idade");
        }


        // ===============================
        // EXEMPLO 3: IF + ELSE IF
        // Permite várias condições
        // ===============================

        int nota = 6;

        if (nota >= 7)
        {
            Console.WriteLine("Exemplo 3: Aprovado");
        }
        else if (nota >= 5)
        {
            Console.WriteLine("Exemplo 3: Recuperação");
        }
        else
        {
            Console.WriteLine("Exemplo 3: Reprovado");
        }


        // ===============================
        // EXEMPLO 4: OPERADORES LÓGICOS
        // && (E) → ambas condições devem ser verdadeiras
        // ===============================

        bool temCarteira = true;

        if (idade >= 18 && temCarteira)
        {
            Console.WriteLine("Exemplo 4: Pode dirigir");
        }
        else
        {
            Console.WriteLine("Exemplo 4: Não pode dirigir");
        }


        // ===============================
        // EXEMPLO 5: POSITIVO, NEGATIVO OU ZERO
        // ===============================

        int numero = -5;

        if (numero > 0)
        {
            Console.WriteLine("Exemplo 5: Número positivo");
        }
        else if (numero < 0)
        {
            Console.WriteLine("Exemplo 5: Número negativo");
        }
        else
        {
            Console.WriteLine("Exemplo 5: Número zero");
        }


        // ===============================
        // EXEMPLO 6: OPERADOR TERNÁRIO
        // Forma resumida do if/else
        // ===============================

        string resultado = numero % 2 == 0 ? "Par" : "Ímpar";

        Console.WriteLine($"Exemplo 6: O número é {resultado}");


        // ===============================
        // EXEMPLO 7: MÚLTIPLAS CONDIÇÕES
        // ===============================

        int idadePessoa = 15;

        if (idadePessoa < 12)
        {
            Console.WriteLine("Exemplo 7: Criança");
        }
        else if (idadePessoa < 18)
        {
            Console.WriteLine("Exemplo 7: Adolescente");
        }
        else
        {
            Console.WriteLine("Exemplo 7: Adulto");
        }
    }
}