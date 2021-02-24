using System;
using System.Collections.Generic;
using System.Text;

namespace Curso_POO
{
    public class Conta
    {
        private int IdConta { get; set; }
        private string Titular { get; set; }
        private double Saldo { get; set; }

        public void CriarConta(int idConta, string titular, double saldo, bool deposito)
        {
            IdConta = idConta;
            Titular = titular;
            if(deposito == true)
            {
                Saldo = saldo;
            }
            else
            {
                Saldo = 0.0;
            }
        }

        public void Deposito(double valor)
        {
            Saldo += valor;
        }

        public void Saque(double valor)
        {
            Saldo -= valor + 5.0;
        }

        public override string ToString()
        {
            return $"Conta: {IdConta}, Titular: {Titular}, Saldo: {Saldo}";
        }
        

        


    }
}
