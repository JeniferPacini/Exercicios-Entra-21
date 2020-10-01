using System;

namespace Exercicios
{
    class ExerciseThree
    {
        public static void Three(string[] args)
        {
            Console.WriteLine("\n Exercício 3");
            Console.WriteLine("Imprimir todos os números ímpares menores de 318");

            for(int i = 0; i < 319; i++)
            {
                if (i % 2 != 0)
                {
                    System.Console.WriteLine(i);
                }
            }

            Console.WriteLine("******************* \nFim do exercício 3\n");
            Console.ReadLine();
        }
    }
}
