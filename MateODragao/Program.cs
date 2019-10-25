using System;
using MateODragao.Models;

namespace MateODragao
{
    class Program
    {
        static void Main(string[] args)



        {
            bool jogadorNaoDesistiu = true;
            do
            {

                Console.Clear();
                System.Console.WriteLine("==============================");
                System.Console.WriteLine("        Mate o Dragão!");
                System.Console.WriteLine("==============================");

                System.Console.WriteLine(" 1 - Iniciar Jogo.");
                System.Console.WriteLine(" 0 - Sair do Jogo.");

                string opçaoJogador = Console.ReadLine();

                switch (opçaoJogador)
                {
                    case "1":
                        Console.Clear();
                        Guerreiro guerreiro = CriarGuerreiro();

                        Dragao dragao = CriarDragao();


                        //INICIO - Primeiro Dialogo
                        CriarDialogo(guerreiro.Nome, $"{guerreiro.Nome.ToUpper()}: {dragao.Nome}, seu louco! Vim-lhe derrotar-lhe!!!");
                        CriarDialogo(dragao.Nome, $"{dragao.Nome.ToUpper()}: {guerreiro.Nome}, Voce É TOLO!!!!");

                        System.Console.WriteLine();
                        FinalizarDialogo();
                        Console.ReadLine();

                        

                        // FIM - 1° Dialogo

                        //INICIO - 2° Dialogo
                        CriarDialogo(guerreiro.Nome, $"{guerreiro.Nome.ToUpper()}: Eu sou {guerreiro.Nome}! Da casa {guerreiro.Sobrenome}, ó criatura miséjona");
                        CriarDialogo(guerreiro.Nome, $"{guerreiro.Nome.ToUpper()}: Vim de {guerreiro.CidadeNatal} para te derrotar otario ");
                        CriarDialogo(guerreiro.Nome, $"{dragao.Nome.ToUpper()}: QUEM? DE ONDE?. Bom se é morrer que voce quer ");
                        CriarDialogo(guerreiro.Nome, "Alberto: Claudia vai pra cima!");
                        System.Console.WriteLine();
                        FinalizarDialogo();
                        Console.ReadLine();
                        //FINAL - 2° Dialogo

                        Console.Clear();

                        bool jogadorAtacaPrimeiro = guerreiro.Destreza > dragao.Destreza ? true : false;

                        int poderAtaqueGuerreiro = guerreiro.Força > guerreiro.Inteligencia ? guerreiro.Força + guerreiro.Destreza : guerreiro.Inteligencia + guerreiro.Destreza;

                        bool jogadorNaoCorreu = true;

                        if (jogadorAtacaPrimeiro)
                        {
                            System.Console.WriteLine("****Turno do Jogador****");
                            System.Console.WriteLine("Escolha uma ação: ");
                            System.Console.WriteLine(" 1 - Atacar");
                            System.Console.WriteLine(" 2 - Fugir");

                            string opcaoBatalhaJogador = Console.ReadLine();

                            switch (opcaoBatalhaJogador)
                            {
                                case "1":
                                    Random geradorNumeroAleatorio = new Random();
                                    int numeroAleatorioJogador = geradorNumeroAleatorio.Next(0, 5);
                                    int numeroAleatorioDragao = geradorNumeroAleatorio.Next(0, 5);
                                    int guerreiroDestrezaTotal = guerreiro.Destreza + numeroAleatorioJogador;
                                    int dragaoDestrezaTotal = dragao.Destreza + numeroAleatorioDragao;

                                    if (guerreiroDestrezaTotal > dragaoDestrezaTotal)
                                    {
                                        CriarDialogo(guerreiro.Nome,$"{guerreiro.Nome.ToUpper()}: Vai otario, cai pra dentro!!!");
                                        dragao.Vida -= poderAtaqueGuerreiro + 5;
                                        System.Console.WriteLine($"HP Dragão: {dragao.Vida}");
                                        System.Console.WriteLine($"HP Guerreiro: {guerreiro.Vida}");
                                    }
                                    else
                                    {
                                        System.Console.WriteLine($"{dragao.Nome.ToUpper()}: Errou lixo! ");
                                    }
                                    break;
                                case "2":
                                    CriarDialogo(guerreiro.Nome,$"{guerreiro.Nome.ToUpper()}: To com diarreia, ja volto!");
                                    CriarDialogo(dragao.Nome,$"{dragao.Nome.ToUpper()}: Va pela sombra !!");
                                    jogadorNaoCorreu = false;
                                    break;
                            }

                        }
                        System.Console.WriteLine();
                        FinalizarDialogo();
                        Console.ReadLine();


                        while (guerreiro.Vida > 0 && dragao.Vida > 0 && jogadorNaoCorreu)
                        {

                            Console.Clear();
                            System.Console.WriteLine("*** Turno Dragão ***");
                            Random geradorNumeroAleatorio = new Random();
                            int numeroAleatorioJogador = geradorNumeroAleatorio.Next(0, 5);
                            int numeroAleatorioDragao = geradorNumeroAleatorio.Next(0, 5);
                            int guerreiroDestrezaTotal = guerreiro.Destreza + numeroAleatorioJogador;
                            int dragaoDestrezaTotal = dragao.Destreza + numeroAleatorioDragao;


                            if (guerreiroDestrezaTotal > dragaoDestrezaTotal)
                            {
                                CriarDialogo(dragao.Nome,$"{dragao.Nome.ToUpper()}: Ta pegando fogo bichoo!!!!");
                                guerreiro.Vida = guerreiro.Vida - dragao.Força;
                                System.Console.WriteLine($"HP Dragão: {dragao.Vida}");
                                System.Console.WriteLine($"HP Guerreiro: {guerreiro.Vida}");
                            }
                            else
                            {
                                CriarDialogo(guerreiro.Nome,$"{guerreiro.Nome.ToUpper()}: erouuuuuu!! ");
                            }

                            System.Console.WriteLine();
                            FinalizarDialogo();
                            Console.ReadLine();

                            Console.Clear();

                            System.Console.WriteLine("****Turno do Jogador****");
                            System.Console.WriteLine("Escolha uma ação: ");
                            System.Console.WriteLine(" 1 - Atacar");
                            System.Console.WriteLine(" 2 - Fugir");

                            string opcaoBatalhaJogador = Console.ReadLine();

                            switch (opcaoBatalhaJogador)
                            {
                                case "1":
                                    geradorNumeroAleatorio = new Random();
                                    numeroAleatorioJogador = geradorNumeroAleatorio.Next(0, 5);
                                    numeroAleatorioDragao = geradorNumeroAleatorio.Next(0, 5);
                                    guerreiroDestrezaTotal = guerreiro.Destreza + numeroAleatorioJogador;
                                    dragaoDestrezaTotal = dragao.Destreza + numeroAleatorioDragao;

                                    if (guerreiroDestrezaTotal > dragaoDestrezaTotal)
                                    {
                                        System.Console.WriteLine($"{guerreiro.Nome.ToUpper()}: Vai otario, cai pra dentro!!!");
                                        dragao.Vida -= poderAtaqueGuerreiro + 5;
                                        System.Console.WriteLine($"HP Dragão: {dragao.Vida}");
                                        System.Console.WriteLine($"HP Guerreiro: {guerreiro.Vida}");
                                    }
                                    else
                                    {
                                        System.Console.WriteLine($"{dragao.Nome.ToUpper()}: Errou lixo! ");
                                    }
                                    break;
                                case "2":
                                    System.Console.WriteLine($"{guerreiro.Nome.ToUpper()}: To com vontade de caga, flww!");
                                    System.Console.WriteLine($"{dragao.Nome.ToUpper()}: Va pela sombra !!");
                                    jogadorNaoCorreu = false;
                                    break;
                            }
                            System.Console.WriteLine();
                            FinalizarDialogo();
                            Console.ReadLine();

                            Console.Clear();

                        }

                        if (guerreiro.Vida <= 0)
                        {
                            System.Console.WriteLine("Você perdeu!");
                        }
                        if (dragao.Vida <= 0)
                        {
                            System.Console.WriteLine("Você venceu!!!!");
                        }




                        break;
                    case "0":
                        jogadorNaoDesistiu = false;
                        System.Console.WriteLine("GAME OVER!!!!!!");
                        break;
                    default:
                        System.Console.WriteLine("Comando Invalido!");
                        break;
                }
            } while (jogadorNaoDesistiu);



        }

        public static void CriarDialogo(string nome, string frase)
        {

            System.Console.WriteLine($"{nome.ToUpper()}:{frase}");
        }

        public static void FinalizarDialogo()
        {
            System.Console.WriteLine();
            System.Console.WriteLine("Aperte enter para prosseguir");
            Console.ReadLine();
            Console.Clear();
        }

        public static Guerreiro CriarGuerreiro()
        {
            Guerreiro guerreiro = new Guerreiro();
            guerreiro.Nome = "Claudia";
            guerreiro.Sobrenome = "Haia";
            guerreiro.CidadeNatal = "Iga - Japão";
            guerreiro.DataNascimento = DateTime.Parse("19/12/1498");
            guerreiro.FerramentaAtaque = "Foices Congelantes";
            guerreiro.FerramentaProteçao = "Armadura anti elementos";
            guerreiro.Força = 2;
            guerreiro.Destreza = 3;
            guerreiro.Inteligencia = 3;
            guerreiro.Vida = 20;

            return guerreiro;
        }

        public static Dragao CriarDragao()
        {
            Dragao dragao = new Dragao();
            dragao.Nome = "Lombarto";
            dragao.Força = 5;
            dragao.Destreza = 1;
            dragao.Inteligencia = 3;
            dragao.Vida = 300;

            return dragao;
        }

    }
}
