using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX10POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o peso da pessoa (em kg): ");
            double peso = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a altura da pessoa (em metros): ");
            double altura = Convert.ToDouble(Console.ReadLine());

            Pessoa pessoa = new Pessoa(peso, altura);
            string status = pessoa.CalcularStatus();

            Console.WriteLine($"A pessoa está com o status: {status}");
        }
    }
}
