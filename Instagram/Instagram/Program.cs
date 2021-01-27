using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using Name;

namespace CS_131_Projects
{
    public class Program
    {



        static void Main()
        {
            string response = "";        
            while (response! = "4")
            {
                Console.WriteLine("1. Luis");
                Console.WriteLine("2. Amanda");
                Console.WriteLine("3. Rod");
                Console.WriteLine("4. Exit");

                Console.WriteLine("");
                Console.WriteLine("Please Select A User");

                response = Console.ReadLine();

                switch (response)
                {
                    case "1":
                        User name1 = new User();
                        name1.UserName = "Luis";
                        name1.Comment = "I love the weather";
                        Console.WriteLine("The user your created is: " + name1.UserName);
                        break;

                    case "2":
                        User name2 = new User();
                        name2.UserName = "Amanda";
                        name2.Comment = "You are the best";
                        Console.WriteLine("The user comment is: " + name2.Comment);
                        break;

                    case "3":
                        User name3 = new User();
                        name3.UserName = "Rod";
                        name3.Comment = "I love it here";
                        Console.WriteLine("The user love the comment: " + name3.Comment);
                        break;


                }

                Console.WriteLine("Your response is: " + response);
            }

        }
    }
}


