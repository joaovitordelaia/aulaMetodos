using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaContabil
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente clienteJoao = new Cliente();
            Agencia agenciaCentro = new Agencia();
            Conta contaJoao = new Conta("01224", 0,1000);
            //CartaoCredito cdcJoao = new CartaoCredito();
            
            

            Console.WriteLine(contaJoao.numConta());


            Console.ReadKey();


        }
    }
}
