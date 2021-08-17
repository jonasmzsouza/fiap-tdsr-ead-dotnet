using System;
using System.Collections.Generic;
using System.Text;

namespace Fiap.Aula01.Exercicio.Models
{
    class ContaCorrente : Conta
    {
        public TipoConta Tipo { get; set; }
        public decimal Limite { get; set; }

    }

    enum TipoConta
    {
        Comum, Especial, Premium
    }
}
