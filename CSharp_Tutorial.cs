using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Tutorial
{
    class Program
    {
        //string name = "Temidayo";

        static void Main(string[] args)
        {
            Program p = new Program();
            //COMMENTS
            //Comments are strings of words written within a program and ignored by the compiler, it is use to give a detailed information about a program
            //there are two types of comments
            //this is a single line comment
            /*this is a multiples
            line comment*/

            //VARIABLES
            //A variable is like a container which holds values
            //e.g.
            //string name = "Temidayo";
            //Console.WriteLine(name);

            //DIFFERENT TYPES OF VARIABLES
            //1. string = "Temidayo";
            //2. int = 24;
            //3. double = 34.6363735;
            //4. bool = true;
            //string name = "Temidayo";
            //int age = 24;
            //double _double= 34.6363735;
            //bool boolean = true;
            //Console.WriteLine(name);
            //Console.WriteLine(age);
            //Console.WriteLine(_double);
            //Console.WriteLine(boolean);

            //USING VARIABLES WITH STRINGS
            //string name = "Temidayo";
            //Console.WriteLine("My name is {0}", name);

            //p.getGlobal();
            //p.getLocal();

            //MATH OPERATOR & ASSIGMENT OPERATOR
            //MATH OPERATORS
            //int a = 10;
            //int num1 = a += 10;
            //int num2 = a *= 10;
            //int num3 = a -= 10;
            //int num4 = a /= 10;
            //int num5 = a %= 10;
            //Console.WriteLine(num1);
            //Console.WriteLine(num2);
            //Console.WriteLine(num3);
            //Console.WriteLine(num4);
            //Console.WriteLine(num5);

            //IF STATEMENT
            //string name = "Temidayo";
            //if (name == "Temidayo")
            //{
            //    Console.WriteLine("The name matched");
            //}

            //IF ELSE STATEMENT
            //string name = "Temidayo";
            //if (name == "Temiidayo")
            //{
            //    Console.WriteLine("Name is correct");
            //}
            //else
            //{
            //    Console.WriteLine("Name is incorrect");
            //}

            //NESTED IF STATEMENT
            //string name = "Temidayo";
            //int age = 23;
            //if (name == "Temidayo")
            //{
            //    if (age == 23)
            //    {
            //        Console.WriteLine("Name and Age is correct");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Name is incorrect");
            //}

            //SWITCH STATEMENT
            //Console.WriteLine("Please enter your name");
            //string name = Console.ReadLine();
            //switch (name)
            //{
            //    case "Temidayo":
            //        Console.WriteLine("Your name is Temidayo");
            //        return;
            //    case "Afolabi":
            //        Console.WriteLine("Your surname is Afolabi");
            //        return;
            //    default:
            //        Console.WriteLine("Invalid Name");
            //        return;
            //}

            //FOR LOOP
            //for (int i = 0; i <= 15; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //WHILE LOOP
            //int i = 0;
            //while (i <= 15)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            //DO WHILE LOOP
            int i = 0;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i <= 15);

            Console.ReadKey();
        }

        //FUNCTIONS
        //void printName()
        //{
        //Console.WriteLine("My name is Temidayo");
        //}

        //USING PARAMETERS WITH FUNCTIONS
        //void printName(string name)
        //{
        //Console.WriteLine("My name is {0}", name); //this is called place holder syntax
        //Console.WriteLine("My name is " + name); //this is called concatenation
        //}

        //FUNCTIONS WITH MULTIPLE PARAMETERS
        //void printName(string name, int age, string occupation)
        //{
        //Console.WriteLine("My name is {0} and i am {1} years old, also i am a {2} at Nova Technologies", name, age, occupation); //this is called place holder syntax
        //Console.WriteLine("My name is " + name + " and i am " + age + " years old, also i am a " + occupation + " at Nova Technologies"); //this is called concatenation
        //}

        //CALLING A FUNCTION FROM ANOTHER FUNCTION
        //void firstFuction()
        //{
        //    Console.WriteLine("This is the First Function");
        //}
        //void secondFunction()
        //{
        //    Console.WriteLine("This is the Second Function");
        //}
        //void printBothFunction()
        //{
        //    firstFuction();
        //    secondFunction();
        //}

        //GLOBAL & LOCAL VARIABLE
        //GLOBAL VARIABLE
        //void getGlobal()
        //{
        //Console.WriteLine("This is a global variable");
        //Console.WriteLine("My name is {0}\n\n", name);
        //}
        //LOCAL VARIABLE
        //void getLocal()
        //{
        //string name1 = "Emily";
        //Console.WriteLine("This is a local variable");
        //Console.WriteLine("My name is {0}", name1);
        //}

        
    }
}
