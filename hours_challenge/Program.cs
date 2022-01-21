using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hourschallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int h1, m1, h2, m2, horasEmMinutos;
            bool isIntH, isIntM;
            horasEmMinutos = 0;

            do
            {
                Console.Write("Digite o primeiro valor referente a hora: ");
                isIntH = int.TryParse(Console.ReadLine(), out h1);
                Console.Write("Digite o primeiro valor referente a minutagem: ");
                isIntM = int.TryParse(Console.ReadLine(), out m1);

            } while (h1 < 0 || h1 > 23 || m1 < 0 || m1 > 59 || isIntH == false || isIntM == false);

            Console.Clear();

            do
            {
                Console.Write("Digite o segundo valor referente a hora: ");
                isIntH = int.TryParse(Console.ReadLine(), out h2);
                Console.Write("Digite o primeiro valor referente a minutagem: ");
                isIntM = int.TryParse(Console.ReadLine(), out m2);

            } while (h2 < 0 || h2 > 23 || m2 < 0 || m2 > 59 || isIntH == false || isIntM == false);

            Console.Clear();

            if (h1 == h2 && m1 == m2) //Horas e minutos iguais, output = 0
            {
                horasEmMinutos = 0;
            }
            else if (h2 > h1 || (h1 == h2 && m1 < m2)) //Caso o horário seja maior ou igual, sendo M2 > M1
            {
                horasEmMinutos = ((60 * h2) + m2) - ((60 * h1) + m1);
            }
            else if (h1 == h2 && m1 > m2) //Caso os horários sejam iguais mas M1>M2. Interpreta-se que é o dia seguinte.
            {
                horasEmMinutos = (((60 - m1) + m2) + 60 * 23);
            }
            else//Caso H1 seja maior que H2, interpreta-se que é o dia seguinte.
            {
                horasEmMinutos = (((23 - h1) * 60) + (60 - m1)) + ((60 * h2) + m2);
            }

            Console.WriteLine("De {0}h:{1}m até {2}h:{3}m são: {4} minutos!", h1, m1, h2, m2, horasEmMinutos);

            Console.ReadKey();

        }
    }
}
