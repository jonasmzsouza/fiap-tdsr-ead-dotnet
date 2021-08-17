using System;
using System.Collections.Generic;
using System.Text;

namespace Fiap.Aula01.Exemplo02.Models
{
    /**
     * Criar um Model Esporte com as propriedades Nome, Id, QtdCompetidores
     */
    class Esporte
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int QtdCompetidores { get; set; }

        //propriedade para armazenar o tipo de esporte
        public TipoEsporte Tipo { get; set; }

    }

    enum TipoEsporte
    {
        Individual, Coletivo, Dupla
    }
}
