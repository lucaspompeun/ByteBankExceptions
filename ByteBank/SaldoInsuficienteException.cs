using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class SaldoInsuficienteException : OperacaoFinanceiraException
    {
        public double Saldo { get; }
        public double ValorSaque { get; }

        public SaldoInsuficienteException()
        {

        }

        public SaldoInsuficienteException(double saldo, double valorSaque) 
            : this($"Tentativa de saque no valor de {valorSaque} em uma conta com saldo de {saldo}")
        {
            this.Saldo = saldo;
            this.ValorSaque = valorSaque;
        }

        public SaldoInsuficienteException(string mensagem) 
            : base(mensagem)
        {

        }

        public SaldoInsuficienteException(string mensagem, Exception innerException) 
            : base(mensagem, innerException)
        {

        }
    }
}
