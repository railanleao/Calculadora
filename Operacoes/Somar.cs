using System;

namespace Calculadora.Operacoes
{
    internal class Somar
    {
        public static void Soma()
        {
            Console.Clear();
            Console.WriteLine("Digite um número: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            float v2 = float.Parse(Console.ReadLine());

            //Console.WriteLine("");

            float rest = v1 + v2;

            Console.WriteLine($"\nO resultado da sua soma é:{rest}");
            Console.ReadKey();
            Opcoes.Menu();
        }
    }
}
