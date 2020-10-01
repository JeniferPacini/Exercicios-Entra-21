using System;

namespace Exercicios
{
    class ExerciseFive
    {
        public static void Five(string[] args)
        {
            Console.WriteLine("\nExercício 5");
            Console.WriteLine("Criar um algoritmo que peça o nome e a idade de 5 mulheres.");
            Console.WriteLine("Após informar estes dados, o programa deve mostrar apenas % de mulheres que estão com idade entre 18 e 35");

            string[] name = new string[5];
            int[] age = new int[5];
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("Digite o nome:");
                name[i] = Console.ReadLine();
                Console.WriteLine("Digite a idade:");
                age[i] = Convert.ToInt32(Console.ReadLine());

            }
            int groupW = 0;
            foreach(int a in age )
                {
                    if ((a > 17) && (a < 36))
                    {
                        groupW++;
                    }
                }
            double percentageW = 0;
            percentageW = ((Convert.ToDouble(groupW) / 5) * 100);
            Console.WriteLine($"A porcentagem de mulheres maiores de 18 e menores de 35 anos é de: {percentageW} %\n");
            Console.ReadLine();
        }
    }
}