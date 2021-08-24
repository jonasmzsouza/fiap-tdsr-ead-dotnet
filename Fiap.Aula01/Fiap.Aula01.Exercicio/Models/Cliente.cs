namespace Fiap.Aula01.Exercicio.Models
{
    public class Cliente
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }

        public Cliente(long id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Cliente: {Nome}, Cpf: {Cpf}";
        }
    }
}