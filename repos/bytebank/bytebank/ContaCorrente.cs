using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank
{
    public class ContaCorrente
    {
        public int numero_agencia;
        public string conta;
        public Cliente? titular;
        public double saldo;

        const string VALOR_INDISPONIVEL_PARA_SAQUE = "Valor indisponível para saque, tente outro.";
        const string VALOR_INDISPONIVEL_PARA_TRASNFERENCIA = "Valor indisponível para trasnferência, tente outro.";

        public void Deposit(double value)
        {
            this.saldo += value;
        }

        public void Withdraw(double amount)
        {
            this.ValidateIfAmmountIsValid(amount, VALOR_INDISPONIVEL_PARA_SAQUE);
            saldo -= amount;
        }

        public bool Transfer(double amount, ContaCorrente account)
        {
            this.ValidateIfAmmountIsValid(amount, VALOR_INDISPONIVEL_PARA_TRASNFERENCIA);


            account.saldo += amount;
            this.Withdraw(amount);
            return true;
        }

        internal void ValidateIfAmmountIsValid(double amount, string message)
        {
            if (amount > this.saldo)
            {
                throw new Exception(message);
            }
        }
    }
}
