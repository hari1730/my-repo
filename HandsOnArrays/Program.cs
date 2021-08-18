using System;

namespace HandsOnArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = new int[5];
            n[0] = 89;
            n[1] = 78;
            n[2] = 56;
            n[3] = 45;
            n[4] = 44;

            int k = n[2];

            //for(int i=0;i<5;i++)
           // {
           //     Console.WriteLine(n[i]);
           // }
            foreach(int i in n)
            {
                Console.WriteLine(i);
            }
        }
    }
}
