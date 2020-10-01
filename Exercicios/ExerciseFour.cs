using System;

namespace Exercicios
{
    class ExerciseFour
    {
        public static void Four(string[] args)
        {
            Console.WriteLine("\nExercício 4");
            Console.WriteLine("Calcular a média de idade de uma turma qualquer. ");
            Console.WriteLine("O algoritmo deve parar quando for digitada a idade igual a zero.");

            int media = 0;
            int turma = 0;
            int age;
            int sumAge = 0;

            while (true)
            {
                Console.WriteLine("Informe sua idade");
                age = Convert.ToInt32(Console.ReadLine());
                if(age != 0)
                {
                    sumAge = +age;
                    turma++;
                    media = sumAge / turma;

                    Console.WriteLine($"A média da idade da turma com {turma} alunos é de: {media}");

                }
                else
                {
                    break;
                }
            }
            Console.WriteLine("******************* \n Fim do exercício 4");
            Console.ReadLine();
        }
    }
}