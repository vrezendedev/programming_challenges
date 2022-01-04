using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafiojogodavelha
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, turno;
            string nome1, nome2;
            char[,] tabuleiro = new char[3, 3];
            bool ganhou;
            ganhou = false;
            Console.Write("Digite o nome do primeiro jogador (X): ");
            nome1 = Console.ReadLine();
            Console.Write("Digite o nome do segundo jogador (O): ");
            nome2 = Console.ReadLine();
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    tabuleiro[i, j] = '-';
                    Console.Write(" | " + tabuleiro[i, j]);
                }
                Console.Write(" |");
                Console.WriteLine(" ");
            }
            turno = 1;
            while (turno < 10 && ganhou == false)
            {
                i = j = 0;
                Console.WriteLine("Qual posição?");
                Console.Write("Digite a linha: ");
                i = int.Parse(Console.ReadLine());
                Console.Write("Digite a coluna: ");
                j = int.Parse(Console.ReadLine());
                i--;
                j--;
                if (tabuleiro[i, j] == '-')
                {
                    if (turno % 2 == 0)
                    {
                        tabuleiro[i, j] = 'O';
                        turno++;
                    }
                    else
                    {
                        tabuleiro[i, j] = 'X';
                        turno++;
                    }
                }
                else
                {
                    Console.WriteLine("Posição já preenchida");
                    Console.WriteLine("Escolha outra!");
                }
                for (i = 0; i < 3; i++)
                {
                    for (j = 0; j < 3; j++)
                    {
                        Console.Write(" | " + tabuleiro[i, j]);
                    }
                    Console.Write(" |");
                    Console.WriteLine(" ");
                }
                if (turno >= 3)
                {
                    //verifica se ganhou "horizontalmente"
                    for (i = 0; i < 3 && ganhou == false; i++)
                    {
                        for (j = 0; j < 1; j++)
                        {
                            if ((tabuleiro[i, j] == 'X' || tabuleiro[i, j]
                            == 'O') && tabuleiro[i, j] == tabuleiro[i, j + 1])
                            {
                                if (tabuleiro[i, j + 1] == tabuleiro[i, j +
                                2])
                                {
                                    ganhou = true;
                                    if (tabuleiro[i, j] == 'X')
                                    {
                                        Console.WriteLine("Jogador {0} venceu!", nome1);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Jogador {0} venceu!", nome2);
                                    }
                                }
                            }
                        }
                    }
                    //verifica se ganhou "verticalmente"
                    for (j = 0; j < 3 && ganhou == false; j++)
                    {
                        for (i = 0; i < 1; i++)
                        {
                            if ((tabuleiro[i, j] == 'X' || tabuleiro[i, j]
                            == 'O') && tabuleiro[i, j] == tabuleiro[i + 1, j])
                            {
                                if (tabuleiro[i + 1, j] == tabuleiro[i + 2,
                                j])
                                {
                                    ganhou = true;
                                    if (tabuleiro[i, j] == 'X')
                                    {
                                        Console.WriteLine("Jogador {0} venceu!", nome1);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Jogador {0} venceu!", nome2);
                                    }
                                }
                            }
                        }
                    }
                    i = j = 0;
                    //verifica se ganhou "diagonalmente" -->
                    if ((tabuleiro[i, j] == 'X' || tabuleiro[i, j] == 'O')
                    && tabuleiro[i, j] == tabuleiro[i + 1, j + 1])
                    {
                        if (tabuleiro[i + 1, j + 1] == tabuleiro[i + 2, j +
                        2])
                        {
                            ganhou = true;
                            if (tabuleiro[i, j] == 'X')
                            {
                                Console.WriteLine("Jogador {0} venceu!",
                                nome1);
                            }
                            else
                            {
                                Console.WriteLine("Jogador {0} venceu!",
                                nome2);
                            }
                        }
                    }
                    i = 0;
                    j = 2;
                    //verifica se ganhou "diagonalmente" < --
                    if ((tabuleiro[i, j] == 'X' || tabuleiro[i, j] == 'O')
                    && tabuleiro[i, j] == tabuleiro[i + 1, j - 1])
                    {
                        if (tabuleiro[i + 1, j - 1] == tabuleiro[i + 2, j -
                        2])
                        {
                            ganhou = true;
                            if (tabuleiro[i, j] == 'X')
                            {
                                Console.WriteLine("Jogador {0} venceu!",
                                nome1);
                            }
                            else
                            {
                                Console.WriteLine("Jogador {0} venceu!",
                                nome2);
                            }
                        }
                    }
                }
                Console.WriteLine("Pressione uma tecla para continuar.");
                Console.ReadKey();
            }
            if (turno == 10 && ganhou == false)
            {
                Console.WriteLine("Deu velha!");
            }
            Console.WriteLine("Pressione uma tecla para encerrar o jogo!");
            Console.ReadKey();
        }
    }
}

