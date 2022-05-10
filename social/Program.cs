using System;
using System.IO;
#nullable disable

namespace SSN
{
    class Program
    {
        static void Main(string[] args)
        {
            //This function captures 9 characters into an array and shows the character on Screen
            static char[] SSN() 
            {
                char[] characters = new char[9];
                Console.Write("\nEnter the Social Security Number: \n");
                for(int i = 0; i < characters.Length; i++)
                {
                    characters[i] = Console.ReadKey().KeyChar;

                    if (i == 2 || i == 4)
                    {
                        Console.Write("-");
                    }
                }
                //if the array is equal to 9 characters then we validate the differents parts of the social security number
                if (characters.Length == 9)
                {
                    Console.WriteLine("\nThe SSN has 9 characters!");
                    int[] socialInt = socialSecurity(characters);
                    if(socialInt[socialInt.Length - 1] != 0){
                        bool firstThree = firstPart(socialInt);
                        if(firstThree){
                            bool middleTwo = middle(socialInt);
                            if(middleTwo){
                                bool lastThree = lastPart(socialInt);
                            }
                        }
                    }
                    else if(socialInt[4] != 0 || socialInt[3] != 0 && socialInt[5] == 0 && socialInt[6] == 0 && socialInt[7] == 0 && socialInt[8] == 0){
                        Console.Write("The third and fourth digits must be between 0001 and 9999. Please try again!\n");
                    }
                }
                else
                {
                    Console.WriteLine("\nYour Social Security Number must contain 9 characters");
                }             
                return characters;
            }

            //This function takes the characters from the char array and put them into an integer array
            static int[] socialSecurity(char[] characters){
                int[] charactersInt = new int[characters.Length];
                for(int i = 0; i < characters.Length; i++)
                {
                    //if the character is a number then we convert char to string and then to integer and we put it in the array, if not we stop the program
                    if(Char.IsDigit(characters[i]))
                    {
                        charactersInt[i] = Convert.ToInt32(Char.ToString(characters[i]));
                    }
                    else {
                        Console.Write("The Social Security Number can only contain numbers!\n");
                        break;
                    }
                }
                return charactersInt;
            }
            //this function validates de first three digits of the ssn, converting them to a string and then to an int
            static bool firstPart(int[] ssn){
                bool valid;
                string x = "";
                int firstThree;
                for (int i = 0; i < 3; i++)
                {
                    x += ssn[i].ToString();
                }
                firstThree = int.Parse(x);
                //if the first three numbers are equal to 000, 666, or between 900 and 999 then the program stop and show it on screen 
                if (firstThree == 000 || firstThree == 666){
                    Console.WriteLine("The first three digits cannot be 000 or 666. Please try again.\n");
                    valid = false;
                }
                else if (firstThree >= 900 && firstThree <= 999){
                    Console.WriteLine("The first three digits cannot be between 900 and 999. Please try again.\n");
                    valid = false;
                }
                else{
                    Console.WriteLine(true);
                    valid = true;
                }
                return valid;
            }

            //this function validates if the middle part of the ssn is correct
            static bool middle(int[] ssn){
                bool valid = false;
                string x = "";
                int middleTwo;
                for(int i = 3; i < 5; i++)
                {
                    x += ssn[i].ToString();
                }
                middleTwo = int.Parse(x);
                //if the middle numbers are between 01 and 99 then we continue executing the program, else we stop the program
                if (middleTwo >=01 && middleTwo <= 99){
                    Console.WriteLine(true);
                    valid = true;
                }
                else{
                    Console.WriteLine("The third and fourth digits must be between 01 and 99. Please try again!\n");
                    valid = false;
                }
                return valid;
            }

            //this function validates the last four numbers to see if they're between 0001 and 9999, if not, the num is invalid
            static bool lastPart(int[] ssn){
                bool valid = false;
                string x = "";
                int lastThree;
                for(int i = 5; i < ssn.Length; i++)
                {
                    x += ssn[i].ToString();
                }
                lastThree = int.Parse(x);
                if (lastThree >= 0001 && lastThree <= 9999){
                    Console.WriteLine(true);
                    valid = true;
                }
                else{
                    Console.Write("The third and fourth digits must be between 0001 and 9999. Please try again!\n");
                    valid = false;
                }
                return valid;
            }

            //in every function that the validation is true we'll capture true and show it on screen.
            static void program()
            {
                char[] socialChar = SSN();
            }
            program();
        }
    }
}