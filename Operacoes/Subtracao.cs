using System;

namespace Calculadora.Operacoes
{
    class Subtracao
    {
        public static void Subt()
        {
            Console.Clear();
            Console.WriteLine("Digite seu primeiro número: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o seu segundo número: ");
            float v2 = float.Parse(Console.ReadLine());

            //Console.WriteLine("");

            float rest = v1 - v2;

            Console.WriteLine($"\nO resultado da subtração é: {rest}");
            Console.ReadKey();
            Opcoes.Menu();

        }
    }
}
