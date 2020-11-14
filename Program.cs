using System;

namespace SequenciaCentena
{
    class Program
    {
        static void Main(string[] args)
        {
        int numero = 1;

        while (numero <= 100)
        {
            Console.Write(numero);
            Console.Write(" ");
            numero += 1;
        }

            Console.WriteLine("\n");
            Console.WriteLine("para sair Pressione Enter!");
            Console.ReadKey();

        }
    }
}
