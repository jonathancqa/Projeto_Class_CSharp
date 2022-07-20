using System;
using Carros.src;

namespace Carros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro fusca = new Carro(4, 2, 1996, "Azul", "Fusca", "Wolksvagem");
            Carro uno = new Carro(4, 4, 1994, "Vermelho", "Uno Mile", "Fiat");
            Carro Lancer = new Carro(4, 4, 2015, "Preto", "Lancer Evolution", "Mitsubishi");
            Carro nissan = new Carro(4, 2, 2009, "Verde", "350Z", "Nissan");


            Console.WriteLine(fusca.ToString());
            Console.WriteLine(uno.ToString());
            Console.WriteLine(Lancer.ToString());
            Console.WriteLine(nissan.ToString());  
            

        }
   
    }
}
