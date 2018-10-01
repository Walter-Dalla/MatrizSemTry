using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Matriz
{
    class Program
    {


        //feito por Walter Dalla Torre 17254
        //e
        //Joao Henrique correia Lima 17sla
        static void Main(string[] args)
        {
            Menu();//chama a funçao menu

            Console.ReadKey();
        }

        //=========================== menus ===============================================
        static void Menu()
        {
            int[,] a =
            {
                {1, 3, 0},
                {2, 5 , 0},
                {-4 , 0 , 0}
            };

            int[,] b =
            {
                {3, 1, 2},
                {1, 4, 3},
                {2, 3, 5}
            };

            int[,] c;

            //declaraçao da variavel de opçoes
            int opcao = 6;
            int erro = 0;
            do
            {
                c = null;

                Console.WriteLine("Digite o numero do exercicio que voce quer ver");
                Console.WriteLine("Exercicio 1) Soma de matrizes");
                Console.WriteLine("Exercicio 2) Multiplicaçao de matrizes");
                Console.WriteLine("Exercicio 3) Transposiçao de matrizes");
                Console.WriteLine("Exercicio 4) Simétria de matrizes");
                Console.WriteLine("Exercicio 5) Matriz quadara ou \"quadrado magico\"");
                Console.WriteLine("Sair 6)");


                do
                {
                    try
                    {
                        opcao = int.Parse(Console.ReadLine());//le a opcao
                        erro = 0;
                    }
                    catch (FormatException )
                    {
                        Console.WriteLine("Entrada de dados invalida, Digite um numero!");
                        erro = 1;
                    }
                } while ((opcao < 1) || (opcao > 6)||(erro != 0));//só sai do laço se a opçao for valida

                switch (opcao)
                {
                    //------------------------------------------------------------------ Case 1 --------------------------------------------------------------------------//
                    case 1:
                        if ((a.GetLength(0) == b.GetLength(0)) && (a.GetLength(1) == b.GetLength(0)))
                        {
                            c = soma_matriz_int(a, b);

                            //poderia criar um metodo para exibir matriz, porem o exercicio nao pede isto
                            Console.WriteLine("matriz A:");
                            for (int linha = 0; linha < a.GetLength(0); linha++)
                            {
                                for (int coluna = 0; coluna < a.GetLength(1); coluna++)
                                {
                                    Console.Write("\t{0:d5}|", a[linha, coluna]);//exibir certa posiçao da matriz na tela

                                }
                                Console.WriteLine("");//pular a linha quando acabar a linha da matriz
                            }

                            Console.WriteLine("matriz B:");
                            for (int linha = 0; linha < b.GetLength(0); linha++)
                            {
                                for (int coluna = 0; coluna < b.GetLength(1); coluna++)
                                {
                                    Console.Write("\t{0:d5}|", b[linha, coluna]);//exibir certa posiçao da matriz na tela

                                }
                                Console.WriteLine("");//pular a linha quando acabar a linha da matriz
                            }

                            Console.WriteLine("matriz soma de A e B:");
                            for (int linha = 0; linha < c.GetLength(0); linha++)
                            {
                                for (int coluna = 0; coluna < c.GetLength(1); coluna++)
                                {
                                    Console.Write("\t{0:d5}|", c[linha, coluna]);//exibir certa posiçao da matriz na tela

                                }
                                Console.WriteLine("");//pular a linha quando acabar a linha da matriz
                            }
                        }
                        else
                            Console.WriteLine("Nao é possivel somar essas matrizes!");
                        break;

                    //------------------------------------------------------------------ Case 2 --------------------------------------------------------------------------//
                    case 2:
                        if ((a.GetLength(1) == b.GetLength(0)))
                        {
                            c = produto_matriz_int(a, b);
                            Console.WriteLine("matriz A:");
                            for (int linha = 0; linha < a.GetLength(0); linha++)
                            {
                                for (int coluna = 0; coluna < a.GetLength(1); coluna++)
                                {
                                    Console.Write("\t{0:d5}|", a[linha, coluna]);//exibir certa posiçao da matriz na tela

                                }
                                Console.WriteLine("");//pular a linha quando acabar a linha da matriz
                            }

                            Console.WriteLine("matriz B:");
                            for (int linha = 0; linha < b.GetLength(0); linha++)
                            {
                                for (int coluna = 0; coluna < b.GetLength(1); coluna++)
                                {
                                    Console.Write("\t{0:d5}|", b[linha, coluna]);//exibir certa posiçao da matriz na tela

                                }
                                Console.WriteLine("");//pular a linha quando acabar a linha da matriz
                            }

                            Console.WriteLine("matriz da multiplicaçao de A e B:");
                            for (int linha = 0; linha < c.GetLength(0); linha++)
                            {
                                for (int coluna = 0; coluna < c.GetLength(1); coluna++)
                                {
                                    Console.Write("\t{0:d5}|", c[linha, coluna]);//exibir certa posiçao da matriz na tela

                                }
                                Console.WriteLine("");//pular a linha quando acabar a linha da matriz
                            }
                        }
                        else
                            Console.WriteLine("Nao é possivel multiplicar essas matrizes!");
                        break;
                    //------------------------------------------------------------------ Case 3 --------------------------------------------------------------------------//
                    case 3:
                        Console.WriteLine("A matriz transposta de a matriz A {");
                        for (int linha = 0; linha < a.GetLength(0); linha++)
                        {
                            for (int coluna = 0; coluna < a.GetLength(1); coluna++)
                            {
                                Console.Write("\t{0:d5}|", a[linha, coluna]);//exibir certa posiçao da matriz na tela

                            }
                            Console.WriteLine("");//pular a linha quando acabar a linha da matriz
                        }
                        Console.WriteLine("} \né a seguinte matriz:");
                        c = transposta_matriz_int(a);
                        for (int linha = 0; linha < c.GetLength(0); linha++)
                        {
                            for (int coluna = 0; coluna < c.GetLength(1); coluna++)
                            {
                                Console.Write("\t{0:d5}|", c[linha, coluna]);//exibir certa posiçao da matriz na tela

                            }
                            Console.WriteLine("");//pular a linha quando acabar a linha da matriz
                        }
                        break;

                    //------------------------------------------------------------------ Case 4 --------------------------------------------------------------------------//
                    case 4:
                        if (b.GetLength(0) == b.GetLength(1))
                        {
                            for (int linha = 0; linha < b.GetLength(0); linha++)
                            {
                                for (int coluna = 0; coluna < b.GetLength(1); coluna++)
                                {
                                    Console.Write("\t{0:d5}|", b[linha, coluna]);//exibir certa posiçao da matriz na tela

                                }
                                Console.WriteLine("");//pular a linha quando acabar a linha da matriz
                            }
                            if (simetrica_matriz_int(b) == true)
                                Console.WriteLine("A matriz é simetrica");
                            else
                                Console.WriteLine("A matriz nao é simetrica");
                        }
                        else
                            Console.WriteLine("A matriz nao pode ser simetrica pois o numero de linhas e colunas nao sao iguais!");
                        break;
                    //------------------------------------------------------------------ Case 5 --------------------------------------------------------------------------//
                    case 5:
                        Console.WriteLine("A seguinte matriz: ");
                        if (a.GetLength(0) == a.GetLength(1))
                        {
                            for (int linha = 0; linha < a.GetLength(0); linha++)
                            {
                                for (int coluna = 0; coluna < a.GetLength(1); coluna++)
                                {
                                    Console.Write("\t{0:d5}|", a[linha, coluna]);//exibir certa posiçao da matriz na tela

                                }
                                Console.WriteLine("");//pular a linha quando acabar a linha da matriz
                            }
                            if (quadradomagico_matriz_int(a) == true)
                                Console.WriteLine("tem as propriedades de um quadrado magico");
                            else
                                Console.WriteLine("nao tem as propriedades de um quadrado magico");
                        }
                        else
                            Console.WriteLine("A matriz nao pode ser um quadrado magico pois o numero de linhas e colunas nao sao iguais!");
                        break;
                    //------------------------------------------------------------------ Case 6 --------------------------------------------------------------------------//
                    case 6:
                        Console.WriteLine("Saindo");
                        break;

                }
                Console.ReadKey();
                Console.Clear();
            } while (opcao != 6);
        }


        //------------------------------------------------------------------ Soma de matiz --------------------------------------------------------------------------//
        static int[,] soma_matriz_int(int[,] a, int[,] b)//soma as matrizes a e b
        {

            int[,] c = new int[a.GetLength(0), a.GetLength(1)];

            for (int l = 0; l < a.GetLength(0); l++)
            {

                for (int co = 0; co < a.GetLength(1); co++)
                {
                    c[l, co] = a[l, co] + b[l, co]; //colocando o resultado em 'soma'
                }
            }

            return c;

        }


        //------------------------------------------------------------------ Produto de matiz --------------------------------------------------------------------------//
        static int[,] produto_matriz_int(int[,] a, int[,] b)//fazer declaraçao do metodo e variaveis a e b
        {



            int[,] c = new int[a.GetLength(0), b.GetLength(1)];//declarar c[numero de colunas de A , numero de linhas de B ]

            //linhas
            int linhaA = 0;
            int linhaB = 0;
            int linhaC = 0;

            // colunas
            int colunaA = 0;
            int colunaB = 0;
            int colunaC = 0;

            for (colunaA = 0, linhaB = 0; colunaA < a.GetLength(1); colunaA++, linhaB++)//A coluna A e a linha AB andam juntas
            {
                for (colunaC = 0, colunaB = 0; colunaC < c.GetLength(1); colunaC++, colunaB++)//A coluna C e B andam juntas
                {

                    for (linhaC = 0, linhaA = 0; linhaC < c.GetLength(0); linhaC++, linhaA++)//a linha A e C andam juntas
                    {
                        //aloca na matriz C a multiplicaçao entre a matriz A e a matriz B*/
                        c[linhaC, colunaC] += a[linhaA, colunaA] * b[linhaB, colunaB];
                        // esta conta se repede  b.GetLength(0) x b.GetLength(1) x c.GetLength(0) vezes

                    }
                }

            }


            return c;//retornar a variavel c

        }

        //------------------------------------------------------------------ Matiz Tranposta --------------------------------------------------------------------------//
        static int[,] transposta_matriz_int(int[,] a)
        {
            int[,] t = new int[a.GetLength(1), a.GetLength(0)];

            int coluna = 0;
            int linha = 0;

            for (linha = 0; linha < a.GetLength(0); linha++)
            {
                for (coluna = 0; coluna < a.GetLength(1); coluna++)
                {
                    t[coluna, linha] = a[linha, coluna];
                }
            }

            return t;
        }

        //------------------------------------------------------------------ Simetria de matriz --------------------------------------------------------------------------//
        static bool simetrica_matriz_int(int[,] m)
        {
            Boolean resp = true;
            int colunaM;
            int linhaM;

            for (colunaM = 0; colunaM < m.GetLength(1); colunaM++)
            {
                for (linhaM = 0; linhaM < m.GetLength(0); linhaM++)
                {
                    Console.WriteLine("{0}  e  {1}", m[linhaM, colunaM], m[colunaM, linhaM]);
                    if (m[linhaM, colunaM] != m[colunaM, linhaM])
                        resp = false;

                }
            }
            return resp;

        }

        //------------------------------------------------------------------ Quadrado magico --------------------------------------------------------------------------//
        static bool quadradomagico_matriz_int(int[,] m)
        {
            Boolean resp = true;
            int auxiliarSomaLinha = 0;
            int auxiliarSomaColuna = 0;
            int auxiliarSomaDiagonal = 0;
            int auxiliarResposta = 0;

            //linhas
            int linhaM = 0;

            // colunas
            int colunaM = 0;
            //verifica as linas e colunas
            for (colunaM = 0; colunaM < m.GetLength(1); colunaM++)
            {
                for (linhaM = 0; linhaM < m.GetLength(0); linhaM++)
                {

                    auxiliarSomaLinha += m[linhaM, colunaM];
                    auxiliarSomaColuna += m[colunaM, linhaM];

                }
                if (((auxiliarResposta != auxiliarSomaLinha) || (auxiliarResposta != auxiliarSomaColuna)) && (colunaM != 0))
                {
                    resp = false;
                    break;
                }
                auxiliarResposta = auxiliarSomaLinha;
                auxiliarSomaLinha = auxiliarSomaColuna = 0;

            }
            //verifica as diagonais
            if (resp == true)
            {
                colunaM = 0;
                linhaM = 0;
                do
                {
                    auxiliarSomaDiagonal += m[linhaM, colunaM];
                    colunaM++;
                    linhaM++;
                } while (colunaM < m.GetLength(1));

                if ((auxiliarResposta != auxiliarSomaDiagonal) && (colunaM != 0))
                {
                    resp = false;
                }


                if (resp == true)
                {
                    linhaM = m.GetLength(0) - 1;
                    colunaM = m.GetLength(1) - 1;
                    auxiliarSomaDiagonal = 0;
                    do
                    {
                        auxiliarSomaDiagonal += m[linhaM, colunaM];
                        colunaM--;
                        linhaM--;
                    } while (colunaM >= 0);

                    if ((auxiliarResposta != auxiliarSomaDiagonal) && (colunaM != 0))
                    {
                        resp = false;
                    }
                }
            }
            return resp;
        }
    }
}
