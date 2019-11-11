using System;

namespace McBonaldsMVC.Models {
    public class Cliente {
        public string Nome { get; set; }
        public string Endereço { get; set; }
        public string Telefone { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }

        public Cliente () {

        }

        public Cliente (string nome, string endereço, string telefone, string senha, string email, DateTime dataNascimento) {
            this.Nome = nome;
            this.Endereço = endereço;
            this.Telefone = telefone;
            this.Senha = senha;
            this.Email = email;
            this.DataNascimento = dataNascimento;
        }
    }
}