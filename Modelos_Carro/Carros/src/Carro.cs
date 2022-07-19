using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carros.src
{
    public class Carro
    {
        int Rodas { get; set; }
        int Portas { get; set; }
        int Ano { get; set; }
        string Cor { get; set; }
        string Nome { get; set; }
        string Marca { get; set; }

        public Carro()
        {

        }

        public Carro(int rodas, int portas, int ano, string cor, string nome, string marca)
        {
            Rodas = rodas;
            Portas = portas;
            Ano = ano;
            Cor = cor;
            Nome = nome;
            Marca = marca;
        }

        public override string ToString()
        {
            return $" Nome: {Nome} \n" +
                   $" Marca: {Marca} \n" +
                   $" Cor: {Cor} \n" +
                   $" Ano: {Ano} \n" +
                   $" Quantidade de Portas: {Portas} \n" +
                   $" Quantidade de Rodas: {Rodas}\n";
        }
    }
}
