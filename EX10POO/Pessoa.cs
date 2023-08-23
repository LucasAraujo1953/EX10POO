using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX10POO
{
    internal class Pessoa
    {
        private double peso;
        private double altura;

        public Pessoa(double peso, double altura)
        {
            this.peso = peso;
            this.altura = altura;
        }

        public string CalcularStatus()
        {
            double relacao = peso / (altura * altura);

            if (relacao < 20)
            {
                return "Abaixo do Peso";
            }
            else if (relacao >= 20 && relacao < 25)
            {
                return "Peso Ideal";
            }
            else
            {
                return "Acima do Peso";
            }
        }
    }
}
