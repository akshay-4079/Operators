using System;

namespace OperatorsMedium
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int x = 20, y = 10;

            var result = x > y ? "x is greater than y" : "x is less than or equal to y";

            Console.WriteLine(result);
            NestedIf();
        }

        private static void NestedIf()
        {
            int x = 2, y = 10;

            string result = x > y ? "x is greater than y" : x < y ?
                            "x is less than y" : x == y ?
                            "x is equal to y" : "No result";
            Console.WriteLine(result);
        }
    }
}
