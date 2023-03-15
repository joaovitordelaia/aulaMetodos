using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscolar
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno alunoSara = new Aluno();
            Aluno alunoMaycon = new Aluno();

            alunoSara.nome = "Creuziani Sara";
            alunoSara.rg = "1.554.223";
            alunoSara.nascimento = DateTime.Parse("01/09/2000");
            alunoMaycon.nome = "Maycon Ferrari";
            alunoSara.rg = "2.001.140";
            alunoSara.nascimento = DateTime.Parse("20/05/2001");

            Console.WriteLine("Aluno: " + alunoSara.nome);
            Console.WriteLine("RG: " + alunoSara.rg);
            Console.WriteLine("Nascimento: " + alunoSara.nascimento.ToShortDateString());

            Console.ReadKey();
        }
    }
}
