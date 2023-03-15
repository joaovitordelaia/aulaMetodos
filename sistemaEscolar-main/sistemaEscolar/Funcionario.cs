using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaEscolar
{
    class Funcionario
    {
        string nome;
        double salario;

        public string Nome { get => Nome; set => nome = value; }
        public double Salario { get => Salario; set => Salario = value; }

        public Funcionario(string Nome, double Salario)
        {
            this.Nome = nome;
            this.Salario = salario;
        }

        public void AumentarSalario(double valor)
        {
            this.salario += valor;
        }

        public string ConsultarFunci()
        {
            return this.nome;
        }


    }
}
