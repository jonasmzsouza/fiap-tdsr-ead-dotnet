using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Fiap.Aula03.Web.Exemplo01.Models
{
    [Table("Tbl_produtora")]
    public class Produtora
    {
        [Column("Id"), HiddenInput]
        public int ProdutoraId { get; set; }

        [Required, MaxLength(150)]
        public string Nome { get; set; }


    }
}
