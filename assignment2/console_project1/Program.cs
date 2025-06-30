using System.Drawing;
using System.Security.Cryptography.X509Certificates;

class Point
{
    public int x , y ;

}
namespace console_project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region q1
            //Write a program that allows the user to enter a number then print it

            Console.WriteLine("enter the number");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" the number is " + x);

            #endregion


            #region  q2
            //Write C# program that converts a string to an integer, but the string contains
            //non-numeric characters. And mention what will happen 

            string y = "data";
            int convert_y = Convert.ToInt32(y);  //error :string cant convert to int

            #endregion

            #region q3
            //Write C# program that Perform a simple arithmetic operation with floating-point numbers
            //And mention what will happen

            float number1 = 1.5f;
            float number2 = 7.7f;
            Console.WriteLine(number1 * number2);

            #endregion




            #region q4
            //Write C# program that Extract a substring from a given string.

            string name = "mohamed ahmed";
            Console.WriteLine(name.Substring(0, 7));


            #endregion

            #region q5
            //Write C# program that Assigning one value type variable to another
            //and modifying the value of one variable and mention what will happen

            int num1 = 15, num2 = 20;
            Console.WriteLine("before changes");
            Console.WriteLine("num1 = " + num1 + ", num2 = " + num2);


            num1 = num2;
            Console.WriteLine("after changes");
            Console.WriteLine("num1 = " + num1 + ", num2 = " + num2);
            num2 = 10;
            Console.WriteLine("after changes");
            Console.WriteLine("num1 = " + num1 + ", num2 = " + num2);

            #endregion

            #region q6
            //Write C# program that Assigning one reference type variable to another and
            //modifying the object through one variable and mention what will happen

            Point point1 = new Point();
            Point point2 = new Point();
            Console.WriteLine("---before changes---");
            Console.WriteLine(point1.x);
            Console.WriteLine(point2.x);


            point1.x = 5;
            point2.x = 1;

            Console.WriteLine("---after changes---");
            Console.WriteLine(point1.x);
            Console.WriteLine(point2.x);
            point1.x = point2.x;
            Console.WriteLine("---after changes---");
            Console.WriteLine(point1.x);
            Console.WriteLine(point2.x);

            #endregion




            #region q7
            //Write C# program that take two string variables and print them as one variable 



            Console.WriteLine("enter the string 1");
            string string1 = Console.ReadLine();
            Console.WriteLine("enter the string 2");
            string string2 = Console.ReadLine();

            Console.WriteLine(string1 + string2);

            #endregion

            #region 8

            int d;
            d = Convert.ToInt32(!(30 < 20)); //answer is: A value 1 will be assigned to d.




            #endregion




            #region q9
            int d;
            d = Convert.ToInt32(!(30 < 20));
            Console.WriteLine(d);

            Console.WriteLine(13 / 2 + " " + 13 % 2);  //answer is: 6 1
            #endregion

            #region q10

            int num = 1, z = 5;
            if (!(num <= 0))
                Console.WriteLine(++num + z++ + " " + ++z);         //answer is: 7 7
            else
                Console.WriteLine(--num + z-- + " " + --z);
            #endregion

        }
    }
}
