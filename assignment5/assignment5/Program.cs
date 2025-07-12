namespace assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region question19

            ////Write a program that prints an identity matrix using for loop, in other words takes
            ////a value n from the user and shows the identity table of size n * n.
            //int size;
            //Console.WriteLine("enter size of matrix");
            //bool isparsed = int.TryParse(Console.ReadLine(), out size);
            //int[,] arr = new int[size,size];
            //if (isparsed &&size>0)
            //{
            //    for (int i = 0; i < size; i++)
            //    {
            //        for (int j = 0; j < size; j++)
            //        {
            //            Console.WriteLine($"enter element of ({i} , {j})");
            //            arr[i, j] = int.Parse(Console.ReadLine() ?? "0");
            //        }
            //    }
            //    Console.WriteLine("matrix is");
            //    for (int i = 0; i < size; i++)
            //    {
            //        Console.WriteLine("");
            //        for (int j = 0; j < size; j++)
            //        {
            //            Console.Write($"{arr[i,j]} ");

            //        }
            //    }
            //} else Console.WriteLine("invalid input ,try again");
            #endregion


            #region question20
            ////Write a program in C# Sharp to find the sum of all elements of the array.

            //int size;int res = 0;
            //Console.WriteLine("enter size of list");
            //bool isparsed = int.TryParse(Console.ReadLine(), out size);
            //int[] arr = new int[size];
            //if (isparsed && size > 0)
            //{
            //    for (int i = 0; i < size; i++)
            //    {
            //            Console.WriteLine($"enter element of {i+1}");
            //            arr[i] = int.Parse(Console.ReadLine() ?? "0");
            //        res += arr[i];

            //    }
            //    Console.WriteLine($"sum of elements : {res}");              
            //}
            //else Console.WriteLine("invalid input ,try again");
            #endregion


            #region question21

            ////Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.

            //int size; int res = 0;
            //Console.WriteLine("enter size of list1 and list2");
            //bool isparsed = int.TryParse(Console.ReadLine(), out size);
            //int[] arr = new int[size];     int[] arr2 = new int[size];
            //int[] merge= new int[size*2];


            //if (isparsed && size > 0)
            //{
            //    for (int i = 0; i < size; i++)
            //    {
            //        Console.WriteLine($"enter element of list1 {i + 1}");
            //        arr[i] = int.Parse(Console.ReadLine() ?? "0");
            //    }

            //    for (int i = 0; i < size; i++)
            //    {
            //        Console.WriteLine($"enter element of list2 {i + 1}");
            //        arr2[i] = int.Parse(Console.ReadLine() ?? "0");
            //    }

            //    for (int i = 0; i < size; i++)
            //    {
            //        merge[i]=arr[i];   merge[i+size]=arr2[i];
            //    }
            //    Array.Sort(merge);
            //    Console.WriteLine("merged and sorted list1,2 ");
            //    for (int i = 0;i < merge.Length; i++)
            //    {
            //        Console.WriteLine(merge[i]); 
            //    }
            //}
            //else Console.WriteLine("invalid input ,try again");

            #endregion


            #region question22

            ////Write a program in C# Sharp to count the frequency of each element of an array.

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
            //    int[] freq = new int[size];
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        int count = 0;
            //        for (int j = 0; j < arr.Length; j++)
            //        {
            //            if (arr[i] == arr[j]) count++;

            //        }
            //        freq[i] = count;
            //    }
            //    for (int i = 0; i < size; i++)
            //    {
            //        bool isFirst = true;

            //        for (int j = 0; j < i; j++)
            //        {
            //            if (arr[i] == arr[j])
            //            {
            //                isFirst = false;
            //                break;
            //            }
            //        }

            //        if (isFirst)
            //            Console.WriteLine($"element  {arr[i]} is repeated {freq[i]} times ");
            //    }

            //}
            //else Console.WriteLine("invalid input please try again");
            #endregion


            #region question23

            ////Write a program in C# Sharp to find maximum and minimum element in an array

            //int size; int max = 0, min=999999999;
            //Console.WriteLine("enter size of list");
            //bool isparsed = int.TryParse(Console.ReadLine(), out size);
            //int[] arr = new int[size];
            //if (isparsed && size > 0)
            //{
            //    for (int i = 0; i < size; i++)
            //    {
            //        Console.WriteLine($"enter element of {i + 1}");
            //        arr[i] = int.Parse(Console.ReadLine() ?? "0");
            //        if (arr[i] > max) max = arr[i];
            //        if (arr[i] <min) min = arr[i];

            //    }
            //    Console.WriteLine($"max element : {max} and min element : {min} ");
            //}
            //else Console.WriteLine("invalid input ,try again");
            #endregion

            #region quwstion24
            ////Write a program in C# Sharp to find the second largest element in an array.

            //int size;
            //Console.WriteLine("enter size of list");
            //bool isparsed = int.TryParse(Console.ReadLine(), out size);
            //int[] arr = new int[size];
            //if (isparsed && size > 0)
            //{
            //    for (int i = 0; i < size; i++)
            //    {
            //        Console.WriteLine($"enter element of {i + 1}");
            //        arr[i] = int.Parse(Console.ReadLine() ?? "0");

            //    }
            //    Array.Sort(arr);
            //    Console.WriteLine($" second max element is : {arr[arr.Length-2]}  ");
            //}
            //else Console.WriteLine("invalid input ,try again");

            #endregion


            #region question25


            
            int size, max = 0,dis=0; int count = 0;
            Console.WriteLine("enter the size of list");
            bool isparsed = int.TryParse(Console.ReadLine(), out size);
            if (isparsed && size > 0)
            {
                int[] arr = new int[size];
                for (int i = 0; i < size; i++)
                {
                    Console.WriteLine($"enter element number ({i + 1})");
                    arr[i] = int.Parse(Console.ReadLine() ?? "0");
                }
                int[] ld= new int[size*size];
                for (int i = 0; i < size; i++)
                {
                    
                    for (int j= 0; j <size; j++)
                    {
                        if (arr[i] == arr[j]) { ld[count] = j; } else ld[count] = 0;
                        count++;
                    }
                }
                Array.Sort(ld);
                Console.WriteLine($"{ld[ld.Length-1]}");

            }
            else Console.WriteLine("invalid input please try again");


            #endregion


            #region question26

            ////Given a list of space separated words, reverse the order of the words.

            //int size;
            //Console.WriteLine("enter size of list");
            //bool isparsed = int.TryParse(Console.ReadLine(), out size);
            //string[] arr = new string[size];
            //if (isparsed && size > 0)
            //{
            //    for (int i = 0; i < size; i++)
            //    {
            //        Console.WriteLine($"enter word {i + 1}");
            //        arr[i] = Console.ReadLine() ?? "0";
            //    }

            //    Array.Reverse(arr);
            //    Console.WriteLine($"reversed list is");
            //    for (int i = 0;i < size; i++)
            //    {

            //        Console.Write($" {arr[i]} ");

            //    }   
            //}
            //else Console.WriteLine("invalid input ,try again");

            #endregion


            #region question27

            //// Write a program to create two multidimensional arrays of same size.
            //// Accept value from user and store them in first array. Now copy all
            //// the elements of first array on second array and print second array.


            //int size;
            //Console.WriteLine("enter size of matrix");
            //bool isparsed = int.TryParse(Console.ReadLine(), out size);
            //int[,] arr = new int[size,size];
            //int[,] arr2 = new int[size,size];
            //if (isparsed && size > 0)
            //{
            //    for (int i = 0; i < size; i++)
            //    {
            //        for (int j = 0; j < size; j++)
            //        {

            //            Console.WriteLine($"enter element of matrix1 ({i} , {j})");
            //            arr[i,j] = int.Parse(Console.ReadLine() ?? "0");
            //            arr2[i,j]=arr[i,j];
            //        }
            //    }

            //    Console.WriteLine("matrix 2 is");
            //    for (int i = 0; i < size; i++)
            //    {
            //        Console.WriteLine(" ");
            //        for (int j = 0; j < size; j++)
            //        {
            //            Console.Write($" {arr2[i,j]} ");

            //        }
            //    }

            //}
            //else Console.WriteLine("invalid input ,try again");

            #endregion

            #region question28

            //Write a Program to Print One Dimensional Array in Reverse Order

            //int size;
            //Console.WriteLine("enter size of list");
            //bool isparsed = int.TryParse(Console.ReadLine(), out size);
            //int[] arr = new int[size];
            //if (isparsed && size > 0)
            //{
            //    for (int i = 0; i < size; i++)
            //    {
            //        Console.WriteLine($"enter word {i + 1}");
            //        arr[i] =int.Parse( Console.ReadLine() ??"0");
            //    }

            //    Array.Reverse(arr);
            //    Console.WriteLine($"reversed list is");
            //    for (int i = 0; i < size; i++)
            //    {

            //        Console.Write($" {arr[i]} ");

            //    }
            //}
            //else Console.WriteLine("invalid input ,try again");

            #endregion

















        }
    }
}
