using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HTProgrammingTest
{
    class Program
    {
        private static int[] _arbInts = {1, 2, 4, 6, 7, 9, 10, 45, 434, 32, 123, 98, 323, 49, 5};
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to John Pomeroy's Programming Test. Press any key to continue:");
           
            QuestionOne();
            QuestionTwo();
            QuestionThree();
            QuestionFour();
            QuestionFive();
            QuestionSix();
            QuestionSeven();
            Console.Read();
        }

        private static void QuestionOne()
        {
            Console.WriteLine("\nQuestion One");
           /*
            Console.Write("Please enter a list of Intergers, seperated by a space for each interger: ");
            string[] myStrings = Console.ReadLine().Split();
            //fast and easy way to convert all the strings in the string array into an interger array.
            int[] myInts = myStrings.Select(int.Parse).ToArray();
            //Just use built in min and Max for simple use.
            var sumHighLow = myInts.Min() + myInts.Max();
            //LinQ expression saying that for each interget in myInts, if it's odd number, we add it to sumOdd.
            var sumOdd = myInts.Sum(newInt => (newInt%2 != 0) ? newInt : 0);
            //no point making new variable for something that's used once and already has funtion to do it.
           Console.WriteLine("Total Sum: {0}", myInts.Sum());
            
            * */
            //remove comment bracket above and comment two vars below for user input
            var sumHighLow = _arbInts.Min() + _arbInts.Max();
            var sumOdd = _arbInts.Sum(newInt => (newInt%2 != 0) ? newInt : 0);
           Console.WriteLine("Odd Sum: {0}", sumOdd);
           Console.WriteLine("High + Low Sum: {0}", sumHighLow);
           //reverse which is commented for user input
            Console.WriteLine("Sum: {0}", _arbInts.Sum());   
           //Console.WriteLine("Sum: {0}", myInts.sum());
        }


        private static int Recusive(int count, int sum)
        {
            if (count <= 0)
                return sum;
            else
                return Recusive(count - 1, sum + _arbInts[count-1]);
        }
        private static void QuestionTwo()
        { 
            Console.WriteLine("\nQuestion Two");
            var sum = 0;
            var count = _arbInts.Length;
            int newInt = Recusive(count, sum);
            Console.WriteLine("Sum: {0}", newInt);
        }

        private static void QuestionThree()
        {
            Console.WriteLine("\nQuestion Three");
            var myString = "racecar"; //comment out and uncomment other next two for user input
           // Console.Write("Enter any string: ");
           // var myString = Console.ReadLine();
           /* To check if it's a palindrome, we use the strings SequenceEqual and use the strings Reverse function as input, that way the string is checking if the origianl string equals the reverse string. Could have just done an if statement but this easier to write. If was professional program, would create seperate variable for the tenary expresion instead of doing it inside the writeline.
             * */
            Console.WriteLine("Palindrome: {0}", (myString.SequenceEqual(myString.Reverse()))?"True":"False");
        }

        private static void QuestionFour()
        {
            int[] myInt = {4,13,5};
            Console.WriteLine("\nQuestion Four");
            //uncomment next line
            // Console.Write("Please enter 3 integers, seperated by a space for each integer: ");
           
            //split on the ReadLine so i don't have to create 2 variables, 1 for the input and a second one to split. this way, while not best coding practice, for this example saves space and means less variables to look through.
          //uncomment next line
            // string[] myStrings = Console.ReadLine().Split();
         
            //Linq statement that's basically saying, foreach string in the myStrings array, we check if the string = 13, if it does we break and exit loop, else we add value to sum.
            //uncomment next line and comment line after
            // var sum = myStrings.TakeWhile(newStr => int.Parse(newStr) != 13).Sum(newStr => int.Parse(newStr));
            var sum = myInt.TakeWhile(x => x != 13).Sum();
            
            Console.WriteLine("Sum: {0}", sum);

        }

        private static void QuestionFive()
        {
            Console.WriteLine("\nQuestion Five");
        //uncomment for user interaction
            /*
            Console.Write("Please enter an Integer: ");
            var n= int.Parse(Console.ReadLine());
          * */
           
            var n = 42; //comment for user interaction
            var sum = 0;

            for (var i = 0; i < n; i++)
            {
                //instead of if statement, just did ternary satement. Checks to see if divisible by 5 or 3, if so, add to sum, else just add 0.
                sum += ((i%5 == 0) || (i%3 == 0)) ? i : 0;
            }
            Console.WriteLine("Sum: {0}",sum);
        }

        private static void QuestionSix()
        {
            Console.WriteLine("\nQuestion Six");
            //uncomment for user interaction
            //Console.Write("Please enter an Integer: ");
            //var n = int.Parse(Console.ReadLine());
            var n = 942; //comment for user interaction
            var a = 1;
            var b = 2;
            var sum = 0;
            while (b < n)
            {
                //Main fib sequence
                var temp = a;
                a = b;
                b += temp;
                //end main fib sequence

                //if even number, add to sum
                sum += (a % 2 == 0) ? a : 0;
               
                //Used for debuging 
               // Console.Write(a.ToString());
            }
            Console.WriteLine("Sum: {0}",sum);
        }

        private static void QuestionSeven()
        {
            Console.WriteLine("\nQuestion Seven");
            const string monsterValue = "7316717653133062491922511967442657474235534919493496983520312774506326239578318016984801869478851843858615607891129494954595017379583319528532088055111254069874715852386305071569329096329522744304355766896648950445244523161731856403098711121722383113622298934233803081353362766142828064444866452387493035890729629049156044077239071381051585930796086670172427121883998797908792274921901699720888093776657273330010533678812202354218097512545405947522435258490771167055601360483958644670632441572215539753697817977846174064955149290862569321978468622482839722413756570560574902614079729686524145351004748216637048440319989000889524345065854122758866688116427171479924442928230863465674813919123162824586178664583591245665294765456828489128831426076900422421902267105562632111110937054421750694165896040807198403850962455444362981230987879927244284909188845801561660979191338754992005240636899125607176060588611646710940507754100225698315520005593572972571636269561882670428252483600823257530420752963450";
            var a = 0;
            var count = 0;
            var tempSum = 1;
            var sum = 0;
            //better ways to write this if i had more time but for right now, this works.
            foreach (var num in monsterValue)
            {
                var b = a;
                a = int.Parse(num.ToString());
                //if a - 1 == last number then we know it's consecutive and we can add to counter, else reset everything.
                if (a - 1 == b)
                {
                    count++;
                    tempSum *= a;
                }
                else
                {
                    tempSum = 1;
                    count = 0;
                }
                //if count equals 5 and sum is less than our temp sum, sum is now tempSum
                if (count == 5)
                {
                   
                    if (sum < tempSum)
                        sum = tempSum;
                }
            }
            Console.WriteLine("Sum: {0}", sum);
        }
    }
}
