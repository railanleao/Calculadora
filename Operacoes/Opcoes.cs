using System;

namespace Calculadora.Operacoes
{
    class Opcoes
    {
        public static void Menu()
        {
            Console.Clear();
            Console.WriteLine("O que deseja fazer: ");
            Console.WriteLine("1 - Somar");
            Console.WriteLine("2 - Subtrair");
            Console.WriteLine("3 - Multiplicar");
            Console.WriteLine("4 - Dividir");
            Console.WriteLine("5 - Sair");

            Console.WriteLine("Escolha uma das opções: ");
            short rest = short.Parse(Console.ReadLine());

            switch (rest)
            {
                case 1: Somar.Soma(); break;
                case 2: Subtracao.Subt();break;
                case 3: Multiplicacao.Multip();break;
                case 4: Divisao.Div();break;
                case 5: Environment.Exit(5);break;
                default: Opcoes.Menu(); break;
            }
        }
    }
}
