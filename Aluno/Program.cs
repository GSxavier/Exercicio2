using System;

namespace Aluno
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno1 = new Aluno("Gustavo","Desenvolvimento de Sistemas", "498.013.328-24",);
            Console.WriteLine("Nome:" + aluno1.nome);
            Console.WriteLine("Curso:" + aluno1.curso);
            Console.WriteLine("CPF:" + aluno1.cpf);

            Aluno aluno2 = new Aluno("Otavio", "498.013.328-24","...");
            Console.WriteLine("Nome: " + aluno2.nome);
            Console.WriteLine("CPF: " + aluno2.cpf);
            Console.WriteLine("Curso: " + aluno2.curso);

            Console.Write("Entre com o Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Entre com o CPF: ");
            string cpf = Console.ReadLine();
            Console.Write("Entre com o Curso: ");
            string curso = Console.ReadLine();
            Console.Write("Entre com o Nota: ");
            int nota = int.Parse(Console.ReadLine());
            int bimestra = int.Parse(Console.ReadLine());
            Aluno aluno3 = new Aluno(nome,cpf,curso);
            aluno3.setNotas(bimestre,nota);

            Console.WriteLine("Nome: " + aluno3.nome);
            Console.WriteLine("Nome: " + aluno3.cpf);
            Console.WriteLine("Nome: " + aluno3.curso);
            Console.WriteLine("Notas: ");
            forreach(int n in aluno3.getNotas()){
                Console.Write();
            }
        }
        Console.WriteLine();
    }
}
