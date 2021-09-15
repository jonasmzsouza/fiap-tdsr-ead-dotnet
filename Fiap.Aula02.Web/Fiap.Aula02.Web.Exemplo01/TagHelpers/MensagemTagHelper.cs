using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiap.Aula02.Web.Exemplo01.TagHelpers
{
    public class MensagemTagHelper : TagHelper
    {
        public string Texto { get; set; }

        //<mensagem texto=""></mensagem>
        //<div class="alert alert-success">

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            //Definir o nome da tag
            output.TagName = "div";
            //Definir o atributo class
            output.Attributes.SetAttribute("class", "alert alert-success");
            //Definir o conteúdo
            output.Content.SetContent(Texto);

            //Valida se o texto está vazio ou nulo
            if (string.IsNullOrEmpty(Texto))
            {
                output.Attributes.SetAttribute("hidden", ""); //Define a div oculta
            }

        }
    }
}
