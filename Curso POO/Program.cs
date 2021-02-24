using System;

namespace Curso_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o número da conta: ");
            int idConta = int.Parse(Console.ReadLine());
            Console.Write("Entre com o titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá depósito inicial? (s/n) ");
            double saldo = 0.0;
            bool deposito = true;
            if(Console.ReadLine() == "n" || Console.ReadLine() == "N")
            {
                deposito = false;
            }
            else
            {
                Console.Write("Entre com o valor do depósito: ");
                saldo = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("");
            
            Conta c = new Conta();
            c.CriarConta(idConta, titular, saldo, deposito);

            Console.WriteLine("Dados da conta:");
            Console.WriteLine(c.ToString());

            Console.Write("Entre com o valor do depósito: ");
            saldo = double.Parse(Console.ReadLine());

            c.Deposito(saldo);
            Console.WriteLine("");
            Console.WriteLine("Dados atualizados da conta:");
            Console.WriteLine(c.ToString());
            Console.WriteLine("");

            Console.Write("Entre com o valor para saque: ");
            saldo = double.Parse(Console.ReadLine());

            c.Saque(saldo);
            Console.WriteLine("");
            Console.WriteLine("Dados atualizados da conta:");
            Console.WriteLine(c.ToString());
            Console.WriteLine("");

        }
    }
}
