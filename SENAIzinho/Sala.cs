using System;

namespace SENAIzinho {
    public class Sala {
        
        public int capacidadeAtual { get; set; }
        public int capacidadeTotal { get; set; } 
        public int numeroSala { get; set; }
        public string[] Alunos;
        public  Sala (int numeroSala, int capacidadeTotal) {
            this.numeroSala = numeroSala;
            this.capacidadeTotal = capacidadeTotal;
            this.capacidadeAtual = this.capacidadeAtual;
            this.Alunos = new string[capacidadeTotal];
        }
        public string AlocarAluno (string NomeAluno) {
            int index = 0;

            if (this.capacidadeAtual > 0) 
            {
                foreach (string aluno in this.Alunos)
                {
                    if (aluno == "")
                    {
                        this.Alunos[index] = NomeAluno;
                        break;
                    }
                    index++;
                }
                this.capacidadeAtual--;
                return "Ok";
            }else
            {
                return "CHEIAO";
            } 

        }
        public string RemoverAluno (string nomeAluno) {
            int index = 0;
            
            if (this.capacidadeAtual == this.capacidadeTotal)
            {
                return "Sala vazia";
            }
            foreach (string aluno in this.Alunos)
            {
                if (nomeAluno == aluno)
                {
                    this.Alunos[index] = "";
                    return "ok";
                }
                index ++;
            }
            return "Nao encontrado";
        }
        public string MostrarAlunos (string Nome) {
            string listaAlunos = "";
            foreach (string aluno in this.Alunos)
            {
                if (aluno != "")
                {
                    listaAlunos = listaAlunos + aluno + " ";
                }
            }
            listaAlunos.TrimEnd();
            return listaAlunos;

        }
    }
}