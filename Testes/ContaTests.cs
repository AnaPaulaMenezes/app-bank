using DIO.Bank;
using System;
using Xunit;

namespace Testes
{
    public class ContaTests
    {
        [Fact]
        public void CriarConta()
        {
            double Saldo = 500;
            double Credito = 100;
            string Nome = "Conta teste";

            Conta conta = new Conta(TipoConta.PessoaFisica, Saldo, Credito, Nome);

            Assert.NotNull(conta.Nome);
        }

        [Fact]
        public void Depositar()
        {
            double Saldo = 500;
            double Credito = 100;
            string Nome = "Conta teste";

            Conta conta = new Conta(TipoConta.PessoaFisica, Saldo, Credito, Nome);

            conta.Depositar(500);
;
            Assert.Equal(1000,conta.Saldo);
        }

        [Fact]
        public void Sacar()
        {
            double Saldo = 500;
            double Credito = 100;
            string Nome = "Conta teste";

            Conta conta = new Conta(TipoConta.PessoaFisica, Saldo, Credito, Nome);

            Assert.True(conta.Sacar(350));
        }

        [Fact]
        public void SacarValorMaiorSaldo()
        {
            double Saldo = 500;
            double Credito = 100;
            string Nome = "Conta teste";

            Conta conta = new Conta(TipoConta.PessoaFisica, Saldo, Credito, Nome);

            Assert.False(conta.Sacar(601));
        }

        [Fact]
        public void Transferir()
        {
            double Saldo = 500;
            double Credito = 100;
            string Nome = "Conta teste";
           
            double Saldo2 = 100;
            double Credito2 = 0;
            string Nome2 = "Conta teste 2";

            Conta conta1 = new Conta(TipoConta.PessoaJuridica, Saldo, Credito, Nome);
            Conta conta2 = new Conta(TipoConta.PessoaFisica, Saldo2, Credito2, Nome2);

            conta1.Transferir(200, conta2);

            Assert.Equal(300, conta2.Saldo);
        }
    }
}