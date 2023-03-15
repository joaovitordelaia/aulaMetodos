using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Bancario
{
    class Conta
    {
        string numero;
        double saldo;
        double limite = 100;
        string historico = "";

        public string Numero { get => numero; set => numero = value; }
        public double Saldo { get => saldo; set => saldo = value; }
        public double Limite { get => limite; set => limite = value; }
        public string Historico { get => historico; set => historico = value; }

        public double LerSaldo()
        {
            return this.Saldo;
        }

        public Conta(string Numero, double Saldo, double Limite)
        {
            this.Numero = Numero;
            this.Saldo = Saldo;
            this.Limite = Limite;
        }

        public void Deposita(double Valor)
        {
            this.Saldo = this.Saldo + Valor;
            this.Historico += "(+) R$ " + Valor.ToString() + "\n";
        }

        public string Saca(double Valor)
        {
            if (this.Saldo >= Valor)
            {
                this.Saldo = this.Saldo - Valor;
                this.Historico += "(-) R$ " + Valor.ToString() + "\n";
                return "Retire o seu dinheiro";
            }
            else
            {
                return "Saldo insuficiente!!!";
            }
        }

        public string EmiteExtrato()
        {
            return this.Historico;
        }

        ~Conta() { }


    }
}
