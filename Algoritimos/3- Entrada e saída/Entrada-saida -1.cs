using System;

class EntradaSaida
{
    static void Main()
    {
        // ===== SAÍDA =====
        Console.WriteLine("Digite seu nome:");

        // ===== ENTRADA (texto) =====
        string nome = Console.ReadLine();

        Console.WriteLine("Digite sua idade:");

        // ===== ENTRADA (int) =====
        int idade = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite sua altura:");

        // ===== ENTRADA (double) =====
        double altura = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite seu salário:");

        // ===== ENTRADA (decimal) =====
        decimal salario = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Você está empregado? (true/false):");

        // ===== ENTRADA (bool) =====
        bool empregado = bool.Parse(Console.ReadLine());

        // ===== SAÍDA FINAL =====
        Console.WriteLine("\n===== RESULTADO =====");

        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Idade: {idade}");
        Console.WriteLine($"Altura: {altura}");
        Console.WriteLine($"Salário: {salario}");
        Console.WriteLine($"Empregado: {empregado}");
    }
}