using System;
using McBanaldsMVC.Models;
using McBanaldsMVC.Repositories;
using McBanaldsMVC.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace McBanaldsMVC.Controllers
{
    public class PedidosController : Controller
    {
        HamburguerRepository hamburguerRepository = new HamburguerRepository();
        ShakeRepository shakeRepository = new ShakeRepository();
        
        public IActionResult Index()
        {
            
            PedidoViewModel pvm = new  PedidoViewModel();
            pvm.Hamburgueres = hamburguerRepository.ObterTodos();
            pvm.Shakes = shakeRepository.ObterTodos();

            return View(pvm);
            


            
        }

            
        


        public IActionResult Registrar(IFormCollection form)
        {
            ViewData["Action"] = "Pedido";
        try
        {
            PedidoRepository pedidoRepository = new PedidoRepository();
            
            Pedido pedido = new Pedido();
            
            var nomeShake = form["shake"];
            Shake shake = new Shake(
                nomeShake,
                shakeRepository.ObterPrecoDe(nomeShake)
            );
            

            pedido.Shake = shake;

            var nomeHamburguer = form["hamburguer"];
            Hamburguer hamburguer = new Hamburguer(
                nomeHamburguer,
            hamburguerRepository.ObterPrecoDe(nomeHamburguer));
            
            

            pedido.Hamburguer = hamburguer;

            Cliente cliente = new Cliente()
            {
            Nome = form["nome"],
            Endereco = form["endereco"],
            Telefone = form["telefone"],
            Email = form["email"],
            };

            pedido.Cliente = cliente;

            pedido.DataDoPedido = DateTime.Now;

            pedido.PrecoTotal = hamburguer.Preco + shake.Preco;

            pedidoRepository.Inserir(pedido);
            return View("Sucesso");
        } 
        catch (Exception e)
        {
            System.Console.WriteLine(e.StackTrace);
            return View("Erro");
            
        }
            
        }

        
    }
}