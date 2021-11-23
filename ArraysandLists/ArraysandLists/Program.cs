using System;
using System.Collections.Generic;



    class Program
    {
        static void Main()
        {
        //Declaring a single dimensional array
        string[] Books = new string[3];
        Books[0] = "Nailbiter";
        Books[1] = "Y The Last Man";
        Books[2] = "Manifest Destiny";

        Console.WriteLine("Please enter a number from 0 to 3");
        int index1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"This string is at the index you chose: {Books[index1]}");

        int[] array = new int[5];
        array[0] = 1;
        array[1] = 2;
        array[2] = 3;
        array[3] = 4;
        array[4] = 5;

        Console.WriteLine("Please select a number from 0 to 4");
        int array1 = Convert.ToInt32(Console.ReadLine());

        if (array1 > 4)
        {
            Console.WriteLine("The array does not exist");
        }
        else
        {
            Console.WriteLine($"This is array is the number you chose: {array[array1]}");
        }

        var numbers = new List<int>();
        numbers.Add(2);
        numbers.Add(3);
        numbers.Add(5);
        numbers.Add(7);
        Console.WriteLine("Please select a number 2, 3, 5, 7");
        Console.WriteLine("LIST 1: " + numbers.Count);
        Console.ReadLine();






        //List<string> intList = new List<string>();
        //intList.Add("Hello");
        //intList.Add("Matthew");
        //intList.Remove("Matthew");

        //Console.WriteLine(intList[0]);
        //Console.ReadLine();

        //byte[] byteArray = 

                
        //    int[] numArray = new int[5];
        //    numArray[0] = 5;
        //    numArray[1] = 2;
        //    numArray[2] = 10;
        //    numArray[3] = 200;
        //    numArray[4] = 5000;

        //int[] numArray1 = new int[] { 5, 2, 10, 200, 5000 };

        //int[] numArray2 = { 5, 2, 10, 200, 5000, 600, 2000 };

        //numArray2[5] = 650;


        //Console.WriteLine(numArray2[5]);
        //Console.ReadLine();
        }
    }

