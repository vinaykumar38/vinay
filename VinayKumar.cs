using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client_server
{
    internal class Program
    {
        static void Registration()
        {
            Console.Write("enter the num :");
            long number = long.Parse(Console.ReadLine());
            Console.WriteLine("num: " + number);
            Console.Write("enter the name :");
            string name = Console.ReadLine();
            Console.WriteLine("your name is.." + name);
            Console.Write("welcome to watsapp...");
        }
        static void Login()
        {
            Console.Write("enter the num to login :");
            long number = long.Parse(Console.ReadLine());
            Console.WriteLine("num: " + number);
            Console.Write("welcome to watsapp...");
            Console.WriteLine();
            Console.WriteLine("please enter \"1\"for add,\"2\"for edit,and\"3\" for delete");
            string options = Console.ReadLine();
            Console.WriteLine(options);

            if (options == "1")
            {
                Console.Write("enter the num :");
                long phnumber = long.Parse(Console.ReadLine());
                Console.WriteLine("num: " + phnumber);
                Console.Write("enter the name :");
                string Cname = Console.ReadLine();
                Console.WriteLine("your contact is.." + Cname);
                Console.Write("contact added sucessfully...");

            }
            else if (options == "2")
            {
                Console.Write("enter the num :");
                long phnumber = long.Parse(Console.ReadLine());
                Console.WriteLine("num: " + phnumber);
                Console.Write("enter the name :");
                string Cname = Console.ReadLine();
                Console.WriteLine("your contact is.." + Cname);
                Console.Write("contact edited sucessfully");
            }
            else if (options == "3")
            {
                Console.Write("enter the name :");
                string Cname = Console.ReadLine();
                Console.WriteLine("your contact is.." + Cname);
                Console.Write("name deleted sucessfully");

            }
            else
            {
                Console.WriteLine("please enter the num between 1 to 3");
            }




        }



        static void Main(string[] args)
        {
            Console.WriteLine(" select one option login or register");
            string abc = Console.ReadLine();
            if (abc == "login")
            {
                Login();
            }
            else if (abc == "register")
            {
                Registration();

            }
            else
            {
                Console.WriteLine("please select \"Login\" or \"register\" ");
            }
            Console.Read();





        }
    }
}