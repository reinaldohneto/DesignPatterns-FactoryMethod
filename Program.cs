using System;

namespace Factory_Method
{
  class Program
  {
    static void Main(string[] args)
    {
      PersonagemFactory pf = new PersonagemFactory();

      Console.WriteLine("Liu Kang | SubZero | Scorpion");
      Console.WriteLine();
      Console.Write("Escolha seu personagem: ");
      String escolha = Console.ReadLine();

      IPersonagem personagem = pf.EscolherPersonagem(escolha);
      Console.WriteLine();
      Console.Write("Você vai jogar com: ");
      personagem.Escolhido();
      Console.ReadKey();
    }
  }
}
