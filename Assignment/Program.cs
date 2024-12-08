using System.Security.Cryptography.X509Certificates;

namespace Assignment
{
     class Point { 

       public int X { get; set; }
       public int y { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            #region Q1) Write a program that allows the user to enter a number then print it.

            //string userInput=Console.ReadLine();

            //if (int.TryParse(userInput, out int number))
            //{
            //    Console.WriteLine("Number is " + number);
            //}
            //else
            //{
            //    Console.WriteLine("Please enter a valid number.");
            //}
            #endregion

            #region Q2) Write C# program that converts a string to an integer, but the string contains non-numeric characters. And mention what will happen 

            //string userInput = Console.ReadLine();

            //if (int.TryParse(userInput, out int result))
            //{
            //    Console.WriteLine("The integer is: " + result);
            //}
            //else
            //{
            //    Console.WriteLine("The string contains non-numeric characters ");
            //}

            #endregion

            #region Q3)Write C# program that Perform a simple arithmetic operation with floating-point numbers And mention what will happen

            //float Number1 = 55.5f;
            //float Number2 = 33.3f;

            //Console.WriteLine("Result is "+ (Number1+Number2));

            #endregion

            #region Q4) Write C# program that Extract a substring from a given string.
            //String str = "Hello, World";
            //String str2= str.Substring(0, 7);
            //Console.WriteLine(str2);

            #endregion

            #region Q5)Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen
            //int x = 5;
            //int y = 10;
            //y = x;
            //x = 8;
            //Console.WriteLine(x);// 8
            //Console.WriteLine(y);// 5
            ///*
            // * int is a value type data type, so the variable remains in the stack memory.
            // * Each variable has its own space, and when we assigned y = x,
            // * only the value of x was copied to the other variable.*/

            #endregion

            #region Q6) Write C# program that Assigning one reference type variable to another and modifying the object through one variable and mention what will happen

            //Point p1=new Point();
            //Point p2 = new Point();

            //p2 = p1;
            //Console.WriteLine(p1.X);
            //// A class is a reference type.
            //// First, p1 and p2 references are allocated on the stack, each occupying 4 bytes to hold the addresses
            //// of the actual data objects in the heap.
            //// When we assigned p2 = p1, both references point to the same object.
            #endregion

            #region Q7) Write C# program that take two string variables and print them as one variable 
            //Console.WriteLine("Enter the first String");
            //string userInput = Console.ReadLine();
            //Console.WriteLine("Enter the Second String");
            //string userInput2 = Console.ReadLine();
            //String result = userInput + userInput2;
            //Console.WriteLine(result);



            #endregion


            #region Q8) Which of the following statements is correct about the C#.NET code snippet given below?
            //int d;
            //d = Convert.ToInt32(!(30 < 20));

            //Console.WriteLine(d);
            //// A value 1 will be assigned to d.
            #endregion

            #region Q9) Which of the following is the correct output for the C# code given below?
            //Console.WriteLine(13 / 2 + " " + 13 % 2);
            // d)	6 1
            #endregion

        }
    }
}
