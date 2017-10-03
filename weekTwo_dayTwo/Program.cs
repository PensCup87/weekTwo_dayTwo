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





        }
    }
}
