namespace Day3
{
    internal class Program
    {
        static void Main(string[] args)

        {
            //Task 1
            Console.WriteLine("************ Task 1 Write a program to find area of a square. ************");
            Console.Write("Enter the side length of the square: ");
            double sideLenght = Convert.ToDouble(Console.ReadLine());
            // calculate area using function 
            double Area = CalculateSquareArea(sideLenght);

            Console.WriteLine($"The area of the square is: {sideLenght} * {sideLenght} = {Area}");

            //Task 2
            Console.WriteLine("************  Task 2  Odd and Even Number ************ ");
            Console.Write("Enter an integer number: ");

           
            if (int.TryParse(Console.ReadLine(), out int userInput))
            {
                // Check if the number is positive
                if (userInput > 0)
                {
                    // Check if the number is even or odd
                    if (userInput % 2 == 0) 
                    {
                        Console.WriteLine("The entered number is positive and even.");
                    }
                    else
                    {
                        Console.WriteLine("The entered number is positive and odd.");
                    }
                }
                else
                {
                    Console.WriteLine("The entered number is not positive.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }

            Console.WriteLine("************ Task 3  using for & while loop ************");

            //Task 3
            // Using for loop
            int sumFor = 0;

            for (int i = 1; i <= 5; i++)
            {
                Console.Write($"Enter the grade for student : {i}");

                if (int.TryParse(Console.ReadLine(), out int gradeFor))
                {
                    sumFor += gradeFor;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                    i--; 
                }
            }

            Console.WriteLine($"The sum of grades using for loop is: {sumFor}");


            // Using while loop
            Console.WriteLine("****************** Using while *********************");
            int sumWhile = 0;
            int j = 1;

            while (j <= 5)
            {
                Console.Write($"Enter the grade for student : {j}");

                if (int.TryParse(Console.ReadLine(), out int gradeWhile))
                {
                    sumWhile += gradeWhile;
                    j++;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                }
            }

            Console.WriteLine($"The sum of grades using while loop is: {sumWhile}");

            //Task 4
            Console.WriteLine(" ************Task 4  sum of even numbers and the sum of odd numbers. *************");
            int sumEven = 0;
            int sumOdd = 0;

            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"Enter number : {i}");

                if (int.TryParse(Console.ReadLine(), out int Input))
                {
                    if (userInput % 2 == 0)
                    {
                        // Number is even
                        sumEven += userInput;
                    }
                    else
                    {
                        // Number is odd
                        sumOdd += userInput;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                    i--; // Decrement i to repeat the current iteration
                }
            }

            Console.WriteLine($"The sum of even numbers : {sumEven}");
            Console.WriteLine($"The sum of odd  numbers : {sumOdd}");

        }


        static double CalculateSquareArea(double sideLenght)
        {
            return sideLenght * sideLenght;
        }
    }

}