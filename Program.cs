using System;

namespace ConditionalsC_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //normal if-else statement
            int a = 6;

            if(a > 3)
            {
                Console.WriteLine("A is bigger");
            }
            else
            {
                Console.WriteLine("A is smaller or equal");
            }

            //else if statements using the same example we did in Python
            int grade = 90;
            
            if(grade >= 90)
            {
                Console.WriteLine("Grade is an A");
            }
            else if(grade >= 80)
            {
                Console.WriteLine("Grade is a B");
            }

            else{
                Console.WriteLine("Grade is a C");

            }

            //compound conditions
            
            //or
            if(grade >=90 || grade >= 80)
            {
                Console.WriteLine("You are a great student");

            }

            else
            {
                Console.WriteLine("You may need to improve");
            }

            //and statement...testing if someone can vote

            int age = 20;
            string citizen = "y";

            if(age >= 18 && citizen == "y")
            {
                Console.WriteLine("You can vote");
            }

            else
            {
                Console.WriteLine("You cannot vote");
            }


        }
    }
}
