using System;

namespace jogador
{
    class Program
    {
        static void Main(string[] args)            
        {
            
            Jogador jogador = new Jogador();
            Console.WriteLine("Qual seu nome?");
            jogador.Nome = Console.ReadLine();
            Console.WriteLine("Digite a sua posição");
            jogador.Posicao = Console.ReadLine();
            Console.WriteLine("Qual sua nacionalidade");
            jogador.Nacionalidade = Console.ReadLine();
            Console.WriteLine("Qual sua data de nascimento?");
            jogador.Nascimento = DateTime.Parse(Console.ReadLine());
            
            System.Console.WriteLine(jogador.MostrarDados());
            
            System.Console.WriteLine(jogador.VerificarAposentadoria());
            
            System.Console.WriteLine(jogador.CalcularIdade()); 
            
           
        }
    }
}
