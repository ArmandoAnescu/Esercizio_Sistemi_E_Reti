using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convertitore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dp = { 255, 255, 255, 255 };
            int[] ritornoP = new int[4];
            bool [] bit=new bool[32];
            long num = 4294967295;
            for (int i = 0; i < bit.Length; i++) 
            {
                bit[i] = true;
            }
            bool[] ritorno = Convert_Decimale_Puntato_To_Binario(dp);
            ritornoP = Convert_Binario_To_Decimale_Puntato(bit);
            ritorno = Convert_Numero_Decimale_To_Binario(num);
            ritornoP = Convert_Numero_Decimale_To_Decimale_Puntato(num);
            Console.ReadLine();
        }
        static int[] Convert_Binario_To_Decimale_Puntato(bool[] b)
        {
            int[] cifre = new int[4];
            int k = b.Length-1;
            double nConvertito=0;
            for(int j=0; j < 4; j++) 
            {
                for(int i = 0; i < 8; i++) 
                {
                    if (b[k]) 
                    {
                        nConvertito = nConvertito + (1 * Math.Pow(2, i));
                        k--;
                    }
                }
                cifre[j]=Convert.ToInt32(nConvertito);
                nConvertito=0;
            }
            return cifre;
        }
        static bool[] Convert_Decimale_Puntato_To_Binario(int[] dp) 
        {
            bool[] bit = new bool[32];
            int resto,l=bit.Length-1;
            for(int i = 0;i<4;i++) 
            {
                do
                {
                    resto = dp[i]%2;
                    if (resto == 1) 
                    {
                        bit[l] = true;
                    }
                    else 
                    {
                        bit[l]=false;
                    }
                    l--;
                    dp[i] = dp[i]/2;
                } while (dp[i] > 0);
                    
            }
            return bit;
        }
        static bool[] Convert_Numero_Decimale_To_Binario(long numero) 
        {
            long resto;
            bool[] bit =new bool[32];
            int l=bit.Length-1;
            do
            {
                resto = numero % 2;
                if (resto == 1)
                {
                    bit[l] = true;
                }
                else
                {
                    bit[l] = false;
                }
                l--;
                numero = numero / 2;
            } while (numero> 0);
            return bit;
        }
        static int[] Convert_Numero_Decimale_To_Decimale_Puntato(long numero) 
        {
            int[] dp=new int[4];
            int i = 0;
            long resto;
            do
            {
                resto = numero % 256;
                dp[i]= Convert.ToInt32(resto);
                numero=numero/ 256;
                i++;

            } while (numero > 0);
            for(i=0; i<4; i++) 
            {
                Console.WriteLine(dp[i]);
            }
            return dp;

        }

    }
}
