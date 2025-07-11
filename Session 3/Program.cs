using static System.Net.Mime.MediaTypeNames;

namespace Session_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1 - Write a program that allows the user to enter a number then print it.
            //Console.Write("Please Enter A Number: ");
            //int Num;
            //int.TryParse(Console.ReadLine(), out Num);
            //Console.WriteLine($"Your Number Is: {Num}");

            #endregion

            #region Q2 - Write C# program that converts a string to an integer, but the string contains non-numeric characters. And mention what will happen
            //------------------------- by TryParse -------------------------
            //Console.Write("Please enter a string to convert to int: ");
            //int number;
            //int.TryParse(Console.ReadLine(), out number);
            //Console.WriteLine($"The converted int is: {number}");
            // this code will not throw an exception because tryparse will rerurn 0 when the string contains non-numeric characters
            //------------------------- by Convert -------------------------
            //Console.Write("Please enter a string to convert to int: ");
            //int number = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"The converted int is: {number}");
            //thi code will throw an exception because convert only handles null values by converting to 0 and will throw an exception if the string contains non-numeric characters 




            #endregion

            #region Q3 - Write C# program that Perform a simple arithmetic operation with floating-point numbers And mention what will happen
            //Console.Write("Please enter the first floating-point number: ");
            //float num1;
            //float.TryParse(Console.ReadLine(), out num1);
            //Console.Write("Please enter the second floating-point number: ");
            //float num2;
            //float.TryParse(Console.ReadLine(), out num2);
            //float result = num1 + num2; 
            //Console.WriteLine($"The result of adding {num1} and {num2} is: {result}");
            //float result2 = num1 * num2;
            //Console.WriteLine($"The result of multiplying {num1} and {num2} is: {result2}");
            //float result3 = num1 / num2;
            //Console.WriteLine($"The result of Dividing {num1} and {num2} is: {result3}");   
            // this code will perform a simple arithmetic operation with floating-point numbers and will print the result but the result may not be accurate because of Floating-point numbers may have some precision errors

            #endregion

            #region Q4 - Write C# program that Extract a substring from a given string.
            Console.Write("Please enter your string: ");
            string str = Console.ReadLine();
            Console.Write("Please enter the start  number: ");
            int start;
            int.TryParse(Console.ReadLine(), out start);
            string substr = str.Substring(start);
            Console.WriteLine($"The substring starting from index {start} is: {substr}");

            #endregion

            #region Q5 - Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen


            #endregion

            #region Q6 - Write C# program that Assigning one reference type variable to another and modifying the object through one variable and mention what will happen


            #endregion

            #region Q7 - Write C# program that take two string variables and print them as one variable 


            #endregion

            #region Q8 - Write a program that calculates the simple interest given the principal amount, rate of interest, and time
            // Note :  The formula for simple interest is Interest = (principal * rate * time ) /100.

            #endregion

            #region Q9 - Write a program that calculates the Body Mass Index (BMI) given a person's weight in kilograms and height in meters. 
            // Note: The formula for BMI is BMI = (Weight) / (Height * Height)


            #endregion

            #region Q10 - Write a program that uses the ternary operator to check if the temperature is too hot, too cold, or just good. Assign the result in a variable then display the result.
            ///that below 10 degrees is "Just Cold"
            ///above 30 degrees is "Just Hot"
            ///anything else is "Just Good"


            #endregion

            #region Q11  Write a program that takes the date from the user and displays it in various formats using string interpolation.
            ///Ex:
            ///Today’s date : 20 , 11 , 2001
            ///Today's date : 20 / 11 / 2001
            ///Today's date : 20 – 11 – 2001


            #endregion

            #region Q12 - Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.
            ///Example(1)
            ///Input: 12
            ///Output: Yes
            ///Example(2)
            ///Input: 9
            ///Output: No


            #endregion

            #region Q13 - Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.
            ///Example(1)
            ///Input: -5
            ///Output: negative
            ///Example(2)
            ///Input: 10
            ///Output: positive


            #endregion

            #region Q14 - Write a program that takes 3 integers from the user then prints the max element and the min element.
            ///Example(1)
            ///Input: 7,8,5
            ///Output:
            ///max element = 8
            ///min element = 5
            ///Example(2)
            ///Input: 3 6 9
            ///Outputs:
            ///Max element = 9
            ///Min element = 3




            #endregion

            #region Q15 - Write a program that allows the user to insert an integer number then check If a number is even or odd.


            #endregion

            #region Q16 - Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).
            ///Example(1)
            ///Input: O
            ///Output: vowel
            ///Example(2)
            ///Input: b
            ///Output: Consonant

            #endregion

            #region Q17 - Write a program to input the month number and print the number of days in that month.
            /// Example
            /// Input: Month Number: 1
            /// Output: Days in Month: 31


            #endregion
        }
    }
}
