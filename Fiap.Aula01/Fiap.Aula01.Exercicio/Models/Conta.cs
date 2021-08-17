using System;
using System.Collections.Generic;
using System.Text;

namespace Fiap.Aula01.Exercicio.Models
{
    abstract class Conta
    {
        public int Agencia { get; set; }
        public int Numero { get; set; }
        public decimal Saldo { get; set; }
        public DateTime DataAbertura { get; set; }
        private IList<Cliente> _clientes;

        public Conta(int agencia, int numero, IList<Cliente> clientes)
        {
            Agencia = agencia;
            Numero = numero;
            _clientes = clientes;
        }

        public virtual void Depositar(decimal valor)
        {
            Saldo += valor;
        }

        public virtual void Retirar(decimal valor)
        {
            Saldo -= valor;
        }
    }
}
