using System;
using System.Collections.Generic;

namespace Fiap.Aula01.Exercicio.Models
{
    abstract class Conta
    {
        public int Agencia { get; set; }
        public int Numero { get; set; }
        public decimal Saldo { get; protected set; }
        public DateTime DataAbertura { get; set; }
        public IList<Cliente> Clientes { get; set; }

        public Conta(int agencia, int numero, IList<Cliente> clientes)
        {
            Agencia = agencia;
            Numero = numero;
            Clientes = clientes;
        }

        public void Depositar(decimal valor)
        {
            if (valor < 0)
            {
                throw new ArgumentException("O valor deve ser maior do que zero");
            }
        }

        public override string ToString()
        {
            var aux = "";
            foreach(var item in Clientes)
            {
                aux += item + "\n";
            }
            return $"{aux}\nAgência: {Agencia}, Número: {Numero}, Saldo: {Saldo}, Data de Abertura: {DataAbertura}";
        }

        public abstract void Retirar(decimal valor);

    }
}
