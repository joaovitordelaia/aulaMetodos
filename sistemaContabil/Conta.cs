using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaContabil
{
    class Conta
    {

        string numero;
        double saldo;
        double limite;
        string historico;

        public string Numero { get => numero; set => numero = value; }
        public double Saldo { get => saldo; set => saldo = value; }
        public double Limite { get => limite; set => limite = value; }
        public string Historico { get => Historico; set => Historico = value; }

        public Conta(string Numero, double Saldo, double Limite)
        {
            this.Numero = Numero;
            this.Saldo = Saldo;
            this.Limite = Limite;
        }

        public void depositar(double valor)// ÍSSO É UM METODOOOOO
        {
            this.Saldo = this.Saldo + valor;
            this.historico = 
            
        }





        public string sacar(double valor)// ÍSSO É UM METODOOOOO
        {
            if (valor <= this.Saldo)
            {
                this.Saldo = this.Saldo - valor;
                return "valor valido";
            }
            else
            {
                return "valor invalido";
            }

        }



        public double lersaldo()// ÍSSO É UM METODOOOOO
        {
            return this.Saldo;
        }

        public string numConta()// ÍSSO É UM METODOOOOO
        {
            return this.Numero;
        }




    }
}
