using System.Numerics;

namespace assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //#region q1
            //// Write a program that takes a number from the user then print yes
            //// if that number can be divided by 3 and 4 otherwise print no.

            //Console.WriteLine("Enter the Number");
            //int number =Convert.ToInt32(Console.ReadLine());

            //if (number % 3 == 0 && number % 4 == 0)
            //    Console.WriteLine("Yes");
            //else Console.WriteLine("No");

            //#endregion

            //#region q2
            //// Write a program that allows the user to insert an integer then print negative
            //// if it is negative number otherwise print positive

            //Console.WriteLine("Enter the Number");
            //int number = Convert.ToInt32(Console.ReadLine());

            //if (number <0)
            //    Console.WriteLine("negative");
            //else Console.WriteLine("postive");


            //#endregion

            //#region q3
            //// Write a program that takes 3 integers from the user then prints the max element and the min element.


            //Console.WriteLine("Enter the Numbers");
            //int number1 = Convert.ToInt32(Console.ReadLine());
            //int number2 = Convert.ToInt32(Console.ReadLine());
            //int number3 = Convert.ToInt32(Console.ReadLine());

            //if (number1 >= number2 && number1 >= number3)
            //{
            //    Console.WriteLine("maximum number is " + number1);
            //    if (number2 >= number3) Console.WriteLine("minimum number is " + number3);
            //    else Console.WriteLine("minimum number is " + number2);
            //}
            //else if (number2 >= number1 && number2 >= number3)
            //{
            //    Console.WriteLine("maximum number is " + number2);
            //    if (number1 >= number3) Console.WriteLine("minimum number is " + number3);
            //    else Console.WriteLine("minimum number is " + number1);
            //}
            //else { Console.WriteLine("maximum number is " + number3);
            //    if (number1 >= number2) Console.WriteLine("minimum number is " + number2);
            //    else Console.WriteLine("minimum number is " + number1);
            //}


            //#endregion






            //#region q4
            //// Write a program that allows the user to insert an integer number then check If a number is even or odd.

            //Console.WriteLine("Enter the Number");
            //int number = Convert.ToInt32(Console.ReadLine());

            //if (number % 2==0)
            //    Console.WriteLine("the number is even");
            //else Console.WriteLine("the number is odd");


            //#endregion




            #region q5
            //Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u)
            //then print (vowel) otherwise print (consonant).



            Console.WriteLine("Enter the character");
            char character = Convert.ToChar(Console.ReadLine());

            switch (character)
            {
                case 'A': case 'a':
                    Console.WriteLine("vowel");
                    break;

                case 'U':case 'u':
                    Console.WriteLine("vowel");
                    break;

                case 'O':  case 'o':
                    Console.WriteLine("vowel");
                    break;

                case 'I':case 'i':
                    Console.WriteLine("vowel");
                    break;

                case 'E': case 'e':
                    Console.WriteLine("vowel");
                    break;
                default: Console.WriteLine("consonant");
                    break;


            }



            #endregion











        }
    }
}
