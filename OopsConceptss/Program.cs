using System;

namespace OopsConceptss
{
    class Addition
    {
        public int GetSum(int a, int b)
        {
            return a + b;
        }
    }
    class Program : Addition //inheritance
    {
        static void Main(string[] args)
        {
            int num1, num2, res;
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            Program obj = new Program();
            res = obj.GetSum(num1, num2);
            Console.WriteLine(res);
            Console.WriteLine("Inheritance completed");
            

        }
    }
}
