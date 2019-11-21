using Microsoft.AspNetCore.Http;
using System;
using Microsoft.AspNetCore.Mvc;
using McBanaldsMVC.Repositories;
using McBanaldsMVC.ViewModels;

namespace McBanaldsMVC.Controllers
{
    public class ClienteController : Controller
    {
        private const string  SESSION_CLIENTE_EMAIL = "cliente_email";
        private ClienteRepository clienteRepository = new ClienteRepository();
        private PedidoRepository pedidoRepository = new PedidoRepository();
        [HttpGet]
        public IActionResult Login()
        {
            
            return View();
        }
        [HttpPost]

        public IActionResult Login(IFormCollection form)
        {
            ViewData["Action"] = "Login";
            try
            {
                System.Console.WriteLine("================================");
                System.Console.WriteLine(form["email"]);
                System.Console.WriteLine(form["senha"]);
                System.Console.WriteLine("================================");

                var usuario = form["email"];
                var senha = form["senha"];

                var cliente = clienteRepository.ObterPor(usuario);

                if (cliente != null)
                {
                    if (cliente.Senha.Equals(senha))
                    {
                        HttpContext.Session.SetString(SESSION_CLIENTE_EMAIL, usuario);
                        return RedirectToAction("Historico", "Cliente");
                    }
                    else
                    {
                        return View("Erro", new RespostaViewModel("Senha Incorreta"));
                    }
                }
                else
                {
                    return View("Erro", new RespostaViewModel($"Usuario {usuario} não encontrado!"));
                }

                
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.StackTrace);
                return View("Erro");
                
            }
        }
    
        public IActionResult Historico()
        {
            var emailCliente = HttpContext.Session.GetString("SESSION_CLIENTE_EMAIL");
            var pedidosCliente = pedidoRepository.ObterTodosPorCliente(emailCliente);

            return View(new HistoricoViewModel()
            {
                Pedidos = pedidosCliente
            });
        }
    }
}