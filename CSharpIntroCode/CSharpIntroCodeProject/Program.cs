using System.Reflection.Metadata;

namespace CSharpIntroCodeProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variables hold data in a named location
            // Variable data can be changed
            // Declare a variables: DataType Name
            // use camelCase for variable names: myAge, helloWorld
            int myAge;
            myAge = 18;
            double price, subTotal, total;
            Console.WriteLine(myAge);

            // Declare & assign a value at the same time
            string greeting = "Hello";
            Console.WriteLine(greeting);
            greeting = "Hola";
            // Use ' ' around a character
            char menuOption = 'a';

            bool answer = true;
            Console.WriteLine(answer);

            // Formating Output
            // String contatonation
            Console.WriteLine("I am " + myAge + " years old!");
            // String Formatting
            Console.WriteLine("{0}! I am {1} years old!", greeting, myAge );
            // String interpolation identified by the $
            Console.WriteLine($"{greeting}! I am {myAge} years old!");

            // !!MATH!!
            // + - * /(Integer divison) %(Modulous)
            Console.WriteLine(6 + 6);
            Console.WriteLine(11 / 5); // Result is 2 because dividng 2 integers results in an integer
            Console.WriteLine(11 % 5); // Mod returns the remainder of an integer divison

            // Declare 2 variables w/ numbers (21, 8)
            int num1 = 21, num2 = 8; 
            // Write out "The answer of 21/8 is 2"
            Console.WriteLine($"The answer of {num1}/{num2} is {num1 / num2}");

            // The results of a calcuation has the datatype as the values in the calculation
            // Any number without a decimal is assumed to be an integer unless declared otherwise 
            double number1 = 21, number2 = 8;
            // Write out "The answer of 21/8 is 2.625"
            Console.WriteLine($"The answer of {number1}/{number2} is {number1/ number2}");

            // Constants - DO NOT change value
            const double GST = .05;
            Console.WriteLine(100 * GST);

            // Combined Assignment Operators
            int value1 = 0;
            value1 = value1 + 5;
            // OR
            value1 += 5;
            Console.WriteLine(value1);
            // We can use 
            // += 
            // -=
            // *=
            // /=
            // %=

            // Math class(object)
            // contains functionality through methods & properites that does MATH stuff
            double mathResult;
            mathResult = Math.Pow(5, 3); // 5^3
            Console.WriteLine(mathResult);

            mathResult = Math.Sqrt(9); // 3
            mathResult = Math.Round(2.2457, 2); //2.25 (rounds to nearest 2 decimal places
            Console.WriteLine(mathResult);

        }
    }
}