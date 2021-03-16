using System;

namespace conjuntos
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];
            int[] b = new int[5];
            int[] interseccao = new int[10]; //array intersecção de 10 posiçoes
            int[] difAB = new int[10]; //array diferença a com b
            int[] difBA = new int[10];// array diferença b com a 
            int[] uniao = new int[10];
            int auxiliar = 0, contador = 0, auxiliar2 = 0;
            string intervalo = "";


            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("Digite os elementos do conjunto A:");
                a[i] = int.Parse(Console.ReadLine());
                uniao[contador] = a[i];
                contador++;
            }
            for (int i = 0; i < b.Length; i++)
            {
                Console.WriteLine("Digite os elementos do conjunto B:");
                b[i] = int.Parse(Console.ReadLine());
                uniao[contador] = b[i];
                contador++;
            }


            for (int i = 0; i < a.Length; i++)
            {
                auxiliar = 0;
                auxiliar2 = 0;

                for (int j = 0; j < b.Length; j++)
                {
                    if (a[i] == b[j])
                    {
                        interseccao[i] = a[i];
                    }

                    if (a[i] != b[j])
                    {
                        auxiliar++;
                        if (auxiliar == a.Length)
                        {
                            difAB[i] = a[i];
                        }
                    }

                    if (b[i] != a[j])
                    {
                        auxiliar2++;
                        if (auxiliar2 == b.Length)
                        {
                            difBA[i] = b[i];
                        }
                    }
                }
            }

            Console.Clear();

            for (int i = 0; i < uniao.Length; i++)
            {
                if (i == 0)
                
                {
                    Console.WriteLine(" ****União A u B***** : ");
                }

                if (uniao[i] > 0)
                {
                    intervalo = i < uniao.Length - 1 ? ", " : " ";
                    Console.Write("{0} {1}", uniao[i], intervalo);
                }
            }

            Console.WriteLine();

            for (int i = 0; i < interseccao.Length; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine(" ****Intersecção A / B***** : ");
                }
                if (interseccao[i] > 0)
                {
                    intervalo = i < interseccao.Length - 1 ? ", " : " ";
                    Console.Write("{0} {1}", interseccao[i], intervalo);
                }
            }

            Console.WriteLine();

            for (int i = 0; i < difAB.Length; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine(" ****Diferença A # B**** : ");
                }
                if (difAB[i] > 0)
                {
                    intervalo = i < 8 ? ", " : " ";
                    Console.Write("{0} {1}", difAB[i], intervalo);
                }
            }

            Console.WriteLine();

            for (int i = 0; i < difBA.Length; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine(" ****Diferença B # A***** : ");
                }
                if (difBA[i] > 0)
                {
                    intervalo = i < 8 ? ", " : " ";
                    Console.Write("{0} {1}", difBA[i], intervalo);
                }
            }
        }
    }
}
