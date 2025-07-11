using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;

namespace assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region question19
            //// Write a program that prints an identity matrix using for loop, in other words takes
            //// a value n from the user and shows the identity table of size n * n.

            //int size;
            //Console.WriteLine("enter the size of matrix");
            //bool isparsed=int.TryParse(Console.ReadLine(), out  size);
            //if (isparsed && size>0)
            //{
            //    int[,] arr = new int[size,size];
            //    for (int i = 0; i < size; i++)
            //    {
            //        for (int j = 0; j < size; j++)
            //        {
            //            Console.WriteLine($"enter element of({i} , {j})");
            //            arr[i , j] = int.Parse(Console.ReadLine() ??"0");  

            //        }
            //    }
            //    Console.WriteLine($"the matrix : ");
            //    for (int i = 0; i < size; i++)
            //    {
            //        Console.WriteLine("");
            //        for (int j = 0; j < size; j++)
            //        {  
            //            Console.Write($"{arr[i , j]} ");


            //        }
            //    }
            //} else Console.WriteLine("invaild input please try again");

            #endregion

            #region question20

            //Write a program in C# Sharp to find the sum of all elements of the array.

            //int size;
            //Console.WriteLine("enter the size of list");
            //bool isparsed = int.TryParse(Console.ReadLine(), out size);
            //if (isparsed && size > 0)
            //{
            //    int[] arr = new int[size];
            //    for (int i = 0; i < size; i++)
            //    {

            //        Console.WriteLine($"enter element number ({i+1})");
            //            arr[i] = int.Parse(Console.ReadLine() ?? "0");

            //    }
            //    double sum=0;
            //    for (int i = 0; i < size; i++)
            //    {
            //        sum += arr[i];
            //    }
            //    Console.WriteLine($"the sum of elements is {sum}");
            //}
            //else Console.WriteLine("invaild input please try again");

            #endregion


            #region question21
            //// Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.

            //    int[] arr = { 1, 14, 7, 2, 5 };
            //    int[] arr2 = { 70, 30, 3, 90, 74 };
            //    int[] res = new int[arr.Length*2];
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        res[i] = arr[i];
            //        res[arr.Length+i] =arr2[i];

            //    }


            //Array.Sort(res);
            //    for (int i = 0; i < res.Length; i++)
            //    {
            //        Console.WriteLine(res[i]);

            //    }



            #endregion

            #region question22

            //// Write a program in C# Sharp to count the frequency of each element of an array.


            //int size;
            //Console.WriteLine("enter the size of list");
            //bool isparsed = int.TryParse(Console.ReadLine(), out size);
            //if (isparsed && size > 0)
            //{
            //    int[] arr = new int[size];
            //    for (int i = 0; i < size; i++)
            //    {

            //        Console.WriteLine($"enter element number ({i + 1})");
            //        arr[i] = int.Parse(Console.ReadLine() ?? "0");

            //    }
            //   int[] freq = new int[size];
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        int count = 0;

            //        for (int j = 0; j < arr.Length; j++)
            //        {
            //            if (arr[i] == arr[j])  count++; 

            //        }
            //        freq[i] = count;
            //    }

            //    for (int i = 0; i < size; i++) 
            //    { 
            //        bool repeated = true;

            //    for (int j = 0; j <i; j++)
            //        {
            //            if (arr[i] == arr[j])
            //            { repeated = false;
            //                break;
            //            }
            //        }
            //        if (repeated) Console.WriteLine($"element  {arr[i]} is repeated {freq[i]} times ");
            //    }

            //}
            //else Console.WriteLine("invaild input please try again");

            #endregion



            #region question23

            ////Write a program in C# Sharp to find maximum and minimum element in an array

            //int size, min = 999999999, max = 0;
            //Console.WriteLine("enter the size of list");
            //bool isparsed = int.TryParse(Console.ReadLine(), out size);
            //if (isparsed && size > 0)
            //{
            //    int[] arr = new int[size];
            //    for (int i = 0; i < size; i++)
            //    {

            //        Console.WriteLine($"enter element number ({i + 1})");
            //        arr[i] = int.Parse(Console.ReadLine() ?? "0");
            //        if (arr[i] >= max) max = arr[i];
            //        if (arr[i] < min) min = arr[i];

            //    }
            //    Console.WriteLine($"max element = {max}");
            //    Console.WriteLine($"min element = {min}");




            //}
            //else Console.WriteLine("invaild input please try again");
            #endregion


            #region question24
            //// Write a program in C# Sharp to find the second largest element in an array.

            //int size,  max = 0;
            //Console.WriteLine("enter the size of list");
            //bool isparsed = int.TryParse(Console.ReadLine(), out size);
            //if (isparsed && size > 0)
            //{
            //    int[] arr = new int[size];
            //    for (int i = 0; i < size; i++)
            //    {
            //        Console.WriteLine($"enter element number ({i + 1})");
            //        arr[i] = int.Parse(Console.ReadLine() ?? "0");
            //    }
            //    Array.Sort(arr);
            //    Console.WriteLine($"the second largest element is {arr[arr.Length-2]}");

            //}
            //else Console.WriteLine("invalid input please try again");


            #endregion


            #region question25

            //int size, max = 0,dis=0,count=0;
            //Console.WriteLine("enter the size of list");
            //bool isparsed = int.TryParse(Console.ReadLine(), out size);
            //if (isparsed && size > 0)
            //{
            //    int[] arr = new int[size];
            //    for (int i = 0; i < size; i++)
            //    {
            //        Console.WriteLine($"enter element number ({i + 1})");
            //        arr[i] = int.Parse(Console.ReadLine() ?? "0");
            //    }
            //    int[] ld= new int[size*size];
            //    for (int i = 0; i < size; i++)
            //    {
            //        for (int j= 0; j <size; j++)
            //        {
            //            if (arr[i] == arr[j]) { ld[count] = j; } else ld[i] = 0;
            //        }
            //    }
            //    Array.Sort(ld);
            //    Console.WriteLine($"{ld[ld.Length-1]}");

            //}
            //else Console.WriteLine("invalid input please try again");

            #endregion



            #region question26
            ////Given a list of space separated words, reverse the order of the words.

            //int size;
            //Console.WriteLine("enter the size of list");
            //bool isparsed = int.TryParse(Console.ReadLine(), out size);
            //if ( size > 0)
            //{
            //    string[] arr = new string[size];
            //    for (int i = 0; i < size; i++)
            //    {
            //        Console.WriteLine($"enter word number ({i + 1})");
            //        arr[i] = Console.ReadLine();
            //    }
            //    Array.Reverse(arr);
            //    Console.WriteLine("list is : ");

            //    for (int i = 0;i < size; i++)
            //    {
            //        Console.Write($" {arr[i]} ");
            //    }
            //}
            //else Console.WriteLine("invalid input please try again");

            #endregion

        }
    }
}
