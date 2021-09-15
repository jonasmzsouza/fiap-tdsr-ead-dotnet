using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiap.Aula02.Web.Exemplo01.TagHelpers
{
    public class BotaoTagHelper : TagHelper
    {
        public string Texto { get; set; }
        public string Class { get; set; }

        //<botao texto="" class=""></botao>
        //<input type="submit" value="Cadastrar" class="btn btn-outline-primary" />

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            //Definir o nome da tag
            output.TagName = "input";
            //Definir os atributos type, value e class
            output.Attributes.SetAttribute("type", "submit");
            if (string.IsNullOrEmpty(Texto))
                output.Attributes.SetAttribute("value", "Cadastrar");
            else
                output.Attributes.SetAttribute("value", Texto);
            
            //Ternário
            output.Attributes.SetAttribute("class", string.IsNullOrEmpty(Texto)? "btn btn-success" : Class);
        }
    }
}
