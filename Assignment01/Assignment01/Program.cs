using System;
using System.Collections.Generic;
using System.Globalization;

namespace Assignment01
{
    class Program
    {
        static int numOfTickets = 0;
        private static string valid;
       static double cost = 7.85;
        static String Name;
        static int count=0;
        static double GrandCost = 0;



        static void Main(string[] args)
        {
            
            int age = 0;
            double totalCost = 0.0D;
            NumberFormatInfo setPrecision = new NumberFormatInfo();
            setPrecision.NumberDecimalDigits = 2;
            Console.WriteLine("**** Welcome to B&B Theatre ****");
            valid = "Y";
                do
                {
                    Console.WriteLine("Please enter the full name :");
                   Name = Console.ReadLine();

                    if (string.IsNullOrEmpty(Name))
                    {
                        Console.WriteLine("sorry, Please enter your name?");
                        Console.WriteLine("Do you want to continue again (y/n)?");
                        valid = Console.ReadLine();
                        continue;
                    }
                

                    try
                    {
                        Console.WriteLine("Enter your age(>=15, <=90)  ?");
                        age = int.Parse(Console.ReadLine());
                        if (age < 15)
                        {
                            Console.WriteLine("Your Age is below 15, you cannot book ticket online. Please talk to your parent or guardian!!");
                            Console.WriteLine("Do you want to continue again (y/n)?");
                        valid = Console.ReadLine();
                            continue;
                        }
                        else if (age > 90)
                        {
                            Console.WriteLine("You are too old to watch a movie, sorry!");
                            Console.WriteLine("Do you want to continue again (y/n)?");
                        valid = Console.ReadLine();
                            continue;
                        }
                        else
                        {
                        Console.WriteLine("1.Standard \n 2.Imax \n 3.Imax3D \n ");
                    }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Sorry, Please enter your age?");
                        Console.WriteLine("Do you want to continue again (y/n)?");
                    valid = Console.ReadLine();
                        continue;
                    }
                    Console.WriteLine("Select the screen type");
                    int screenNum = Int32.Parse(Console.ReadLine());

                    
                    if (screenNum == 1)
                    {
                        Console.WriteLine("You have selected Standard type.");
                        TicketNum();
                    }
                    else if (screenNum == 2)
                    {
                        Console.WriteLine("You have selected Imax type.");
                    TicketNum();
                    }
                    else if (screenNum == 3)
                    {
                        Console.WriteLine("You have selected Imax-3D type.");
                        Console.WriteLine("Do you want 3D glasses (y/n)");
                        String Decision = Console.ReadLine();
                        if (Decision=="y"||Decision=="Y")
                        {
                            Console.WriteLine("Extra 2$ for each ticket will be added");

                        TicketNum();
                            if (numOfTickets <= 3)
                            {
                            totalCost = numOfTickets * (cost + 2);
                                Console.WriteLine("The Total cost of ticket(s) is " + totalCost.ToString("N", setPrecision));
                                Console.WriteLine("Do you want to continue again (y/n)?");
                            valid = Console.ReadLine();
                            }
                            continue;
                        }
                        else if (Decision=="n"||Decision=="N")
                        {
                            Console.WriteLine("Great !!");

                        TicketNum();
                            if (numOfTickets <=3)
                            {
                                totalCost = (numOfTickets * cost);
                                Console.WriteLine("The Total cost of ticket(s) is " + totalCost.ToString("N", setPrecision));
                                Console.WriteLine("Do you want to continue again (y/n)?");
                            valid = Console.ReadLine();
                            }
                            continue;
                        }
                    }

                    if ((screenNum == 1) || (screenNum == 2))
                    {
                        if (numOfTickets <=3)
                        {
                            totalCost = (numOfTickets * cost);
                            Console.WriteLine("The Total cost of ticket(s) is " + totalCost.ToString("N", setPrecision));
                            Console.WriteLine("Do you want to continue again (y/n)?");
                        valid = Console.ReadLine();
                        count = count + numOfTickets;
                        GrandCost = GrandCost + totalCost;
                    }
                        continue;
                    }
                } while (valid.ToLower() == "y");
           
            Console.WriteLine(Name + ", total Number of Tickets are " + count + " and total cost is "+GrandCost + "\n ThankYou have good day");
        }
        
        
            public static void TicketNum()
            {
                Console.WriteLine("Enter number of tickets");
            numOfTickets = Int32.Parse(Console.ReadLine());
          
            if (numOfTickets > 3)
                {
                    Console.WriteLine("You can only buy 1 or 2 or 3 tickets per transaction. Sorry!!");
                    Console.WriteLine("Do you want to continue again (y/n)?");
                valid = Console.ReadLine();
                }

            

            }

        }
    }

