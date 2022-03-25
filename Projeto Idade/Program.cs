using System;

namespace ProjetoIdade;

class Program 
{
    static void Main (string [] args)
    {   
        int AnoNascimento; // Declarando variável

        Console.WriteLine("Digite o seu Ano de Nascimento");
        //String AnoNascimentoDigitado = Console.ReadLine();
        AnoNascimento=int.Parse(Console.ReadLine()); // Atribuindo valor a variável

        Console.WriteLine("Digite o ano atual");
        //String AnoAtualDigitado = Console.ReadLine();
        int AnoAtual=int.Parse(Console.ReadLine()); // Declarando e atribuindo valor a variável

        int Idade= AnoAtual- AnoNascimento; // Declarando e atribuindo valor a variável
        Console.WriteLine("Sua idade é:"+ Idade);
    }
}