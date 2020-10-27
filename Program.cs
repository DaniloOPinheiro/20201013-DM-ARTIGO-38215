using System;

namespace _20201013_DM_ARTIGO_38215
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine(
                "Boas Vindas ao artigo 38215, da plataforma DEVMEDIA",
                "Artigo Nullable Types em C#"
                );
            Console.WriteLine("------------------------------------");

            Artigo_38215 artigo = new Artigo_38215();
            artigo = null;
            if(artigo != null)
                Console.WriteLine("artigo é um inteiro");
                else
                    Console.WriteLine("artigo é nulo");
            Console.ReadLine();
        }
    }
}
