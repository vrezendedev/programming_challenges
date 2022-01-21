using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace framechallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            bool isNum1Int, isNum2Int;

            do
            {
                Console.WriteLine("Digite, respectivamente, o número de caracteres que irá compor a altura e lagura da moldura.");
                Console.WriteLine("A fim de criar uma forma geométrica válida, os dois números devem ser maiores ou igual que 3. \n");
                Console.Write("Altura: ");
                isNum1Int = int.TryParse(Console.ReadLine(), out num1);
                Console.Write("Largura: ");
                isNum2Int = int.TryParse(Console.ReadLine(), out num2);
                Console.Clear();
            } while (isNum1Int == false || isNum2Int == false || num1 < 3 || num2 < 3);

            for (int i = 0; i < num1; i++)
            {
                for (int j = 0; j < num2; j++)
                {
                    if (i == 0 || i == num1 - 1) //Primeira linha ou última
                    {
                        if (j == 0 || j == num2 - 1) //Primeira coluna ou última
                        {
                            Console.Write("+");
                        }
                        else //Senão printa isso aqui
                        {
                            Console.Write("-");
                        }
                    }
                    else
                    {
                        if (j == 0 || j == num2 - 1) //Primeira coluna ou última
                        {
                            Console.Write("-");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }


                }
                Console.WriteLine();
            }

            Console.ReadKey();

        }
    }
}

