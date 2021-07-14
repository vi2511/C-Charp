using System;
using System.Globalization;


namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria contaComp;

            Console.Write("Entre o número da conta: ");
            int conta = int.Parse(Console.ReadLine());

            Console.Write("Entre com o titular da conta: ");
            string titular = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            char resp = char.Parse(Console.ReadLine());

            if(resp == 's'  || resp == 'S')
            {
                Console.Write("Entre o valor de depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                contaComp = new ContaBancaria(conta, titular, depositoInicial);
            }
            else
            {
                contaComp = new ContaBancaria(conta, titular);
            }

            Console.WriteLine(contaComp);

            Console.Write("Entre um valor para depósito: ");
            double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            contaComp.Depositar(deposito);

            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(contaComp);

            Console.Write("Entre um valor para retirada: ");
            double retirada = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            contaComp.Retirar(retirada);

            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(contaComp);

        }
    }
}
