using System;
using System.Threading.Channels;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment01
{
    internal class Program
    {

        class Person
        {
            public string Name;
        }
        static void Main(string[] args)
        {
            #region Write a program that allows the user to enter a number then print it.
            //Console.Write("Enter a number: ");
            //int number = int.Parse(Console.ReadLine());
            //Console.WriteLine($"You entered : {number}");
            #endregion

            #region Write C# program that converts a string to an integer, but the string contains non-numeric characters. And mention what will happen

            //Console.WriteLine("Enter an integer:");
            ////int number = Convert.ToInt32(Console.ReadLine()); //throw an exception
            ////int number2 = int.Parse(Console.ReadLine()); //throw an exception
            //int.TryParse(Console.ReadLine(), out int number3); //return 0
            //Console.WriteLine(number3); // print 0

            #endregion

            #region Write C# program that Perform a simple arithmetic operation with floating-point numbers And mention what will happen

            ////float a = 0.1234f;
            ////float b = 1.3001f;

            ////Console.WriteLine(a + b);
            //float x = 0.3f;
            //float y = 0.4f;

            //Console.WriteLine(x + y); //output is 0.70000005
            ////0.3f and 0.4f cannot be represented exactly in binary.
            ////So when you add them, the result is slightly more than 0.7.
            #endregion

            #region Write C# program that Extract a substring from a given string.
            //string name = "Omar Adel";
            //Console.WriteLine(name.Substring(0,4));

            #endregion

            #region Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen
            //int a = 5;
            //int b = a;
            //a = 6;
            //Console.WriteLine($"a = {a}, b = {b}");//a=6,b=5(didnt change by changing a)
            #endregion

            #region Write C# program that Assigning one reference type variable to another and modifying the object through one variable and mention what will happen

            //CLASS NAMED PERSON IS OUTSIDE THE MAIN

            //Person person1 = new Person();
            //person1.Name = "Omar";

            //Person person2 = person1;


            //person2.Name = "Ahmed";

            //Console.WriteLine($"person1.Name = {person1.Name},person2.Name = {person2.Name} " ); //ahmed,ahmed
            //                                                                                     //both point to the same address in memory so if anyone changed the other will change 
            #endregion

            #region Write C# program that take two string variables and print them as one variable 
            //Console.WriteLine("Enter first name");
            //string Fname = Console.ReadLine();
            //Console.WriteLine("Enter last name");
            //string Lname = Console.ReadLine();

            //Console.WriteLine($"NAME IS :{Fname} {Lname}");
            #endregion

            #region Write a program that calculates the simple interest given the principal amount, rate of interest, and time. 
            //Note: The formula for simple interest is Interest = (principal * rate * time) / 100.
            //Console.WriteLine("Enter principal amount");
            //float PrincipalAmount = float.Parse(Console.ReadLine());
            //Console.WriteLine("Enter rate of interest in %");
            //float InterestRate = float.Parse(Console.ReadLine());
            //Console.WriteLine("Enter time in years");
            //float Time = float.Parse(Console.ReadLine());

            //float SimpleInterest = (PrincipalAmount * InterestRate * Time) / 100;

            //Console.WriteLine($"Simple interest = {SimpleInterest}");
            #endregion

            #region Write a program that calculates the Body Mass Index (BMI) given a person's weight in kilograms and height in meters. 
            //Note: The formula for BMI is BMI = (Weight) / (Height * Height)
            //Console.WriteLine("Enter your weight");
            //float Weight = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter your height");
            //float Height = int.Parse(Console.ReadLine());
            //float BMI = Weight / (Height * Height);
            //Console.WriteLine($"BMI IS {BMI}");


            #endregion

            #region Write a program that uses the ternary operator to check if the temperature is too hot, too cold, or just good. Assign the result in a variable then display the result. 
            //Note:
            //that below 10 degrees is "Just Cold"
            //above 30 degrees is "Just Hot"
            //anything else is "Just Good"
            //int weather = 20;
            //string message = (weather < 10) ? "Just Cold": (weather > 30) ? "Just Hot": "Just Good";

            //Console.WriteLine(message);
            #endregion

            #region Write a program that takes the date from the user and displays it in various formats using string interpolation.
            //Ex:
            //Today’s date : 20 , 11 , 2001
            //Today's date : 20 / 11 / 2001 
            //Today's date : 20 – 11 – 2001

            //Console.Write("Enter day: ");
            //int day = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter month: ");
            //int month = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter year: ");
            //int year = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine($"Today's date : {day} , {month} , {year}");
            //Console.WriteLine($"Today's date : {day} / {month} / {year}");
            //Console.WriteLine($"Today's date : {day} - {month} - {year}");
            #endregion

            #region Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.
            //Console.WriteLine("Enter number");
            //int.TryParse(Console.ReadLine(),out int num);
            //if (num % 4 == 0 && num % 3 == 0)
            //    Console.WriteLine("Yes!");
            //else
            //    Console.WriteLine("No!");


            #endregion

            #region Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.
            //Console.WriteLine("Enter number");
            //int.TryParse(Console.ReadLine(), out int num);
            //if(num < 0)
            //    Console.WriteLine("Negative");
            //else
            //    Console.WriteLine("Positive");

            #endregion

            #region write a program that takes 3 integers from the user then prints the max element and the min element.
            //            int max = 0, min = 0;
            //            Console.WriteLine("Enter three numbers ");
            //            int.TryParse(Console.ReadLine(),out int num1);
            //            int.TryParse(Console.ReadLine(), out int num2);
            //            int.TryParse(Console.ReadLine(), out int num3);
            //            if(num1 > num2)
            //            {
            //                if(num1>num3)
            //                {
            //                    max = num1;
            //                    if (num2 > num3)
            //                        min = num3;
            //                    else 
            //                        min = num2;
            //                }
            //                else
            //                {
            //                    max = num3;
            //                    min = num2;
            //                }
            //            }
            //            else 
            //            {
            //                if (num2 > num3)
            //                {
            //                    max = num2;
            //                    if (num1 > num3)
            //                        min = num3;
            //                    else
            //                        min = num1;
            //                }
            //                else
            //                {
            //                    max = num3;
            //                    min = num1;
            //                }
            //            }

            //            Console.WriteLine($@"max = {max}
            //min = {min}");
            #endregion

            #region Write a program that allows the user to insert an integer number then check If a number is even or odd.
            //Console.WriteLine("Enter an integer");
            //int.TryParse(Console.ReadLine(), out int num);
            //if (num % 2 == 0)
            //    Console.WriteLine("Number is even");
            //else
            //    Console.WriteLine("Number is odd");

            #endregion

            #region Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).
            //Console.WriteLine("Enter char");
            //char c = char.ToLower(Convert.ToChar(Console.ReadLine()));
            //if ((c == 'a') || (c == 'e') || (c == 'i') || (c == 'o') || (c == 'u'))
            //    Console.WriteLine("vowel");
            //else
            //    Console.WriteLine("Consonant");

            #endregion

            #region Write a program to input the month number and print the number of days in that month.
            //Console.WriteLine("Enter the month's number");
            //int.TryParse(Console.ReadLine(), out int num);
            //int days;
            //switch(num)
            //{
            //    case 1:  
            //    case 3:  
            //    case 5:  
            //    case 7:  
            //    case 8:  
            //    case 10: 
            //    case 12: 
            //        days = 31;
            //        break;

            //    case 4:  
            //    case 6:  
            //    case 9:  
            //    case 11:
            //        days = 30;
            //        break;

            //    case 2:  
            //        days = 28; 
            //        break;

            //    default:
            //        days = 0;
            //        break;

            //}

            //Console.WriteLine($"Number of days is {days}");
            #endregion
        }
    }
}