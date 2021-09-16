using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Made By Erik Avakian

namespace ProgProv2_ABONEMANG
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();


            List<subscriptionPlan> allabonemangList = new List<subscriptionPlan>
            {
                new subscriptionPlan("Comviq Standard", 4, 100, 1200),
                new subscriptionPlan("Comviq Plus", 8, 150, 1800),
                new subscriptionPlan("Comviq Kompis", 16, 220, 2640),
                new subscriptionPlan("Comviq Omega", 32, 330, 3960)
            };

            int currentSubscription = 0;
            int quit = 0;
            while (quit == 0)
            {
                Console.Clear();

                Console.WriteLine("Welcome " + user.userName);
                Console.WriteLine();
                Console.WriteLine("-- Subscription Plan Options --");

                Console.WriteLine("1: View Current");
                Console.WriteLine("2: Browse");
                Console.WriteLine("3: Change");
                Console.WriteLine("4: Quit");
                Console.WriteLine("Make a choice: ");

                int choice = int.Parse(Console.ReadLine());
                Console.Clear();

                if (choice == 1) // Print Subscriptionplan info
                {
                    Console.Clear();
                    Console.WriteLine("Here is your Current Subscriptionplan");
                    Console.WriteLine();
                    string currentSubscriptionPlan = allabonemangList[currentSubscription].GetSubscriptionPlanInfo();
                    Console.WriteLine(currentSubscriptionPlan);
                    Console.WriteLine();

                }
                else if (choice == 2)
                {
                    //Goes thru all of the subscriptionPlans
                    for (int i = 0; i < allabonemangList.Count; i++)
                    {
                        //Gives the info on the different subscriptionplans
                        string currentSubscriptionPlan = i + 1 + ": " + allabonemangList[i].GetSubscriptionPlanInfo();
                        Console.WriteLine(currentSubscriptionPlan);
                        Console.WriteLine();
                    }

                }


                else if (choice == 3) //Change Subscriptionplan
                {
                    //Goes thru all of the subscriptionPlans
                    for (int i = 0; i < allabonemangList.Count; i++)
                    {
                        //Gives the info on the different subscriptionplans
                        string currentSubscriptionPlan = i + 1 + ": " + allabonemangList[i].GetSubscriptionPlanInfo();
                        Console.WriteLine(currentSubscriptionPlan);
                        Console.WriteLine();
                    }

                    Console.WriteLine("Choose what Subscriptionplan you want to change to.");
                    choice = int.Parse(Console.ReadLine());


                    if (choice == 1)
                    {
                        currentSubscription = 0;
                        Console.Clear();
                        Console.WriteLine("This is your Current plan");

                    }
                    else if (choice == 2)
                    {
                        Console.Clear();
                        currentSubscription = 1;
                        Console.WriteLine(" Congratulations You have changed your subscriptionplan to Comviq Plus!!!");
                    }
                    else if (choice == 3)
                    {
                        Console.Clear();
                        currentSubscription = 2;
                        Console.WriteLine(" Congratulations You have changed your subscriptionplan to Comviq Kompis!!!");

                    }
                    else if (choice == 4)
                    {
                        Console.Clear();
                        currentSubscription = 3;
                        Console.WriteLine(" Congratulations You have changed your subscriptionplan to Comviq Omega!!!");

                    }
                    else if (choice < 5)
                    {
                        Console.Clear();
                        Console.WriteLine("Sorry this was not an option");
                    }
                    else if (choice >= 0)
                    {
                        
                        Console.Clear();
                        Console.WriteLine("Sorry this was not an option");
                    }

                }
                else if (choice == 4) //Quit
                {
                    quit = 1;
                }


                else
                {
                    Console.WriteLine();
                    Console.WriteLine("That was not an Option, please choose again :) ");

                    Console.ReadLine();
                }

                Console.Write("Press any key...");
                Console.ReadKey();
            }
            //Funkar som en paus
            Console.ReadLine();
        }
    }
}
