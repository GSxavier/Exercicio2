using System;
using System.IO;
using McBonaldsMVC.Models;

namespace McBonaldsMVC.Repositories
{
    public class ClienteRepository
    {
        private const string PATH = "Database/Cliente.csv";

        public ClienteRepository()
        {
            if (!File.Exists(PATH))
            {
                File.Create(PATH).Close();
            }
        }

        public bool Inserir(Cliente cliente)
        {
            var linha = new string[] { PrepararRegistroCSV(cliente) };
            File.AppendAllLines(PATH, linha);

            return true;
        }
        public Cliente ObtePor(string email)
        {
            var linha = File.ReadAllLines(PATH);
            foreach (var item in linhas)
            {
                if (ExtrairValorDoCampo("email", item).Equals(email))
                {
                    Cliente c = new Cliente();
                    c.Nome = ExtrairValorCampo("nome", item);
                    c.Email = ExtrairValorCampo("email", item);
                    c.DataNascimento =  DateTime.Parse(ExtrairValorCampo("data_nascimento", item));
                    c.Endereco = ExtrairValorCampo("endereco", item);
                    
                    


                }
            }

        }

        private string ExtrairValorCampo(string nomeCampo, string linha)
        {
            var chave = nomeCampo;
            var indiceChave = linha.IndexOf(chave);

            var indiceTerminal = linha.IndexOf(";", indiceChave);

            var valor = "";
            if (indiceTerminnal != -1)
            {
                valor = linha.Substring(indiceChave, indiceTerminal - indiceChave);
            }
            else
            {
                valor = linha.Substring(indiceChave);
            }
            System.Console.WriteLine($"Campo {nomeCampo} e valor {valor}");
            return valor.Replace(nomeCampo + "=", "");
        }
        private string PrepararRegistroCSV(Cliente cliente)
        {
            return $"nome={cliente.Nome};email={cliente.Email};senha={cliente.Senha};endereco={cliente.Endereco};telefone={cliente.Telefone};data_nascimento={cliente.DataNascimento} ";
        }
    }
}