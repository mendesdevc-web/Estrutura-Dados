using System;

class Program
{
    static void Main()
    {
        // ===============================
        // TIPOS DE VALOR (VALUE TYPES)
        // ===============================

        // int → números inteiros (sem casas decimais)
        int idade = 25;

        // double → números com casas decimais (mais usado)
        double altura = 1.75;

        // float → número decimal com menos precisão (precisa do 'f')
        float peso = 70.5f;

        // decimal → alta precisão (ideal para dinheiro)
        decimal salario = 2500.75m;

        // bool → verdadeiro ou falso
        bool ativo = true;

        // char → apenas UM caractere
        char letra = 'A';


        // ===============================
        // TIPOS DE REFERÊNCIA (REFERENCE TYPES)
        // ===============================

        // string → texto (conjunto de caracteres)
        string nome = "Carlos";

        // object → pode armazenar qualquer tipo
        object qualquer = "Posso ser qualquer coisa";


        // ===============================
        // TIPO IMPLÍCITO
        // ===============================

        // var → o C# descobre o tipo automaticamente
        var cidade = "Fortaleza"; // string
        var numero = 100;         // int


        // ===============================
        // TIPOS NULÁVEIS (NULLABLE)
        // ===============================

        // int? → pode armazenar número OU null
        int? idadeOpcional = null;

        // double? → pode ser decimal OU null
        double? preco = null;


        // ===============================
        // SAÍDA DE DADOS
        // ===============================

        Console.WriteLine("===== TIPOS DE DADOS EM C# =====");

        Console.WriteLine($"int (idade): {idade}");
        Console.WriteLine($"double (altura): {altura}");
        Console.WriteLine($"float (peso): {peso}");
        Console.WriteLine($"decimal (salario): {salario}");
        Console.WriteLine($"bool (ativo): {ativo}");
        Console.WriteLine($"char (letra): {letra}");

        Console.WriteLine($"string (nome): {nome}");
        Console.WriteLine($"object (qualquer): {qualquer}");

        Console.WriteLine($"var (cidade): {cidade}");
        Console.WriteLine($"var (numero): {numero}");

        Console.WriteLine($"int? (idadeOpcional): {idadeOpcional}");
        Console.WriteLine($"double? (preco): {preco}");
    }
}