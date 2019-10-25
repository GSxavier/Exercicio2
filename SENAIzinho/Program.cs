using System;

namespace SENAIzinho
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int LimiteAlunos = 10;
            int LimiteSalas = 10;
            aluno[] alunos = new aluno[100];
            Sala[] salas = new Sala[10];
            int alunosCadastrados = 0;
            int salasCadastradas = 0;
            //bool querSair;
        }
            public void CadastrarAluno(aluno[] alunos, int totalAluno, int alunosCadastrados){
                if(totalAluno < alunosCadastrados){
                    System.Console.WriteLine("Cadastro alunos: ");
                    System.Console.WriteLine();
                    System.Console.WriteLine("Nome: ");
                    string nome = Console.ReadLine();
                    DateTime dtNascimento  = DateTime.Parse(Console.ReadLine());

                    aluno novoAluno = new aluno();
                    novoAluno.Nome = nome;
                    novoAluno.DataNascimento = dtNascimento;

                    int index = 0;
                    foreach (aluno Aluno in alunos)
                    {
                        if (alunos == null)
                        {
                            alunos[index] = novoAluno;
                            break;
                        }
                        index++;
                    }
                    alunosCadastrados++;
                    
                }
                    
                }
            }
            public void CadastrarSala(){

            }
            public void AlocarAluno(){

            }
            public void RemoverAluno(){

            }
            public void VerificarSalas(){

            }
            public void VerificarAlunos(){

            }
        }
    }
}
