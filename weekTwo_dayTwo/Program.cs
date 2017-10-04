using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weekTwo_dayTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 0; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int counter = 50; counter <= 100; counter++)
            //{
            //   // Console.WriteLine(counter);
            //}
           
            ////using Loops to print an Array
            //string greetings = "My name is Brian";
            //string[] words = greetings.Split();
            ////.Split splits words based on the white space
            //for (int i = 0; 1 < words.Length; i++)
            //{
            //    Console.WriteLine(words[i]);
            //}

            //FOR Loop Starts with FOR
            //within () is a condition similar to an if statement
            //FOR LOOPS ARE DESIGNED TO COUNT FROM ONE NUMBER TO ANOTHER
            // i tracks the value resulting from a loop and can change as loop runs multiple times
            //
            //for(int i = 1; i <=10; i++)
            //    //start at 1; as long as i <= 10, print i; then increment by 1 and reevaluate
            //{
            //    Console.WriteLine(i);
            //}

            string greeting = "My name is Pedro";
            //creating an array called words
            //new array is being split into an array of strings(separates each word)
            //Split makes each word its own index
            //each piece of white space indicates the next string is has a new index
            string[] words = greeting.Split();
            //Arrays are ZERO index, start at Zero Index
            //Prints all Items in Array - to put on 1 line - Console.Write();
            for(int i = 0; i < words.Length; i++)
            {
                Console.WriteLine(words[i]);
            }

            //Do It Exercises

            string[] weekDays = { "Monday", "Tuesday", "Wednesday"};
            for(int i = 0; i < weekDays.Length; i++)
            {
                Console.WriteLine(weekDays[i] + " ");
                // .Write -> writes output to 1 line with spaces to read words
            }

            string story = "Once upon a time";
            string[] storyWords = story.Split();
            Array.Reverse(storyWords);
            for(int i = 0; i < storyWords.Length; i++)
            {
                Console.WriteLine(storyWords[i] + " ");
            }

            //FOR EACH LOOPS
            string[] months = { "Jan", "Feb", "Mar", "Arp", "May", "June", "July", "Aug", "Sept", "Oct", "Nov", "Dec" };
            foreach(string month in months)
            {
                Console.WriteLine(month);
            }

            string[] musicians = { "Angus Young", "James Hettfield", "Slash", "Jimmy Hendrix", "Joe Perry" };
            foreach(string musician in musicians)
            {
                Console.WriteLine(musician);
            }

            //Another Do It Secion

            string[] favoriteFoods = { "pasta", "pizza", "gelatto", "chicken", "pulled pork", "french fries" };
            foreach(string food in favoriteFoods)
            {
                Console.WriteLine(food);
            }

            //int number;
            //int[] luckyNumbersAgain = { 3, 7, 9, 16, 25, 36, 49, 64, 81, 100 };
            //foreach(int number in luckyNumbersAgain)
            //{
            //    if (number == 3){
            //        Console.WriteLine("Your lucky number is 3"); }
            //    else if (number == 5){
            //        Console.WriteLine("Your lucky number is 5");
            //    }
            //    else if (number == 7)
            //        {
            //        Console.WriteLine("Your Lucky number is 7");
            //    }
            //    else if (number == 11)
            //        {
            //        Console.WriteLine("Your lucky number is 11");
            //    }

            //    }
            //}

            //Some ARRAY Practice

            //Create/Initialize Arrat of Names & Pick a Value to Output the Index
            string[] sternStaff = {"Howard" , "Fred", "Robin", "Gary", "Sal", "Richard"};
            Console.WriteLine(Array.IndexOf(sternStaff, "Gary"));

            //Creat A String of Ints; Find a Number the Print the Number's Index
            int[] lotteryNumbers = {9, 32, 47, 91, 9, 87, 71, 23, 33, 71, 87, 34, 67, 34};
            Console.WriteLine(Array.LastIndexOf(lotteryNumbers, 87));

            char[] randomLetters = {'x', 'y', 'j', 'b', 'z', 's', 'j'};
            Console.WriteLine(randomLetters[1]);
            Array.Reverse(randomLetters);
            Console.WriteLine(randomLetters[1]);

            string[] wackPack = {"Mariann from Brooklyn", "Beetlejuice", "Eric the Actor", "Bobo", "Hight Pitch Eric"};
            Array.Sort(wackPack);
            Console.WriteLine(wackPack[0] + " & " + wackPack[wackPack.Length - 1]);




        }
    }
}
