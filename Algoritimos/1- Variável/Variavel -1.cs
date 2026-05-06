using System;

class Variavel
{
    static void Main()
    {
        // ===== TIPOS BÁSICOS =====    

        int idade = 25;
        double altura = 1.75;
        decimal salario = 3000.50m;
        string nome = "João";
        char letra = 'J';
        bool ativo = true;

        // ===== VAR (tipo automático) =====

        var cidade = "Fortaleza"; // string
        var numero = 10;          // int

        // ===== TIPO NULÁVEL =====

        int? numeroOpcional = null;

        // ===== SAÍDA =====

        Console.WriteLine("===== DADOS =====");
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Idade: {idade}");
        Console.WriteLine($"Altura: {altura}");
        Console.WriteLine($"Salário: {salario}");
        Console.WriteLine($"Letra: {letra}");
        Console.WriteLine($"Ativo: {ativo}");
        Console.WriteLine($"Cidade: {cidade}");
        Console.WriteLine($"Número: {numero}");
        Console.WriteLine($"Opcional: {numeroOpcional}");
    }
}