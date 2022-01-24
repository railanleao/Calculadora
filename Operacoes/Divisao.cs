using System;

namespace Calculadora.Operacoes
{
    class Divisao
    {
        public static void Div()
        {
            Console.Clear();
            Console.WriteLine("Digite seu primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite seu segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            //Console.WriteLine("");

            float rest = v1 / v2;

            Console.WriteLine($"\n O resultado da sua divisão é: {rest}");
            Console.ReadKey();

        }
    }
}
