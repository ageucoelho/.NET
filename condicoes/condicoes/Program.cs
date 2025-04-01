using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace condicoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual o seu nome? ");
            string nome = Console.ReadLine();
            Console.WriteLine("Olá, " + string.Format(nome) + ". Qual a sua idade? ");
            int idade = int.Parse(Console.ReadLine());

            if (idade < 2)
            {
                Console.WriteLine("Você é um bebê.");
            }
            else if (idade < 10)
            {
                Console.WriteLine("Você é uma criança.");
            }
            else if (idade < 18)
            {
                Console.WriteLine("Você é um adolescente.");
            }
            else if (idade < 60)
            {
                Console.WriteLine("Voce é um adulto.");
            }
            else
            {
                Console.WriteLine("Você é um idoso");
            }
        }
    }
}
