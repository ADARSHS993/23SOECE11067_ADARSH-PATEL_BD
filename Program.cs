using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23SOECE11067_ADARSH_PATEL_BD
{
    internal class Program
    {
       public static void Main(string[] args)
        {
            // Console.WriteLine("HELLO WORLD!");
            //        Name: your name

            //DOB: 15 / 10 / 1991

            //Address: 4, xyx society,

            //                 Kalawad Road

            //City: Rajkot

            //Pincode: 360 001

            //State: Gujarat

            //Country: India

            //Email: abc @ymail.com

            Console.WriteLine("Name:");
            string name = Console.ReadLine();
            Console.WriteLine("D.O.B:");
            string dob = Console.ReadLine();
            Console.WriteLine("Address :");
            string add = Console.ReadLine();
            Console.WriteLine("City:");
            string city = Console.ReadLine();
            Console.WriteLine("Pincode:");
            int pin = int.Parse(Console.ReadLine());
            Console.WriteLine("State :");
            string State = Console.ReadLine();
            Console.WriteLine("Country :");
            string c1 = Console.ReadLine();
            Console.WriteLine("Email :");
            string email = Console.ReadLine();
            Console.WriteLine("Name:" + name);
            Console.WriteLine("D.O.B:" + dob);
            Console.WriteLine("Address:" + add);
            Console.WriteLine("City:" + city);
            Console.WriteLine("Pincode:" + pin);
            Console.WriteLine("State:" + State);
            Console.WriteLine("Country:" + c1);
            Console.WriteLine("Email:" + email);






        }
    }
}
