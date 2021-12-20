using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafionumextenso
{
    class Program
    {
        class Valor
        {
            private int valor;

            public Valor()
            {
                valor = 0;
            }

            public int AtribuiValor
            {
                set
                {
                    this.valor = value;
                }
            }

            public int RetornaValor
            {
                get
                {
                    return this.valor;
                }
            }

            public string NumExtenso()
            {
                string extenso = string.Empty;

                string[] unidades, dezenas, centenas;
                unidades = new string[] { "zero", "um", "dois", "três", "quatro", "cinco", "seis", "sete", "oito", "nove", "dez", "onze", "doze", "treze", "quatorze", "quinze", "dezesseis", "dezessete", "dezoito", "dezenove" };
                dezenas = new string[] { "vinte", "trinta", "quarenta", "cinquenta", "sessenta", "setenta", "oitenta", "noventa" };
                centenas = new string[] { "cento", "duzentos", "trezentos", "quatrocentos", "quinhentos", "seiscentos", "setecentos", "oitocentos", "novecentos" };

                int val = RetornaValor;

                if (val >= 0 && val <= 19)
                {

                    extenso = unidades[val];
                    return extenso;

                }
                else if (val >= 20 && val < 100)
                {
                    char[] nums = val.ToString().ToCharArray(); //Converte o valor númerico em array de chars
                    string i = nums[0].ToString(); //Converte o primeiro valor númerico da array de chars p/ string
                    int j = int.Parse(i); //Converte a string p/ int
                    extenso = dezenas[j - 2]; //Pega na array de dezenas o valor correspondente da casa decimal
                    i = nums[1].ToString();
                    j = int.Parse(i);
                    if (j > 0)
                    {
                        extenso = extenso + " e " + unidades[j];
                    }
                    return extenso;
                }
                else if (val >= 100 && val <= 999)
                {
                    char[] nums = val.ToString().ToCharArray();
                    string i = nums[0].ToString();
                    int j = int.Parse(i);
                    extenso = centenas[j - 1]; //Adicionou centenas

                    i = nums[1].ToString();
                    j = int.Parse(i);

                    if (j < 2) //Verificar se é um número inferior a 20
                    {
                        string k = nums[1].ToString() + nums[2].ToString();
                        int l = int.Parse(k);
                        if (l > 0) //Verificar se há unidades maior que 0
                        {
                            extenso = extenso + " e " + unidades[l];
                        }
                        return extenso;
                    }
                    else //Se for superior a 20
                    {
                        extenso = extenso + " e " + dezenas[j - 2];
                        i = nums[2].ToString();
                        j = int.Parse(i);
                        if (j > 0)
                        {
                            extenso = extenso + " e " + unidades[j];
                        }
                        return extenso;
                    }
                }
                else
                {
                    Console.Write("Valor inválido: ");
                    return val.ToString();
                }
            }

        }
        static void Main(string[] args)
        {
            Valor val1 = new Valor();
            do
            {
                Console.Write("Digite um valor a partir de 0 até 999: ");
                val1.AtribuiValor = int.Parse(Console.ReadLine());
                Console.WriteLine(val1.NumExtenso());
            } while (val1.RetornaValor != 1000); //Caso queira encerrar digite um valor inválido
        }
    }
}
