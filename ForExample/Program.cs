using System;

namespace ForExample
{
    class Program
    {

        static void Main(string[] args)
        {

            int[] ints = { 17, 94, 51, 51, 89, 47, 68,
                40, 65, 41, 41, 63, 39, 61, 44 };
            var sumOfOdds = 0;
            var itemsInArray = ints.Length;
            for (var idx = 0; idx < itemsInArray; idx++)

            //#region Sum of the odds ints
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
            for (var idx1 = 0; idx1 <= 4; idx1++)
            {
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

                int[] nbrs0 = {
   754, 233, 509, 792, 700, 596, 833, 658, 998, 742,
   187, 754, 308, 914, 489, 867, 717, 586, 929, 467,
   460, 241, 770, 324, 599, 259, 120, 800, 336, 609,
   690, 134, 598, 249, 282, 574, 334, 956, 659, 214,
   435, 643, 809, 874, 906, 620, 328, 369, 426, 561
};
                var largest = 0;
                var smallest = 1000;
                foreach (var i in nbrs0)
                {
                    if (i > largest)
                    {
                        largest = i;
                    }
                    if (i < smallest)
                    {
                        smallest = i;
                    }

                    // multiply all the numbers in the colelction
                    
                    double[] terms = { 1.2, 1.3, 1.5, 1.7, 1.9, 1.11 };
                    //var sum1 = 1;
                    var sum1 = 0.0;
                    foreach (var multiply in terms)
                    {
                        sum1= sum1 +  multiply;
                    }
                    Console.WriteLine(sum1);

                
                                   
                    


                }




            }

        }
    }
}