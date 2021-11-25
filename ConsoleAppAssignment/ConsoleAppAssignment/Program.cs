using System;
using System.Collections.Generic;
using System.Linq;


class Program
{
    static void Main(string[] args)
    {

        //Assignment Part 1
        string[] Cars = { "Pontiac", "Dodge", "GMC", "Ford", "Chevrolet" };

        //opening statement providing user instruction that prints to the console
        Console.WriteLine("Name the country that makes the vehicles \n Pontiac, Dodge, GMC, Ford and Cheverolet");
        string response1 = (Console.ReadLine()); //user data entry

        for (int i = 0; i < Cars.Length; i++) // loop iterates array to # of index positions
        {
            Cars[i] = Cars[i] + response1; //statement that concatenates original array strings and user input
            Console.WriteLine("Result = " + Cars[i]); //Updated array of strings that prints to console
        }
        Console.ReadLine(); // holds open program for next section of code to run

        Console.WriteLine();

        //Assignment Part 2
        string[] movies = { "The Thing", "Army Of Darkness", "It", "Pet Semetary", "Reanimator" };

        Console.WriteLine("Hit the return key on your \nkeyboard to see what movies contain \nthe letter \"a\" in the title.");
        Console.ReadLine(); //Instruction to console

        int j = 0; //Creates variable assigned to index positions in array

        while (j < movies.Length) //loop that iterates array of strings (movies name)
        {
            //output movies with "a" in title
            if (movies[j].Contains("a")) //condition if string contains letter "a"
            {
                Console.WriteLine(movies[j]); //prints movie titles that met condition
            }
            j++; //denotes that loop will increment
        }
        Console.ReadLine();

        //Assignment Part 3
        //While loop asking top 10 favorite lucky numbers that people will choose, which is #7
        Console.Write("Choose a number less than 50 from which the loop will iterate downward. \n");
        string response2 = Console.ReadLine(); //data entry from user
        int resp2 = Convert.ToInt32(response2); //string to interger

        Console.Write("");

        while (resp2 < 50) //loop that iterates from a number selected by user below 50
        {
            //Condition tells loop to count down, not up
            Console.WriteLine(resp2);
            resp2--;

            //condition to stop loop once loop counts down to 7
            if (resp2 < 7)
                break;
        }
        Console.ReadLine();

        //Assignment Part 3 (2nd part)
        Console.WriteLine("Create a multiplication table based on a base number you choose time 1 to 20");
        Console.ReadLine();

        Console.Write("Select a base number"); //instructions to user
        int Tableof = int.Parse(Console.ReadLine()); //data entry from user

        int TotalLength = 1; // creates variable assigned to index positions in array

        while (TotalLength <= 20) //stops the loop once base number multiplied by numbers 1-20
        {
            int TableValue = TotalLength * Tableof; // establishes table structure
            Console.WriteLine("{0} x {1} = {2}", Tableof, TotalLength, TableValue); //creates condition
            if (TotalLength == 10)
            {
                Console.WriteLine("\n"); //write an extra empty line grouping tables in groups of 10
            }
            TotalLength++; //loop will increment
        }
        Console.ReadLine();

        //Assignment Part 4
        Console.WriteLine("Name any of the 7 Wonders of the world"); // opening statement that is presented to user

        //creation of and adding string elements to new list
        List<string> wonders = new List<string>() { "Great Wall of China", "Petra", "Christ the Redeemer", "Machu Picchu", "Chichen Itza", "Colosseum", "Taj Mahal", "Giza Pyramids" };

        Console.WriteLine(" "); //blank line

        Console.WriteLine("Enter your answer: \n"); //instructions for user to name a wonder
        string response3 = (Console.ReadLine()); //data entry from user

        foreach (string wonder in wonders) // iterate all strings in list
        {
            if (response3 == wonder) // condition matches user inpout against strings in list
            {
                //condition to write the index # and actual string if match found
                Console.WriteLine("You named a 7th wonder of the world!"); //prints phrase to console when met

                int index = wonders.IndexOf(response3);
                Console.WriteLine($"{index}"); //when match occurs, prints index# and correlating string to console
                break; //informs program to break if condition met
            }
            else
            {
                //informs user if guess is incorrect
                Console.WriteLine("That wonder is not a 7th wonder of the world."); //prints phrase when not met for each list name
            }
        }
        Console.ReadLine();

        //Assignment Part 5
        //Statement that informs user regarding the purpose of program
        Console.WriteLine("I have traveled the world and been to England, Japan, Indonesia, China and Spain. Once country I visited more than once.");
        Console.WriteLine("Of all the places I have traveled, can you guess which country I\'ve traveled to the most?");

        //creation of addition string elements to new list
        List<string> countries = new List<string>() { "England", "Japan", "Indonesia", "China", "Spain", "England" };

        Console.WriteLine("Enter your guess: \n"); //Instruction to user to take a guess
        string response4 = (Console.ReadLine()); //data entry from user

        for (int i = 0; i < countries.Count; i++) // iterates all strings in list
        {
            if (countries[i] == response4) //condition is data entry matches string in list
            {
                Console.WriteLine("Match found at index " + i); //Writes message to console confirming a match
            }
        }
        if (!countries.Contains(response4)) //condition is user entry does not match string in list
        {
            Console.WriteLine("Match not in the list."); //message to console confirming not a match
        }
        Console.ReadLine();

        //Assignment Part 6
        //statement informing user of program
        Console.WriteLine("My best friends are John, Barry, Paul, Stacey, Kelsey and Mary");
        Console.WriteLine("I have another best friend who shares the same name in the list. Who is it?");

        //creation of addition of string elements to a new list
        List<string> friends = new List<string>() { "John", "Barry", "Paul", "Stacey", "Kelsey", "John", "Mary" };

        Console.WriteLine(" "); //blank line

        Console.WriteLine("Enter your guess: \n"); //instruction to user to guess name
        string response5 = (Console.ReadLine()); //data entry from user
        List<string> friends1 = new List<string>(); //creates empty list

        foreach (string friend in friends) //condition for list iteration
        {
            if (!friends1.Contains(friend)) //condition if data entry does not match
            {
                friends1.Add(friend); //enters data to new list
                Console.WriteLine(friend + " was not in the list."); //prints message to console when condition not met
            }
            else if (friends1.Contains(friend)) //condition if data entry matches
            {
                //message informs user if incorrectly guessed
                Console.WriteLine(friend + " was on the list."); //prints phrase to console when condition met
            }
            Console.ReadLine();

        }

    }
}
        
                
        




    


