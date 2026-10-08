using System;
namespace Lesson10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exception Handling
            Console.WriteLine("---------Exception Handling---------");
            try{//Code that may throw an exception
           Console.Write("First Number:");
           int numerator=Convert.ToInt32(Console.ReadLine());

           Console.Write("Second Number:");
           int denominator=Convert.ToInt32(Console.ReadLine());

           var result=numerator/denominator;

           Console.WriteLine($"Result: {result}");
           }
            catch (FormatException){//Catching the exception
                Console.WriteLine("Please enter a valid number");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Denominator cannot be zero");
            }
            catch(Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            finally//Code that will always execute
            {
                Console.WriteLine("Execution completed");
            }

            //Error Throwing
            Console.WriteLine("---------Error Throwing---------");
            try{
                Console.Write("Enter your age:");
                int age=Convert.ToInt32(Console.ReadLine());
                if(age<0)
                {
                    throw new InvalidOperationException("Age cannot be negative");//Throwing an exception when the age is negative 
                    
                }
                Console.WriteLine($"Your age is: {age}");
            }
            catch(InvalidOperationException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch(FormatException)
            {
                Console.WriteLine("Please enter a valid number");
            }
            finally
            {
                Console.WriteLine("Execution completed");
            }  
        }
    }
}
