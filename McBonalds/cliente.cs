 using System;

namespace McBonalds
{
    public class cliente
    {
    public string Nome; //Nome do cliente
    public string Endereço; //Endereço do cliente
    public string Telefone;//Telefone o Cliente
    public string Senha; //Senha de acesso do cliente e do usuario 
    public string Email;
    public DateTime DataNascimento;

    //Construtores
    public cliente(string Nome, string Telefone, string Email){
        this.Nome = Nome;
        this.Telefone = Telefone;
        this.Email = Email;
    }
     

    }
}