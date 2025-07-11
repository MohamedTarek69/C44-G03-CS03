using System.Globalization;

namespace Session_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Fraction And Discard
            //float MyFloat = 10.123456789F;
            //Console.WriteLine(MyFloat);

            //double MyDouble = 10.123456789123456789;
            //Console.WriteLine(MyDouble);

            //decimal myDecimal = 10.123456789123456789123456789M;
            //Console.WriteLine(myDecimal); //money

            //long Number = 100_000_000_000;
            //Console.WriteLine($"{Number:c}");

            //var cultureInfo = new CultureInfo("ar-SA");
            //Console.WriteLine(Number.ToString("c", cultureInfo));
            #endregion

            #region Casting
            #region Implicit And Explicit Casting
            #region  Example-01
            //int X = 1000; // 4 bytes
            //long Y = X; // 8 bytes implicit casting [Safe Casting]
            //Console.WriteLine(Y);

            //long A = 10000000000000; // 8 Bytes // from user
            //int B = (int)A; // Explicit casting
            //Console.WriteLine(B);

            //checked 
            //{
            //    long A = 10000000000000; // 8 Bytes // from user
            //    int B = (int)A;            
            //    unchecked
            //    {
            //        Console.WriteLine(B);
            //    }
            //}

            // protitctive Code
            //long K = 123456;

            //if(K > int.MaxValue || K < int.MinValue)
            //{
            //    Console.WriteLine("Exciption will be throw due to overflow");
            //}
            //else
            //{
            //    int M = (int)K;
            //    Console.WriteLine(M);
            //}

            #endregion
            #region Example-02
            //int X = 10; // 4 bytes
            //decimal Y = X; // 8 bytes
            //Console.WriteLine(Y);

            //decimal K = 10.100M; // 8 bytes
            //int M = (int)K; // 4 bytes
            //Console.WriteLine(M); //Loss Data





            #endregion

            #endregion
            #region Convert
            //Console.WriteLine("Please enter your data");
            //Console.Write("Name : ");
            //string Name = Console.ReadLine();
            //Console.Write("Age : ");
            //int Age = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Salary : ");
            //decimal Salary = Convert.ToDecimal(Console.ReadLine());
            //Console.Clear();
            //Console.WriteLine("Employee Data : ");
            //Console.WriteLine("Name is " + Name);
            //Console.WriteLine("Age is "+Age);
            //Console.WriteLine("Salary is " + Salary);


            #endregion
            #region Parese()
            //Console.WriteLine("Please enter your data");
            //Console.Write("Name : ");
            //string Name = Console.ReadLine();
            //Console.Write("Age : ");
            //int Age = int.Parse(Console.ReadLine());
            //Console.Write("Salary : ");
            //decimal Salary = decimal.Parse(Console.ReadLine());
            //Console.Clear();
            //Console.WriteLine("Employee Data : ");
            //Console.WriteLine("Name is " + Name);
            //Console.WriteLine("Age is " + Age);
            //Console.WriteLine("Salary is " + Salary);


            #endregion
            #region TryParse
            //Console.WriteLine("Please enter your data");
            //Console.Write("Name : ");
            //string Name = Console.ReadLine();
            //Console.Write("Age : ");
            //int Age;
            //bool Flag1 = int.TryParse(Console.ReadLine(), out Age);
            //Console.Write("Salary : ");
            //decimal Salary;
            //bool Flag2 = decimal.TryParse(Console.ReadLine(), out Salary);
            //Console.Clear();
            //Console.WriteLine("Employee Data : ");
            //Console.WriteLine("Name is " + Name);
            //Console.WriteLine("Age is " + Age); 
            //Console.WriteLine("flag is " + Flag1); 
            //Console.WriteLine("Salary is " + Salary);
            //Console.WriteLine("flag is " + Flag2);

            #endregion
            #endregion

            #region Operators
            #region unary opertators
            //int X = 10;
            ////1) ++
            ////1.1-prefix[increment and then print]
            //Console.WriteLine(++X); // 11
            //Console.WriteLine(X); // 11
            //1.2 postfix[print and then increment]
            //Console.WriteLine(X++); // 10
            //Console.WriteLine(X); // 11

            ////2) --
            ////2.1-prefix [decrement and then print]
            //Console.WriteLine(--X); // 9
            //Console.WriteLine(X); // 9

            ////2.2-postfix [print and then decrement]
            //Console.WriteLine(X--); // 10
            //Console.WriteLine(X); // 9
            #endregion
            #region Binary | Arithmetic Operators [+ , - , * , / , %]
            //int SumResult, SubResult , MultResult , DivResult , ModResult;
            //int number01 = 6, number02 = 2;
            //SumResult = number01 + number02; //8
            //SubResult = number01 - number02; //4
            //MultResult = number02 * number01; //12
            //DivResult = number02 / number01; //3
            //ModResult = number02 % number01; //0
            #endregion
            #region  Assignment operators [= , += , -= , *= , /= , %=]
            //int X;
            //X = 4;
            //X += 2; // x = x + 2
            //X -= 2; // x= x - 2
            //X *= 2; // x = x * 2
            //X /= 2; // x = x / 2
            //X %= 2; // x = x % 2
            #endregion
            #region Relational | comparison Operators [== , != , < , > , <=, >=]
            //int x = 10, y = 10;
            //Console.WriteLine(x == y); // true
            //Console.WriteLine(x != y); // false
            //Console.WriteLine(x > y); // false
            //Console.WriteLine(x < y); // false
            //Console.WriteLine(x >= y); // true
            //Console.WriteLine(x <= y); // true
            #endregion
            #region Logical operators [! , && , ||]
            // Short Circut-----------------------------------------------
            //Console.WriteLine(!true); // false
            //Console.WriteLine(false && true); //false
            // true && true = true
            // true && false = false
            // false && true = false
            // false && false = false
            //Console.WriteLine(false || true); //true
            // true || true = true
            // true || false = true
            // false || true = true
            // false || false = false
            //Console.WriteLine( 4 < 5 && 7 < 9 ); // true
            //Console.WriteLine( 4 < 5 && 7 > 9 ); // false
            //Console.WriteLine( 4 > 5 && 7 < 9 ); // false
            #endregion
            #region  Bitwise operator
            // Long Circut--------------------------------------
            //Console.WriteLine(false & true); //false
            // true & true = true
            // true & false = false
            // false & true = false
            // false & false = false
            //Console.WriteLine(false | true); // true
            // true | true = true
            // true | false = true
            // false | true = true
            // false | false = false
            //Console.WriteLine(false ^ true); // true
            //int X = 5, Y = 3; // X = 0101 , Y = 0011
            //Console.WriteLine(X & Y); // 1 (0101 & 0011 = 0001)
            //Console.WriteLine(X | Y); // 7 (0101 | 0011 = 0111)
            //Console.WriteLine(X ^ Y); // 6 (0101 ^ 0011 = 0110)
            //Console.WriteLine(~X);    // -6 (complement of 0101 is 1010)
            //Console.WriteLine(X << 1); // 10 (1010)
            //Console.WriteLine(X >> 1); // 2 (0010)
            #endregion
            #region ternary operator
            //int x = 10, y = 5;
            //if(x > y)
            //{
            //    Console.WriteLine("x > y");
            //}
            //else
            //{
            //    Console.WriteLine("x < y");
            //}
            //string Message = x > y ? "x > y" : "x < y";
            //Console.WriteLine(Message);
            #endregion
            #region operators pirority and associativity
            //int a = 20;
            //int b = 15;
            //int c = 10;
            //int d = 5;
            //int result;
            //result = (a + b) * c / d;
            //Console.WriteLine(result);
            //result = ((a + b) * c) / d;
            //Console.WriteLine(result);
            //result = (a + b) * c / d++;
            //Console.WriteLine(result);

            #endregion
            #endregion

            #region String Formating
            // Equation : 10 + 5 = 15
            //int Z = 12, Y = 5;
            //int Result = Z + Y;

            // 1-String Interpolation
            //string Message = $"Equation: {Z} + {Y} = {Result}";
            //Console.WriteLine(Message);

            // 2-String.Format Method
            //string Message = string.Format("Equation: {0} + {1} = {2}",Z,Y,Result);
            //Console.WriteLine(Message);

            // 3-Composite Formatting
            //Console.WriteLine("Equation: {0} + {1} = {2}", Z, Y, Result);

            // 4. String Concatenation
            //string Message = "Equation: " + Z + " + " + Y + " = " + Result;
            //Console.WriteLine(Message);
            #endregion

        }
    }
}
