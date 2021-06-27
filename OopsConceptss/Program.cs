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
            GetNumbers gn = new GetNumbers();
            gn.setNum1(num1);//setter for num1
            gn.setNum2(num2);//setter for num2
            Console.WriteLine(obj.GetSum(gn.getNum1(),gn.getNum2()));//printing sum using functions by getters
            Console.WriteLine("abstraction , encapsulation completed");


        }
    }
}
