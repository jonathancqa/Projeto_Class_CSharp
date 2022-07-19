using System;
using Carros.src;

namespace Carros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro fusca = new Carro(4, 2, 1996, "Azul", "Fusca", "Wolksvagem");
            Carro   uno = new Carro();

            Console.Write(fusca.ToString());

        }
   
    }
}
