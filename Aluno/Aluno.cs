 using System;


namespace Aluno
{
    public class Aluno
    {
        //Propiedades
        public string nome{get;set;}
        public string curso{get;set;}
        public string cpf{get;set;}
        public int[] notas;

        //Contrutor
        public Aluno(string nome, string cpf, string curso){
            this.nome = nome;
            this.cpf = cpf;
            this.curso = curso;
        }
        public Aluno(string nome, string cpf){
            this.nome = nome;
            this.cpf = cpf;
            this.curso = curso;
         }

         //Metodos de Acessos
         public int[] getNotas(),{return notas;}

         public void setNotas(int bi, int notma){
             int i = bi - 1;
             if((i < 0) || (i > 3)){
                 //Condição de erro
                 throw new ArgumentOutOfRançgeException($"{nameof()}")
             }
         }
    }
}