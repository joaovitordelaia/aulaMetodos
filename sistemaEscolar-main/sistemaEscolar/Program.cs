using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaEscolar
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno alunoJoao = new Aluno();
            Aluno alunoIzione = new Aluno();
            Aluno alunoJulio = new Aluno();

            Funcionario funcionarioJulio = new Funcionario("julio",1000);


            

            Console.WriteLine(funcionarioJulio.AumentarSalario(1000));


            Console.ReadKey();




        }
    }
}
