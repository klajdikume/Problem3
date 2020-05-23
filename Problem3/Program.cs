using System;

namespace Problem3
{
    class Program
    {

        static void Kadane_alg(int[] array)
        {
            int index_fillim = 0, index_fund = 0;
            int max_sum = int.MinValue;
            int current_sum = 0;
            int indeks_fillimi_max = 0;

            for (int i = 0; i < array.Length; i++)
            {
                current_sum = current_sum + array[i]; //mbledh indekset

                if (max_sum < current_sum)
                { 
                    //shuma maksimale behet sa shuma ne kete indeks
                    //fillon sub vektro i ri
                    index_fund = i;
                    indeks_fillimi_max = index_fillim;
                    max_sum = current_sum;
                }
                  

                if (current_sum < 0)
                {
                    index_fillim = i + 1;
                    current_sum = 0;
                }
                    

            }

            Console.Write("indeksi fillim eshte " + indeks_fillimi_max + ", indeksi fundit eshte " 
                + index_fund + " dhe shuma eshte " + max_sum + "\n");

        }


        static void Main(string[] args)
        {
            int[] a = { 12, -34, 40, 6, -10, 56, 12, -1, -15, 10, 4 };

            int[] b = { -2, -3, 4, -1, -2, 1, 5, -3 };

            Kadane_alg(a);
            //Kadane_alg(b);

        }
    }
}
