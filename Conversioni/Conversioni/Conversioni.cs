using System;

namespace Conversioni
{
    internal class Conversioni
    {
        static void Main(string[] args)
        {
            int nCon,nCon2;
            int[] dp = { 10, 10, 10, 10 };
            bool[] b = new bool[5];
            //for (int i = 0; i < b.Length; i++) 
            //{
            //    b[i] = true;
            //}
            b[0] = true;
            b[1] = true;
            b[2] = false;
            b[3] = false;
            b[4] = true;
            nCon=Convert_Binario_To_Intero(b);
            Console.WriteLine(nCon);
            Console.WriteLine("===========");
            nCon2=Convert_Decimale_Puntato_To_Intero(dp);
            Console.WriteLine(nCon2);
            Console.Clear();
            Console.WriteLine(2 ^ 2);
            Console.ReadLine();
        }
        static int Convert_Binario_To_Intero (bool[] b)
        {
            int somma;
            int k = 0;
            double nConvertito = 0;
            for(int i=b.Length-1;i>=0;i--)
            {

                if (b[i]==true) 
                {
                    nConvertito = nConvertito + (1 * Math.Pow(2, k));
                }
                k++;
            }
            Console.WriteLine(nConvertito);
            somma = (int) nConvertito;
            return somma;
        }
        static int Convert_Decimale_Puntato_To_Intero (int[] dp) 
        {
            double somma=0;
            int k= 0;
            Console.WriteLine(dp.Length);
            for (int i = dp.Length-1;i>=0;i--) 
            {
                somma=somma+(dp[i]*Math.Pow(256,k));
                k++;
            }
            Console.WriteLine(somma);
            return (int) somma;
        }

    }
}
