using System;

namespace Exercicios
{
    class Exercicio
    {
        static void Main(string[] args)
        {
            int choice = 0;

            while (true)
            {
                Console.WriteLine("\n Este prjeto contém 18 exercicios. \n digite um numero para ver a solução \n Digite 0 para sair. \n");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        ExerciseOne.One(null);
                        break;
                    case 2:
                        ExerciseTwo.Two(null);
                        break;
                    case 3:
                        ExerciseThree.Three(null);
                        break;
                    case 4:
                        ExerciseFour.Four(null);
                        break;
                    case 5:
                        ExerciseFive.Five(null);
                        break;
                    case 6:
                        ExerciseSixx.Sixx(null);
                        break;
                    case 7:
                        ExerciseSeven.Seven(null);
                        break;
                    case 8:
                        ExerciseEight.Eight(null);
                        break;
                    default:
                        break;
                }
                if(choice == 0)
                {
                    break;
                }
            }

        }
    }
}
