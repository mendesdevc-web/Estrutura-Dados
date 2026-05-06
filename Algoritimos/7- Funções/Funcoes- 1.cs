using System;

class Funcoes
{
    static void Main()
    {
        // Chamando função sem retorno
        Saudacao();

        // Chamando função com parâmetro
        MostrarNome("João");

        // Chamando função com retorno
        int soma = Somar(10, 5);
        Console.WriteLine($"Soma: {soma}");

        // Função com lógica
        string resultado = VerificarPar(7);
        Console.WriteLine($"Resultado: {resultado}");
    }

    // ===============================
    // Função sem retorno
    // Uso: executar uma ação
    // ===============================
    static void Saudacao()
    {
        Console.WriteLine("Olá!");
    }

    // ===============================
    // Função com parâmetro
    // Uso: receber dados e mostrar algo
    // ===============================
    static void MostrarNome(string nome)
    {
        Console.WriteLine($"Nome: {nome}");
    }

    // ===============================
    // Função com retorno
    // Uso: calcular e devolver valor
    // ===============================
    static int Somar(int a, int b)
    {
        return a + b;
    }

    // ===============================
    // Função com lógica
    // Uso: tomar decisão e retornar resultado
    // ===============================
    static string VerificarPar(int numero)
    {
        return numero % 2 == 0 ? "Par" : "Ímpar";
    }
}