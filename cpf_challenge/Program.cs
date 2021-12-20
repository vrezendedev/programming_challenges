using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafiocpf
{
    class Program
    {
        static bool VerificarCPF(int[] cpf)
        {
            bool cpfValido = false;
            int soma, mult, dv9, dv10;

            soma = 0;
            mult = 1;

            for (int i = 0; i < 9; i++)
            {
                soma = soma + cpf[i] * mult;
                mult++;
            }

            dv9 = soma % 11;
            if (dv9 == 10)
            {
                dv9 = 0;
            }


            soma = 0;
            mult = 0;

            for (int i = 0; i < 10; i++)
            {
                soma = soma + cpf[i] * mult;
                mult++;
            }

            dv10 = soma % 11;
            if (dv10 == 10)
            {
                dv10 = 0;
            }

            if (dv9 == cpf[9] && dv10 == cpf[10])
            {
                cpfValido = true;
            }

            return cpfValido;
        }

        static void Main(string[] args)
        {
            int[] cpfNums = new int[11];

            Console.Write("Digite o CPF: ");
            char[] cpfChars = (Console.ReadLine().ToCharArray());

            for (int i = 0; i < cpfChars.Length; i++)
            {
                cpfNums[i] = int.Parse(cpfChars[i].ToString());
            }

            if (VerificarCPF(cpfNums) == true)
            {
                Console.WriteLine("O CPF é válido.");
            }
            else
            {
                Console.WriteLine("O CPF não é válido.");
            }

            Console.ReadKey();
        }
    }
}
