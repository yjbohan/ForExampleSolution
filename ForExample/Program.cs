using System;

namespace ForExample
{
    class Program
    {
        static void Main(string[] args) {

            int[] ints = { 17, 94, 51, 51, 89, 47, 68,
                40, 65, 41, 41, 63, 39, 61, 44 };
            var sumOfOdds = 0;
            var itemsInArray = ints.Length;
            //#region Sum of the odds ints
            for (var idx = 0; idx < itemsInArray; idx++)
            {
                if (ints[idx] % 2 == 1)
                    sumOfOdds = sumOfOdds + ints[idx];
            }
            int[] ints1 = { 28, 62, 89, 67, 6, 62, 88, 43, 10, 26 };
            var sum = 0;
            foreach (var Yvonne in ints1)
            {
                sum = sum + Yvonne;
            }
            Console.WriteLine($"The sum is {sum}");

            var names = new string[] {
                "Elena", "Christian", "Tracy", "Manami", "Mark", "Yvonne", "Greg",
            };
             foreach (var Yvonne in names)
            {
                Console.WriteLine(Yvonne);
            } 
            //Console.WriteLine($"The names")


            int[] numbers = { 573, 595, 468, 191, 964 };
            var total1 = 0;
            for(var idx1 = 0; idx1 <= 4; idx1++) {
                total1 = total1 + numbers[idx1];
            }
            var total = 0;
            for (var idx = 1; idx <= 50; idx++)
            {

                if ((idx % 5 == 0) || (idx % 7 == 0))
                {
                    total = total + idx;
                }
                Console.WriteLine($"The answer is {total}. Done ...");
            }

        }
    }
}