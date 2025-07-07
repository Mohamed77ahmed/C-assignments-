using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace assignment4

{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region question6
            ////Write a program that allows the user to insert an integer then print all numbers between 1 to that number.

            //Console.WriteLine("please enter number");
            //int number= Convert.ToInt32( Console.ReadLine());

            //for (int i = 1; i <=number ; i++) {
            //    Console.WriteLine(i);
            //}

            #endregion




            #region question7
            ////Write a program that allows the user to insert an integer then 
            ////print a multiplication table up to 12.
            //int number;bool isparsed = false;
            // Console.WriteLine("please enter number");
            //isparsed=int.TryParse(Console.ReadLine(),out number);
            //if (!isparsed) Console.WriteLine("please try again");
            //for (int i = 1; i <= 12; i++)
            //{
            //    Console.WriteLine(i*number);
            //}


            #endregion



            #region question8
            ////Write a program that allows to user to insert number then
            ////print all even numbers between 1 to this number



            //int number; bool isparsed = false;
            //Console.WriteLine("please enter number");
            //isparsed = int.TryParse(Console.ReadLine(), out number);
            //if (!isparsed) Console.WriteLine("please try again");
            //for (int i = 1; i < number; i++)
            //{
            //    if (i % 2 == 0) Console.WriteLine(i);
            //}

            #endregion




            #region question9
            ////Write a program that takes two integers then prints the power


            //int number1,number2,res=1; bool isparsed = false,isparsed2=false;
            //Console.WriteLine("please enter numbers");
            //isparsed = int.TryParse(Console.ReadLine(), out number1);
            //isparsed2 = int.TryParse(Console.ReadLine(), out number2);
            //if (!isparsed||!isparsed2) Console.WriteLine("please try again");

            //for (int i = 1; i <=number2; i++) {

            //     res *= number1;

            //}
            //if(isparsed && isparsed2) Console.WriteLine(res);


            #endregion


            #region question10
            //// Write a program to enter marks of five subjects and calculate total, average and percentage.

            //bool isparsed=false;int num,total=0;
            //Console.WriteLine("please enter number of subjects");
            //isparsed=int.TryParse(Console.ReadLine(), out num);

            //if (!isparsed) Console.WriteLine("please try again");
            //int[] arr = new int[num];
            //for (int i = 0; i <num ; i++) {
            //    Console.WriteLine($"enter mark of sub:{i+1}");
            //    arr[i]=int.Parse( Console.ReadLine() );
            //    total += arr[i];

            //}
            //Console.WriteLine($"total = {total}, average = {total / num} percentage = {total/num}");



            #endregion



            #region question11
            ////Write a program to input the month number and print the number of days in that month

            //bool isparsed = false; int num, day;
            //Console.WriteLine("please enter month number ");
            //isparsed = int.TryParse(Console.ReadLine(), out num);

            //if (!isparsed || !(num>=1 &&num<=12)) Console.WriteLine("please try again");
            //else
            //    Console.WriteLine(DateTime.DaysInMonth(2025, num));




            #endregion


            #region question12
            ////Write a program to create a Simple Calculator.
            //bool isparsed = false, isparsed2 = false; int num1,num2,resault;
            //Console.WriteLine("please enter number1 and number2 ");
            //isparsed = int.TryParse(Console.ReadLine(), out num1);
            //isparsed2 = int.TryParse(Console.ReadLine(), out num2);
            //Console.WriteLine("please enter operator ");
            //string op = Console.ReadLine();
            //if (!isparsed || !isparsed2||(op!="+" && op!="-"&& op != "*"&& op != "/")) Console.WriteLine("please try again");
            //else

            //    if (op == "+") resault = num1 + num2;
            //    else if (op == "-") resault = num1 - num2;
            //    else if (op == "*") resault = num1 * num2;
            //    else resault = num1 / num2;
            //    Console.WriteLine(resault);
            //}


            #endregion

            #region question13

            ////Write a program to allow the user to enter a string and print the REVERSE of it.

            //Console.WriteLine("please enter string");
            //string str= Console.ReadLine();
            //int num = str.Length;

            //for (int i = num-1; i >= 0; i--)
            //{
            //    Console.Write(str[i]);
            //}




            #endregion

            #region question14
            ////Write a program to allow the user to enter int and print the REVERSED of it.


            //bool isparsed = false; int num,resu=0;

            //Console.WriteLine("please enter intger number ");
            //isparsed = int.TryParse(Console.ReadLine(), out num);
            //if (!isparsed) Console.WriteLine("try again");


            //    while (num > 0)
            //    {
            //        int digit = num % 10;
            //        resu = resu*10 + digit;
            //        num /= 10;
            //    }
            //    Console.WriteLine(resu);

            #endregion




            #region question15

            #endregion 



           



            #region question17
            ////Create a program that asks the user to input three points (x1, y1),
            //// (x2, y2), and(x3, y3), and determines whether these points lie on a
            ////single straight line.

            //int[] arrX = new int[3], arrY = new int[3]; int cx = 0, cy = 0;
            //bool parsedx = false, parsedy = false;

            //while (cx != 3 || cy != 3)
            //{

            //    Console.WriteLine("enter points");

            //    for (int i = 0; i <= 2; i++)
            //    {
            //        Console.WriteLine($"enter X{i + 1}for point{i + 1}");
            //        parsedx = int.TryParse(Console.ReadLine(), out arrX[i]);
            //        if (!parsedx) { Console.WriteLine("you entered invaild point"); i--; continue; }
            //        else cx++;

            //        Console.WriteLine($"enter y{i + 1}for point{i + 1}");
            //        parsedy = int.TryParse(Console.ReadLine(), out arrY[i]);
            //        if (!parsedy) { Console.WriteLine("you entered invaild point"); i--; cx--; }
            //        else cy++;
            //    }
            //}
            //if ((arrY[1] - arrY[0]) * (arrX[1] - arrX[0]) == (arrY[1] - arrY[2])*(arrX[1] - arrX[2]))
            //    Console.WriteLine("The points lie on the same straight line");
            //else
            //  Console.WriteLine("The points do NOT lie on the same straight line");


            #endregion



            #region question18
//            /*Within a company, the efficiency of workers is evaluated based on
//the duration required to complete a specific task. A worker&#39;s
//efficiency level is determined as follows:
//- If the worker completes the job within 2 to 3 hours, they are
//considered highly efficient.
//- If the worker takes 3 to 4 hours, they are instructed to increase
//their speed.
//- If the worker takes 4 to 5 hours, they are provided with training to
//enhance their speed.
//- If the worker takes more than 5 hours, they are required to leave the
//company.
//To calculate the efficiency of a worker, the time taken for the task is
//obtained via user input from the keyboard.*/

//            double time; bool ispared = false;
//            do
//            {
//                Console.WriteLine("enter the time your task was completed");
//                ispared = double.TryParse(Console.ReadLine(), out time);
//                if (time == 1) Console.WriteLine("your efficient is very high");
//                else if (time >= 2 && time <= 3) Console.WriteLine("your efficient is high");
//                else if (time >= 3 && time <= 4) Console.WriteLine("you need increase your speed");
//                else if (time >= 4 && time <= 5) Console.WriteLine("training to enhance your speed. ");
//                else if (time>5) Console.WriteLine("you are required to leave the company");

//            } while (!ispared ||(time<1));



            #endregion







        }
    }
}
