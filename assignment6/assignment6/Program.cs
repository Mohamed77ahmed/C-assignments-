using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Reflection.Metadata;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace assignment6
{
    internal class Program
    {


        static void swap(int x,int y)
        {
            int temp = x;
            x = y;
            y=temp;
        }

        static void swapref(ref int x,ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
        static int sumarray(int[] arr)
        {
            int sum = 0;
            arr[0] = 70;
            if (arr?.Length > 0) {
                for (int i = 0; i < arr.Length; i++)
                {
                    sum += arr[i];
                }
            }
            return sum; 

        }
        static int sumarrayref( ref int[] arr)
        {
            int sum = 0;
            arr[0] = 70;
            if (arr?.Length > 0)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    sum += arr[i];
                }
            }
            return sum;
        }



        static void SumSub(int x,int y,out int sum,out int sub)
        {
            sum = x + y;
            sub = x - y;
        }


        static int SumDigit(int number)
        {
            int sum = 0;
            while (number!=0) {
                sum += number % 10;             
                number /= 10;


            }
            return sum;
        }
       
        
        static void MinMaxArray(int[] arr,out int max,out int min)
        {
            max = 0; min = 999999999;   
            if (arr?.Length != 0)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i]>=max)  max = arr[i];
                    if (arr[i]<=min)  min = arr[i];
                }
            }
        }

        static int factorial(int number) {

            int fact = 1;
            for (int i = number; i >1; i--) {
                fact *=i;
            }
            return fact;
        }



        static bool IsPrime(int number)
        {
            if (number <= 1)
                return false;

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                    return false; 
            }

            return true; 
        }

        static string ChangeChar(string text, int position, char newchar)
        {
            char[] chars = text.ToCharArray();
            chars[position]= newchar;
            return new string(chars);
        
        }

        static void Main(string[] args)
        {


            #region question1
            ////Explain the difference between passing (Value type parameters)
            ////by value and by reference then write a suitable c#example.


            ///*
            //  1. Pass by Value (Default Behavior)
            //   A copy of the value is passed to the method.
            //   Changes made inside the method do not affect the original variable.

            //  2. Pass by Reference
            //   You use the ref keyword to pass a reference to the original variable.
            //   Changes made inside the method do affect the original variable.
            //*/

            ////pass by value  
            //int x = 5,y=4;
            //Console.WriteLine("----------------before swapping----------------");
            //Console.WriteLine(x);
            //Console.WriteLine(y);
            //Console.WriteLine("----------------after swapping----------------");
            //swap(x,y);
            //Console.WriteLine(x);
            //Console.WriteLine(y);



            ////pass by referance
            //int a = 5, b = 4;
            //Console.WriteLine("----------------before swapping----------------");
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine("----------------after swapping----------------");
            //swapref(ref a,ref b);
            //Console.WriteLine(a);
            //Console.WriteLine(b);


            #endregion



            #region question2

            ////Explain the difference between passing (Reference type parameters)
            ////by value and by reference then write a suitable c# example.

            ///*
            //  1. Passing by Value (Default for Reference Types)
            //   The reference itself is passed by value.
            //   The method gets a copy of the reference, pointing to the same object.
            //   So, modifying the object's internal data affects the original.
            //   But if you assign a new object to the parameter, the original reference is not affected.

            //  2. Passing by Reference
            //   Use the ref keyword.
            //   The reference itself is passed by reference.
            //   So, if you assign a new object or modify the existing one, the original reference in the caller is updated
            //*/

            ////pass by value
            //int [] arr = { 1, 2, 3 ,4,5,6,7,8,9,10};
            //Console.WriteLine("before");
            //Console.WriteLine(arr[0]);
            //Console.WriteLine("after");
            //int res= sumarray(arr);
            //Console.WriteLine($"{arr[0]}");


            ////pass by referance
            //int[] arr02 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //Console.WriteLine("before");
            //Console.WriteLine(arr[0]);
            //Console.WriteLine("after");
            //int res02 = sumarray(arr);
            //Console.WriteLine($"{arr[0]}");


            #endregion


            #region question3

            ////Write a c# Function that accept 4 parameters from user and
            //// return result of summation and subtracting of two numbers
            //int x, y;
            //Console.WriteLine("enter number1");
            //x = int.Parse(Console.ReadLine());
            //Console.WriteLine("enter number2");
            //y = int.Parse(Console.ReadLine());

            //SumSub(x,y,out int sum,out int sub);
            //Console.WriteLine($"sum is {sum}");
            //Console.WriteLine($"sub is {sub}");


            #endregion



            #region question4
            //            /*Write a program in C# Sharp to create a function to calculate the sum of
            //            the individual digits of a given number.
            //            Output should be like
            //Enter a number: 25
            //The sum of the digits of the number 25 is: 7
            //            */
            //            int x,Result;
            //            Console.WriteLine("enter the number");
            //            x = int.Parse(Console.ReadLine());
            //            Result=SumDigit(x);
            //            Console.WriteLine($"sum of digit is : {Result}");


            #endregion



            #region question5
            ////Create a function named "IsPrime", which receives an integer number
            ////and retuns true if it is prime, or false if it is not:

            //Console.WriteLine("enter number");
            //int x=int.Parse(Console.ReadLine());

            //if(IsPrime(x)) Console.WriteLine($" {x} is a prime number ");
            //else Console.WriteLine($"{x} is not a prime number ");



            #endregion




            #region question6

            ////Create a function named MinMaxArray, to return the minimum and
            ////maximum values stored in an array, using reference parameters
            //int size;

            //Console.WriteLine("enter length of the list ");
            //size=int.Parse(Console.ReadLine());
            //int[] arr = new int[size];
            //for (int i = 0; i < size; i++)
            //{
            //    Console.WriteLine($"enter element number {i+1}");
            //    arr[i]= int.Parse(Console.ReadLine());
            //}

            //MinMaxArray(arr, out int max, out int min);
            //Console.WriteLine($"The Max element in list is : {max}");
            //Console.WriteLine($"The Min element in list is : {min}");



            #endregion



            #region question7

            ////Create an iterative (non-recursive) function to calculate the factorial
            ////of the number specified as parameter

            //Console.WriteLine("please enter number");
            //int x = int.Parse(Console.ReadLine());

            //int fact = factorial(x);
            //Console.WriteLine($"factorial of {x} is {fact}");
            #endregion

            #region question8

        //    /*Create a function named "ChangeChar" to modify a letter in a certain
        //     position (0 based) of a string, replacing it with a different letter*/
        //    Console.WriteLine("enter the  word");
        //    string word=Console.ReadLine();
        //    Console.WriteLine("enter position");
        //    int pos = int.Parse(Console.ReadLine());
        //    Console.WriteLine("enter new char");
        //    char newchar = char.Parse(Console.ReadLine());

        //string output=ChangeChar(word, pos, newchar);
        //    Console.WriteLine($"string after changes : {output}");

            #endregion
        }
    }
}
