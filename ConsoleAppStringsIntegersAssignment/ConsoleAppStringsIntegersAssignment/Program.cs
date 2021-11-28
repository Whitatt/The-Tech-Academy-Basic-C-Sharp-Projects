using System;
using System.Collections.Generic;



class Program
{
    static void Main(string[] args)
    {
        //Instantiation addition of string elements to list
        List<int> intList = new List<int>() { 14, 25, 38, 60, 74, 100 };

        Console.WriteLine("Division Program"); //Displays name of Program
        Console.WriteLine("Pick a number that will be used to divide each number in the list:"); //Instructions to User

        //Try statement 
        try
        {
            int responseInt = Convert.ToInt32(Console.ReadLine()); //User data entry
            foreach (int integer in intList) // program will iterate a;; index positions in list
            {
                Console.WriteLine(integer / responseInt); //program performs math calculation
            }
        }
        //catch 1: if user enters # other than whole number
        catch (FormatException ex) //exception specific to format
        {
            Console.WriteLine("Please type a whole number."); //prints message to use whole number
            return;
        }
        //catch 2: if user enters zero
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Please don't divide by zero.");
        }
        //catch 3: catch that allows for handling of other built in exception errors
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message); //catch exception handler that displays format exception message
        }
        //Finally: Executes when try/catch block leaves execution
        finally
        {
            Console.ReadLine(); //pauses and holds open program for next code to run
        }
        Console.WriteLine("The number(s) you have entered are valid."); //display message to console confirming numbers are valid
        Console.ReadLine();


    }
}