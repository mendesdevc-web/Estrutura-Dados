using System;

class Operadores
{
    static void Main()
    {
        int A = 10;
        int B = 3;

        // Aritméticos
        Console.WriteLine($"Soma: {A + B}");
        Console.WriteLine($"Subtração: {A - B}");
        Console.WriteLine($"Multiplicação: {A * B}");
        Console.WriteLine($"Divisão: {A / B}");
        Console.WriteLine($"Resto: {A % B}");

        // Comparação
        Console.WriteLine($"A > B: {A > B}");
        Console.WriteLine($"A == B: {A == B}");

        // Lógicos
        bool resultado = (A > 5) && (B < 5);
        Console.WriteLine($"Resultado lógico: {resultado}");

        // Incremento
        A++;
        Console.WriteLine($"A depois do incremento: {A}");
    }
}