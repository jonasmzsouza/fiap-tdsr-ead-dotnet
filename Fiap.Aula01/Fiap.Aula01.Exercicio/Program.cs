using Fiap.Aula01.Exercicio.Exceptions;
using Fiap.Aula01.Exercicio.Models;
using System;
using System.Collections.Generic;

namespace Fiap.Aula01.Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ler a quantidade de clientes
            Console.WriteLine("Digite a quantidade de clientes:");
            int qtd = int.Parse(Console.ReadLine());

            //Instanciar uma lista de clientes
            var clientes = new List<Cliente>();


            //Laço para ler os clientes e adicionar na lista
            for (int i = 0; i < qtd; i++)
            {
                //Ler os dados do cliente (Id, Nome, Cpf)
                Console.WriteLine("Digite o Id do cliente");
                var id = long.Parse(Console.ReadLine());

                Console.WriteLine("Digite o Nome do cliente");
                var nome = Console.ReadLine();

                Console.WriteLine("Digite o Cpf do cliente");
                var cpf = Console.ReadLine();

                //Instanciar um cliente com os dados
                var cliente = new Cliente(id, nome) { Cpf = cpf };

                //Adicionar o cliente na lista
                clientes.Add(cliente);
            }

            //Ler os dados da conta corrente (Agencia, Número, Data Abertura, Tipo)
            Console.WriteLine("Digite a Agencia da conta corrente");
            var agencia = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Numero da conta corrente");
            var numero = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a Data Abertura da conta corrente");
            var dataAbertura = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Digite o tipo da conta (comum, especial, premium)");
            var tipo = (TipoConta)Enum.Parse(typeof(TipoConta), Console.ReadLine(), true);

            //Instanciar uma conta corrente com os dados
            var conta = new ContaCorrente(agencia, numero, clientes, tipo) { DataAbertura = dataAbertura };

            //Exibir os dados da conta
            Console.WriteLine(conta);

            //Declarar uma variável para armazenar a escolha do usuario
            int opcao;

            do
            {
                //Menu com as opções 1-Depositar 2-Retirar 3-Exibir dados 0-Sair
                Console.WriteLine("Escolha: \n1-Depositar \n2-Retirar \n3-Exibir dados \n0-Sair");

                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        //1-Depositar
                        Console.WriteLine("Digite um valor para o deposito");
                        var valor = decimal.Parse(Console.ReadLine());
                        try
                        {
                            conta.Depositar(valor);
                            Console.WriteLine($"Valor depositado! Novo saldo {conta.Saldo}");
                        }
                        catch (ArgumentException e)
                        {

                            Console.WriteLine(e.Message);
                        }
                        break;
                    case 2:
                        //2-Retirar
                        Console.WriteLine("Digite um valor para o saque");
                        valor = decimal.Parse(Console.ReadLine());
                        try
                        {
                            conta.Retirar(valor);
                            Console.WriteLine($"Valor retirardo! Novo saldo {conta.Saldo}");
                        }
                        catch (SaldoInsuficienteException e)
                        {

                            Console.WriteLine(e.Message);
                        }
                        break;
                    case 3:
                        //3-Exibir dados
                        Console.WriteLine(conta.ToString());
                        break;
                    case 0:
                        Console.WriteLine("Finalizando o sistema");
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }

            } while (opcao != 0);

        }
    }
}
