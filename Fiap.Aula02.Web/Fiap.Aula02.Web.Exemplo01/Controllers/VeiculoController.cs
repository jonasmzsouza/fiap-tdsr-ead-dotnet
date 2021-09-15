using Fiap.Aula02.Web.Exemplo01.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiap.Aula02.Web.Exemplo01.Controllers
{
    public class VeiculoController : Controller
    {
        // Armazenar os veículos cadastrados, simular um DB
        private static List<Veiculo> _banco = new List<Veiculo>();

        // Aributo que armazena o di do veiculo
        private static int id;

        [HttpPost]
        public IActionResult Remover(int id)
        {
            //Remover o veículo da lista
            _banco.RemoveAt(_banco.FindIndex(v => v.Id == id));
            //Mensagem de sucesso
            TempData["msg"] = "Veículo removido!";
            //Redirect para a listagem
            return RedirectToAction("Index");
        }

        [HttpPost] //Recebe os dados do fomulário e atualiza o veículo na lista
        public IActionResult Editar(Veiculo veiculo)
        {
            //Atualizar o veicullo na lista
            _banco[_banco.FindIndex(v => v.Id == veiculo.Id)] = veiculo;
            //Mensagem de sucesso
            TempData["msg"] = "Veículo atualizado!";
            //Redirecionar para a listagem
            return RedirectToAction("Index");
        }

        //URL: /veiculo/editar/id
        [HttpGet] //Abrir a página de edição com o fomulário HTML preenchido
        public IActionResult Editar(int id)
        {
            //Carregar as opções de cores do select
            CarregarCores();
            //Pesquisar o veiculo pelo id
            var veiculo = _banco.Find(v => v.Id == id);
            //Enviar o veículo para a view
            return View(veiculo);
        }

        private void CarregarCores()
        {
            //Carregar as opções de cores do select
            var lista = new List<string>(new string[] { "Prata", "Preto", "Vermelho", "Azul Metálico", "Branco" });
            ViewBag.cores = new SelectList(lista);
        }

        //URL: /veiculo/index ou /veciulo
        public IActionResult Index()
        {
            // Enviar a lista para  a view
            return View(_banco);
        }

        //URL: /veiculo/cadastrar
        [HttpGet] //Abrir a página com o fomulário HTML
        public IActionResult Cadastrar()
        {
            //Carregar as opções de cores do select
            CarregarCores();
            return View();
        }

        [HttpPost] // Recupera os dados do formulário e adicionar na lista
        public IActionResult Cadastrar(Veiculo veiculo)
        {
            // Setar o Id do veiculo
            veiculo.Id = ++id;
            // Adicionar o veiculo na lista
            _banco.Add(veiculo);
            // Mensagem de sucesso
            TempData["msg"] = "Veículo cadastrado";
            // Redirect
            return RedirectToAction("cadastrar");
        }
    }
}
