using System;
using System.Collections.Generic;

namespace Cap6
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] s = Console.ReadLine().Split(' ');
            int m = int.Parse(s[0]);
            int n = int.Parse(s[1]);

            int[,] mat = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                s = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(s[j]);
                }
                
            }

            int valor = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i, j] == valor)
                    {
                        Console.WriteLine("Posição " + i + "," + j + ":");
                        if (j > 0)
                        {
                            Console.WriteLine("esquerda: " + mat[i, j - 1]);
                        }
                        if (i > 0)
                        {
                            Console.WriteLine("cima: " + mat[i - 1, j]);
                        }
                        if (j < n - 1)
                        {
                            Console.WriteLine("direita: " + mat[i, j + 1]);
                        }
                        if (i < m - 1)
                        {
                            Console.WriteLine("baixo: " + mat[i + 1, j]);
                        }
                    }
                }

            }



        }
    }
}

/*
using System;

namespace Cap6
{
    class Program
    {
        static void Main(string[] args)
        {

            AluguelQuarto[] vect = new AluguelQuarto[10];
            Console.Write("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Aluguel #{i}:");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                vect[quarto] = new AluguelQuarto(nome, email);
            }
            Console.WriteLine();
            Console.WriteLine("Quartos ocupados:");
            for (int i = 0; i < 10; i++)
            {
                if (vect[i] != null)
                {
                    Console.WriteLine(i + ": " + vect[i]);
                }
            }
        }
    }
}

 */

