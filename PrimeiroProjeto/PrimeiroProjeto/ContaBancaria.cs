using System.Globalization;

namespace PrimeiroProjeto
{
    class ContaBancaria    {

        public int Conta { get; private set; }
        public string Titular { get; private set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int conta, string titular)
        {
            Conta = conta;
            Titular = titular;
        }

        public ContaBancaria(int conta, string titular, double saldo) : this(conta, titular)
        {
            Depositar(saldo);
        }

        override public string ToString()
        {
            return "Conta: " 
                   + Conta 
                   + ", Titular: " 
                   + Titular 
                   + ", Saldo: " 
                   + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

        public void Depositar (double valor) 
        {
            Saldo +=  valor;
        }

        public void Retirar(double valor)
        {
            Saldo -= valor + 5.0;
        }
    }
}
