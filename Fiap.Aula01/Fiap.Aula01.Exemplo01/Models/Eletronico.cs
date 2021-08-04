﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Fiap.Aula01.Exemplo01.Models
{
    class Eletronico : Produto
    {
        // Propriedades
        public string Marca { get; set; }
        public bool Garantia { get; set; }
        public double ConsumoEnergia { get; set; }

        //Construtores
        public Eletronico(string nome, string marca) : base(nome)
        {
            Marca = marca;
        }

        //Métodos
        //Sobrescrever (Override) -> mesmo método do pai implementado na classe filha
        //Modificar/Adicionar o comportamento (implementação)
        public override decimal CalcularDesconto()
        {
            //Modificar o comportamento do método do pai, realizando um desconto de 7%
            return Preco * 0.93m;
        }

        //Sobrescrever o método CalcularDesconto(cupom) adicionar o cupom FIAP30, com 30% de desconto
        public override decimal CalcularDesconto(string cupom)
        {
            if(cupom == "FIAP30")
            {
                return Preco * 0.7m;
            }
            return base.CalcularDesconto(cupom); //chamando o método CalcularDesconto(cupom) do Produto
        }


        public override void AtualizarPrecoComJuros(decimal juros)
        {
            //Atualizar o preço com o juros
            Preco += Preco * juros / 100;
        }

        public override string ToString()
        {
            return base.ToString() + $", Garantia: {Garantia}, Marca: {Marca}, Consumo: {ConsumoEnergia}";
        }
    }
}
