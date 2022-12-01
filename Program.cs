using System;
namespace Func_Example
{
    class Example
    {
        public void PassByVal(int a)
        {
            a = a + 50;
            Console.WriteLine("Value inside the function: " + a);
        }
        public void PassByRef(ref int a)
        {
            a = a + 50;
            Console.WriteLine("Value inside the function: " + a);
        }
        public void PassByOut(out int a)
        {
            int b = 20;
            a = b;
            a = a + 50;
            Console.WriteLine("Value inside the function: " + a);
        }
        static void Main(string[] args)
        {
            int a = 100;
            Example xyz = new Example();
            Console.WriteLine("Value before calling: " + a);
            //try calling each method one by one
            // xyz.PassByVal(a);
            // xyz.PassByRef(ref a);
            xyz.PassByOut(out a);
            Console.WriteLine("Value after calling: " + a);
        }
    }
}