using System;

namespace PrimeiroPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Personagem miranha = new Personagem();
            miranha.item = "Teia";

            Console.WriteLine(miranha.nome);

            Console.WriteLine(miranha.item);

            Console.WriteLine(miranha.Atacar());

        }
    }
}
