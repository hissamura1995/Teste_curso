using System;
using System.Globalization;
using EstudosURI2.Classe;
using System.Collections.Generic;

namespace EstudosURI2
{
    class Program
    {
        static void Main(string[] args)
        {
            //double? x = null;
            //double? y = 10.0;

            //Console.WriteLine(x.GetValueOrDefault());
            //Console.WriteLine(y.GetValueOrDefault());

            //Console.WriteLine(x.HasValue);
            //Console.WriteLine(y.HasValue);

            //if (x.HasValue)
            //    Console.WriteLine(x.Value);
            //else
            //    Console.WriteLine("X is null");
            //if(y.HasValue)
            //    Console.WriteLine(y.Value);
            //else
            //    Console.WriteLine("Y is null");

            // ------------------------------------------------------------------- //


            //double? x = null; //tipo do dado seguido do "?" significa que a variável pode receber null//
            //double? y = 10;

            //double a = x ?? 5; // verifica se x é null, caso for recebe o valor de 5, caso contrário recebe o valor de x//
            //double b = y ?? 5; // verifica se y é null,  caso for recebe o valor 5, caso contrário recebe o valor de y//

            //Console.WriteLine(a);
            //Console.WriteLine(b);

            // ------------------------------------------------------------------- //
            // Problema exemplo 1//

            //int N = int.Parse(Console.ReadLine());
            //double[] vect = new double[N];
            //double soma = 0;
            //double media;

            //for (int i = 0; i < N; i++)
            //{
            //    vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //}

            //for (int i = 0; i < N; i++)
            //{
            //    soma += vect[i];
            //}

            //media = soma / N;

            //Console.WriteLine("AVERAGE HEIGHT = " + media.ToString("F2", CultureInfo.InvariantCulture));

            // ------------------------------------------------------------------- //
            //Problema exemplo 2//

            //int n = int.Parse(Console.ReadLine());
            //Product[] vect = new Product[n];

            //for (int i = 0; i < n; i++)
            //{
            //    string name = Console.ReadLine();
            //    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //    vect[i] = new Product { Name = name, Price = price };
            //}

            //double sum = 0.0;
            //for (int i = 0; i < n; i++)
            //{
            //    sum += vect[i].Price;
            //}

            //double avg = sum / n;

            //Console.WriteLine("AVERAGE PRICE = " + avg.ToString("F2", CultureInfo.InvariantCulture));


            // ------------------------------------------------------------------- //
            //Exercicios - 01 - Vetores//

            //Console.Write("How many rooms will be rented? ");
            //int n = int.Parse(Console.ReadLine());
            //Estudante[] vetor = new Estudante[10];
            //Console.WriteLine();
            //for (int i = 1; i <= n; i++)
            //{
            //    Console.WriteLine("Rent #" + i);
            //    Console.Write("Name: ");
            //    string nome = Console.ReadLine();
            //    Console.Write("Email: ");
            //    string email = Console.ReadLine();
            //    Console.Write("Room(1-9): ");
            //    int room = int.Parse(Console.ReadLine());
            //    Console.WriteLine();
            //    vetor[room] = new Estudante(nome, email);
            //}

            //Console.WriteLine();
            //Console.WriteLine("Quartos ocupados: ");
            //for (int i = 0; i < 10; i++)
            //{
            //    if (vetor[i] != null)
            //    {
            //        Console.WriteLine(i + ": " + vetor[i]);
            //    }
            //}


            // ------------------------------------------------------------------- //
            //Exercicios - 01 - Listas//

            //    Console.Write("How many employees will be registered? ");
            //    int n = int.Parse(Console.ReadLine());


            //    //## instancia uma lista recebendo parametros da classe Funcionario//
            //    List<Funcioario> list = new List<Funcioario>();
            //    Console.WriteLine();

            //    //## Para cada i em n adiciona tais parametros ##// 
            //    for (int i = 1; i <= n; i++)
            //    {
            //        Console.WriteLine("Employee #" + i);
            //        Console.Write("ID: ");
            //        int id = int.Parse(Console.ReadLine());
            //        Console.Write("Name: ");
            //        string name = Console.ReadLine();
            //        Console.Write("Salary: ");
            //        double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //        //## Adiciona a lista ##
            //        list.Add(new Funcioario(id, name, salary));
            //        Console.WriteLine();
            //    }


            //    Console.Write("Enter the employee id that will have salary increase: ");
            //    int searchID = int.Parse(Console.ReadLine());
            //    Console.WriteLine();

            //    //## Instancia um obj que recebe a classe funcionário onde recebe uma pesquisa de x == searchID ##//
            //    Funcioario emp = list.Find(x => x.ID == searchID);

            //    //## Se obj emp for diferente de null realize ##//
            //    if (emp != null)
            //    {
            //        Console.Write("Enter the percentage: ");
            //        double percent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //        emp.IncreaseSalary(percent);
            //    }
            //    else
            //    {
            //        Console.WriteLine("This id does not exist!");
            //    }
            //    Console.WriteLine();

            //    //## Para cada obj Funcionario na lista realize ##//
            //    foreach (Funcioario obj in list)
            //    {
            //        Console.WriteLine("Updated list of emplooyes: " + obj);

            //    }

            // ------------------------------------------------------------------- //
            // Exercicio 1 //
            //Console.Write("Digite a quantidade de linhas: ");
            //int m = int.Parse(Console.ReadLine());

            //Console.Write("Digite a quantidade de colunas: ");
            //int n = int.Parse(Console.ReadLine());
            //Console.WriteLine();
            //int[,] mat = new int[m, n];


            //for (int i = 0; i < m; i++)
            //{
            //    Console.WriteLine("Digite os valores para a linha  " + "[" + (i + 1) + "]");
            //    string[] values = Console.ReadLine().Split(' ');
            //    Console.WriteLine();

            //    for (int j = 0; j < n; j++)
            //    {
            //        mat[i, j] = int.Parse(values[j]);
            //    }
            //}

            //Console.WriteLine();
            //Console.WriteLine("Digite o numero a ser lido na matriz: ");
            //int x = int.Parse(Console.ReadLine());

            //for (int i = 0; i < m; i++)
            //{
            //    Console.WriteLine();
            //    for (int j = 0; j < n; j++)
            //    {
            //        if (mat[i, j] == x)
            //        {
            //            Console.WriteLine("Position: " + i + ", " + j + ": ");

            //            if (j > 0)
            //            {
            //                Console.WriteLine("Left: " + mat[i, j - 1]);
            //            }
            //            if (i > 0)
            //            {
            //                Console.WriteLine("Up: " + mat[i - 1, j]);
            //            }
            //            if (j < n - 1)
            //            {
            //                Console.WriteLine("Right: " + mat[i, j + 1]);

            //            }
            //            if (i < m - 1)
            //            {
            //                Console.WriteLine("Down: " + mat[i + 1, j]);
            //            }
            //        }
            //    }
            //}
            // ------------------------------------------------------------------- //
            // Exercicio 2 //

            //Console.Write("Digite a quantidade de linhas/colunas: ");
            //int qnt = int.Parse(Console.ReadLine());
            //int[,] matriz = new int[qnt, qnt];
            //int negativos = 0;

            //for (int i = 0; i < qnt; i++)
            //{
            //    Console.WriteLine("Linha " + (i + 1));
            //    string[] values = Console.ReadLine().Split(' ');
            //    for (int j = 0; j < qnt; j++)
            //    {
            //        matriz[i, j] = int.Parse(values[j]);

            //        if (matriz[i, j] < 0)
            //        {
            //            negativos++;
            //        }
            //    }
            //}
            //Console.WriteLine();
            //Console.WriteLine("Main diagonal:");
            //for (int i = 0; i < qnt; i++)
            //{
            //    Console.Write(matriz[i, i] + " ");
            //}
            //Console.WriteLine();
            //Console.WriteLine("Negative numbers = " + negativos);
            // ------------------------------------------------------------------- //
            // DateTimes//

            DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);

            //Console.WriteLine("Original: " + d);
            //Console.WriteLine("Dia: " + d.Day);
            //Console.WriteLine("Mês: " + d.Month);
            //Console.WriteLine("Ano: " + d.Year);
            //Console.WriteLine("Hora do dia: " + d.TimeOfDay);

            //string s1 = d.ToLongDateString();
            //string s2 = d.ToLongTimeString();
            //string s3 = d.ToShortDateString();
            //string s4 = d.ToShortTimeString();

            //string s5 = d.ToString();
            //string s6 = d.ToString("yyyy-MM-dd HH:mm:ss");

            //Console.WriteLine(s1);
            //Console.WriteLine(s2);
            //Console.WriteLine(s3);
            //Console.WriteLine(s4);
            //Console.WriteLine(s5);
            //Console.WriteLine(s6);

            // Boa prática: Converter em formato UTC (textp: BD / Json / XML)

            //DateTime d1 = new DateTime(2000, 8, 15 , 13, 5, 58, DateTimeKind.Local);

            //DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc);

            //DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58);

            //Console.WriteLine("d1: " + d1);
            //Console.WriteLine("d1 Kind: " + d1.Kind);
            //Console.WriteLine("d1 to local: " + d1.ToLocalTime());
            //Console.WriteLine("d1 to Utc: " + d1.ToUniversalTime());

            //-----//

            DateTime d1 = DateTime.Now;
            DateTime d2 = DateTime.Now.ToUniversalTime();

            Console.WriteLine(d1);
            Console.WriteLine(d2);

            // ------------------------------------------------------------------- //


        }
    }
} 