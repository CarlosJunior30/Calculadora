using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_novo
{
    internal class Program
    {

        enum menu { Soma = 1, Subtracao = 2, Divisao = 3, Multiplicacao = 4, Potencia = 5, Raiz = 6, Sair = 7 }
        static void Main(string[] args)
        {


            bool escolheuSair = false;
            while (!escolheuSair)
            {

                Console.WriteLine("Seja bem vindo ao calc, selecione uma das nossas opções:");
                Console.WriteLine("1-Soma\n2-Subtracao\n3-Divisao\n4-Multiplicacao\n5-Potencia\n6-Raiz\n7-Sair");
                menu opcao = (menu)int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case menu.Soma:
                        Soma();
                        break;
                    case menu.Subtracao:
                        Subtracao();
                        break;
                    case menu.Multiplicacao:
                        Multiplicacao();
                        break;
                    case menu.Divisao:
                        Divisao();
                        break;
                    case menu.Potencia:
                        Potencia();
                        break;
                    case menu.Raiz:
                        Raiz();
                        break;
                    case menu.Sair:
                        escolheuSair = true;
                        break;

                }
                Console.Clear();


            }

        }
        static void Soma()
        {
            Console.WriteLine("soma de dois numeros: ");
            Console.WriteLine("digite o promeiro numero");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            int b = int.Parse(Console.ReadLine());
            int resultado = a + b;
            Console.WriteLine("O resultado da Soma é  " + resultado);
            Console.WriteLine("Pressione a tecla enter para voltar ao MENU");
            Console.ReadLine();
        }
        static void Subtracao()
        {
            Console.WriteLine("Subtracao de dois numeros: ");
            Console.WriteLine("digite o promeiro numero");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            int b = int.Parse(Console.ReadLine());
            int resultado = a - b;
            Console.WriteLine("O resultado da Subtração é  " + resultado);
            Console.WriteLine("Pressione a tecla enter para voltar ao MENU");
            Console.ReadLine();
        }
        static void Multiplicacao()
        {
            Console.WriteLine("Multiplicação de dois numeros: ");
            Console.WriteLine("digite o promeiro numero");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            int b = int.Parse(Console.ReadLine());
            int resultado = a * b;
            Console.WriteLine("O resultado da Multiplicação é  " + resultado);
            Console.WriteLine("Pressione a tecla enter para voltar ao MENU");
            Console.ReadLine();
        }
        static void Divisao()
        {
            Console.WriteLine("Divisão de dois numeros: ");
            Console.WriteLine("digite o promeiro numero");
            float a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            float b = int.Parse(Console.ReadLine());
            float resultado = (float)a / (float)b;
            Console.WriteLine("O resultado da Divisão é  " + resultado);
            Console.WriteLine("Pressione a tecla enter para voltar ao MENU");
            Console.ReadLine();
        }
        static void Potencia()
        {
            Console.WriteLine("Potencia de um numero: ");
            Console.WriteLine("digite a Base");
            float basenum = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o expoente: ");
            float Expo = int.Parse(Console.ReadLine());
            float resultado = (int)Math.Pow(basenum, Expo);
            Console.WriteLine("O resultado Potencia é  " + resultado);
            Console.WriteLine("Pressione a tecla enter para voltar ao MENU");
            Console.ReadLine();
        }
        static void Raiz()
        {
            Console.WriteLine("Raiz de um numero: ");
            Console.WriteLine("digite o numero: ");
            int a = int.Parse(Console.ReadLine());
            double resultado = Math.Sqrt(a);
            Console.WriteLine("Arazi quadrada é:  " + resultado);
            Console.WriteLine("Pressione a tecla enter para voltar ao MENU");
            Console.ReadLine();
        }
    }
}