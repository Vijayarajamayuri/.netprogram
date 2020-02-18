using System;

namespace assignmenttest
{
    class Program
    {
        static void Main(string[] args)
        {
            String Name;
            int Age = 0;
            double totalAmount;
            double cost = 7.85;
            Boolean check = false;
            do
            {
                Console.WriteLine("Please Enter the full Name:");
                Name = Console.ReadLine();

                if (string.IsNullOrEmpty(Name))
                {
                    Console.WriteLine("Sorry,Please Enter your name?");
                    Name = Console.ReadLine();
                }




                else
                {
                    Console.WriteLine("The full name is :" + Name);
                }
                try
                {
                    //age
                    Console.WriteLine("Enter your age (>=15, <= 90)?");
                    Age = int.Parse(Console.ReadLine());
                    if (Age < 15)
                    {

                        Console.WriteLine("Your Age is below 15, you cannot book ticket online. Please talk to your parent or guardian!!");
                        Console.WriteLine("Do you want to continue");

                    }
                    else if (Age > 90)
                    {
                        Console.WriteLine("You are too old to watch a movie, sorry!");
                    }
                    else
                    {

                        Console.WriteLine("1.Standard \n 2.Imax \n 3.Imax3D \n Select the Screen Type");
                        int i = int.Parse(Console.ReadLine());


                        if (i == 1 || i == 2)
                        {
                            Console.WriteLine("Enter the number of tickets");
                            int m = int.Parse(Console.ReadLine());
                            if (m > 3)
                            {
                                Console.WriteLine(" You can only buy 1 or 2 or 3 tickets per transaction. Sorry!!");
                            }
                            else
                            {
                                totalAmount = m * cost;
                                Console.WriteLine("the cost for the tickets" + totalAmount);
                            }

                        }


                        //imax 3d screen 3
                        else
                        {
                            Console.WriteLine("Do you want 3D glasses? (y/n)");
                            String x = Console.ReadLine();

                            if (x == "y" || x == "Y")
                            {
                                Console.WriteLine("Extra $2.00 will be charged per ticket for glasses");
                                Console.WriteLine("Enter the number of tickets");
                                int x1 = int.Parse(Console.ReadLine());
                                if (x1 > 3)
                                {
                                    Console.WriteLine(" You can only buy 1 or 2 or 3 tickets per transaction. Sorry!!");

                                }
                                else
                                {
                                    totalAmount = x1 * (cost + 2);
                                    Console.WriteLine("the cost for the tickets" + totalAmount);

                                }


                            }
                            else if (x == "n" || x == "N")
                            {
                                Console.WriteLine("the user will not be charged for the glasses ");

                                Console.WriteLine("Enter the number of tickets");
                                int y1 = int.Parse(Console.ReadLine());
                                if (y1 > 3)
                                {
                                    Console.WriteLine(" You can only buy 1 or 2 or 3 tickets per transaction. Sorry!!");

                                }
                                else
                                {
                                    totalAmount = y1 * cost;
                                    Console.WriteLine("the cost for the tickets" + totalAmount);

                                }

                            }

                        }

                        //int n = int.Parse(Console.ReadLine());
                        //if (n > 3)
                        //{
                        //    Console.WriteLine(" You can only buy 1 or 2 or 3 tickets per transaction. Sorry!!");

                        //}
                        //else {
                        //    totalAmount = n* cost;
                        //    Console.WriteLine("the cost for the tickets" + totalAmount);

                        //}
                        //{
                        //    Console.WriteLine(" You can only buy 1 or 2 or 3 tickets per transaction. Sorry!!");
                        //}
                   
               

