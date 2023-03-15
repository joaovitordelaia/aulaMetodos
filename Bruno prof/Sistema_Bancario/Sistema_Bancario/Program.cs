using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Bancario
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();
            Agencia centro = new Agencia();
            Conta conta = new Conta("1.520-5", 0, 0);
            CartaoDeCredito cdc = new CartaoDeCredito();

            conta.Deposita(500);
            conta.Deposita(600);
            conta.Saca(200);
            conta.Deposita(300);
            conta.Saca(100);

            Console.WriteLine(conta.EmiteExtrato());

            Console.ReadKey();
        }
    }

}
