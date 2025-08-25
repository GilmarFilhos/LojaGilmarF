using Microsoft.AspNetCore.Mvc;
using LojaGilmarF.Models;   // ajuste conforme sua pasta Models
using System.Collections.Generic; // necessário para List<>

namespace LojaGilmarF.Controllers
{
    public class ProdutoController : Controller
    {
        public IActionResult Index()
        {
            var produtos = new List<Produto>
            {
                new Produto { Id = 1, Nome = "Camisa de algodão", Descricao = "Camisa Confortável", Preco = 4.00m, ImagemUrl ="/imagem/1.png" },
                new Produto { Id = 2, Nome = "Camisa De Polo", Descricao = "Camisa Confortável", Preco = 3.00m },
                new Produto { Id = 3, Nome = "Sapato Colorido", Descricao = "Tênis Confortável", Preco = 50.00m },
                new Produto { Id = 4, Nome = "Sapato Dourado", Descricao = "Sapato raro", Preco = 12.00m}

            };



            return View(produtos);
        }
    }
}


