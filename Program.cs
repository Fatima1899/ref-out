using System;

namespace Ref_out
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(tersine());
            int[] numMain = new int[5];
            numMain = funksiya2(funksiya1());
            for(int i = 0; i < numMain.Length; i++)
            {
                Console.WriteLine(numMain[i]);
            }

        }
        #region Task.2 
        //static string tersine ()
        //{
        //    string result = string.Empty;
        //    Console.WriteLine("soz yazin : ");
        //    string name = Console.ReadLine();
        //     for (int i = 0; i<=name.Length - 1; i++)
        //     {      
        //        result += name[name.Length - i - 1];
        //     }  
        //   return result;
        //}
        #endregion
        static int[] funksiya1()
        {
            int[] num = new int[5];
            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine("eded gir");
                num[i]= Convert.ToInt32(Console.ReadLine());
            }
            return num;

        }

        static int[] funksiya2(int[] num)
        {
            for (int i=0;i<num.Length;i++)
            {
                if (num[i] < 0)
                {
                    num[i] = num[i] * (-1);
                }
            }
            return num;

        }

        

}
}
