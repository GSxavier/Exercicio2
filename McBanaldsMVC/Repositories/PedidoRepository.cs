using System;
using System.Collections.Generic;
using System.IO;
using McBanaldsMVC.Models;

namespace McBanaldsMVC.Repositories
{
    public class PedidoRepository : RepositoryBase
    {
        private const string PATH = "Database/Pedido.csv";

        public PedidoRepository()
        {
            if (!File.Exists(PATH))
            {
                File.Create(PATH).Close();
            }
        }

        public bool Inserir(Pedido pedido)
        {
            var linha = new string[]{PrepararRegistroCSV(pedido)};
            File.AppendAllLines(PATH, linha);

            return true; 
        }
        public List<Pedido> ObterTodosPorCliente(string emailCliente)
        {
            var pedidos = ObterTodos();
            List<Pedido> pedidosCliente = new List<Pedido>();

            foreach (var pedido in pedidos)
            {
                if (pedido.Cliente.Email.Equals(emailCliente))
                {
                    pedidosCliente.Add(pedido);
                }
            }
                return pedidosCliente;
        }
        
        public List<Pedido> ObterTodos()
        {
            var linhas = File.ReadAllLines(PATH);
            List<Pedido> pedidos = new List<Pedido>();
            foreach (var linha in linhas)
            {
                Pedido pedido = new Pedido();
                pedido.Cliente.Nome = ExtrairValorDoCampo("cliente_nome", linha);
                pedido.Cliente.Endereco = ExtrairValorDoCampo("cliente_endereco", linha);
                pedido.Cliente.Telefone = ExtrairValorDoCampo("cliente_telefone", linha);
                pedido.Cliente.Email = ExtrairValorDoCampo("cliente_email", linha);
                pedido.Hamburguer.Nome = ExtrairValorDoCampo("Hamburguer_nome", linha);
                pedido.Hamburguer.Preco = double.Parse(ExtrairValorDoCampo("Hamburguer_preco", linha));
                pedido.Shake.Nome = ExtrairValorDoCampo("Shake_nome", linha);
                pedido.Shake.Preco = double.Parse(ExtrairValorDoCampo("Shake_preco", linha));
                pedido.PrecoTotal= double.Parse(ExtrairValorDoCampo("preco_total", linha));
                pedido.DataDoPedido= DateTime.Parse(ExtrairValorDoCampo("data_pedido4/", linha));

                pedidos.Add(pedido);
            }
            return pedidos;
        }

        


        

        private string PrepararRegistroCSV(Pedido pedido)
        {
            Cliente c = pedido.Cliente;
            Hamburguer h = pedido.Hamburguer;
            Shake s = pedido.Shake;

            return $"cliente_nome={c.Nome}; cliente_endereço={c.Endereco};cliente_telefone={c.Telefone};cliente_email={c.Email}; hambuerguer_nome={h.Nome}; hamburguer_preco={h.Preco}; shake_nome={s.Nome}; shake_preco={s.Preco}; data_pedido={pedido.DataDoPedido}; preco_total={pedido.PrecoTotal}";
        }
    }
}