using System;

namespace VS_Test1
{
    public class Program
    {
        // Method checking what year you are born
        static int WhenBirthday(int age, bool birthYet)
        {
            if (birthYet == true)
            {
                return 2022 - age;
            }
            else if (birthYet == false)
            {
                return 2022 - (age + 1);
            }
            else
            {
                return 0;
            }
        }
        // Main Method
        static void Main(string[] args)
        {
            bool done = false;
            while(!done)
                {
                // name
                Console.WriteLine("Hello! Please type your first name: \n");
                string fName = Console.ReadLine();
                Console.WriteLine("Your name is " + fName + ".");

                // age
                Console.WriteLine("Next, type in your age: \n");
                int age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Ahh, so you are {age} years old.");

                //birthday yet
                Console.WriteLine("Have you had your birthday yet this year? Answer 'true' or 'false'. \n");
                bool birthdayYet = Convert.ToBoolean(Console.ReadLine());
                int bYear = WhenBirthday(age, birthdayYet);
                // Finished output
                Console.WriteLine("=================================================================================================================");
                Console.WriteLine($"Your first name is {fName}. | Your age is {age}. | You were born in the year {bYear}.");
                Console.WriteLine("Wanna restart? answer 'true' or 'false'.\n");
                bool startStop = Convert.ToBoolean(Console.ReadLine());
                if (startStop == true)
                {
                    Console.Clear();
                    Console.WriteLine("Restarting. . .");
                }
                else
                {
                    done = true;
                }
            }
        }
    }
}



