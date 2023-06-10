using System;

class Program
{
    static void Main(string[] args)
    {
        
        list <int> numbers = new list<int>();

        int userNumbers= -1;
        while (userNumbers != 0)
        {console.ReadLine() = ("Enter a number (0 to quit:)" );

          string userResponse = Console.ReadLine();
            userNumber = int.Parse(userResponse);
            
            // Only add the number to the list if it is not 0
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        // compute the sum
        int sum =0
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}")
        {
            
        }
        // compute the variable
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");


        // Find the max
        // There are several ways to do this, such as sorting the list
        
        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                // if this number is greater than the max, we have found the new max!
                max = number;
            }
        }

        Console.WriteLine($"The max is: {max}");
    }
}
    
