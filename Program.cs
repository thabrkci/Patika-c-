namespace Patika_c_
{
    class Program
    {
        static void Main(string[] args)
        {
            // Assignment and Compound Assignment
            Console.WriteLine("***Assignment and Compound Assignment***");

            // Definition of variables
            int x = 3;
            int y = 3;

            // Examples of compound assignments
            y = y + 2; 
            Console.WriteLine(y); // 5
            y /= 1; 
            Console.WriteLine(y); // 5
            y += 2; 
            Console.WriteLine(y); // 7
            x *= 2; 
            Console.WriteLine(x); // 6

            // Logical Operators
            Console.WriteLine("***Logical Operators***");

            // Definition of boolean variables
            bool isSuccess = true;
            bool isCompleted = false;

            // Examples of logical operators
            if (isSuccess && isCompleted)
                Console.WriteLine("Perfect!");

            if (isSuccess || isCompleted)
                Console.WriteLine("Fine!");

            if (isSuccess && !isCompleted)
                Console.WriteLine("Great!");

            // Relational Operators
            Console.WriteLine("***Relational Operators***");

            // Comparison of two numbers
            int a = 3;
            int b = 4;
            bool result = a < b;
            Console.WriteLine(result); // true

            result = a > b;
            Console.WriteLine(result); // false

            result = a >= b;
            Console.WriteLine(result); // false

            result = a <= b;
            Console.WriteLine(result); // true

            result = a == b;
            Console.WriteLine(result); // false

            result = a != b;
            Console.WriteLine(result); // true

            // Arithmetic Operators
            Console.WriteLine("***Arithmetic Operators***");

            // Arithmetic operations on two numbers
            int number1 = 10;
            int number2 = 5;
            int result1 = number1 / number2;
            Console.WriteLine(result1); // 2

            result1 = number1 * number2;
            Console.WriteLine(result1); // 50

            result1 = number1 + number2;
            Console.WriteLine(result1); // 15

            result1 = number1++; // Use the value first, then increment
            Console.WriteLine(number1); // 11
        }
    }
}
