using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    public class Person
    {
        public string? name;
        public int age;
        public void ReadData()
        {
            Console.Write("enter name:");
            name = Console.ReadLine();
            Console.Write("enter age:");
            age = Convert.ToInt32(Console.ReadLine());
        }
        public void DisplayData()
        {
            Console.WriteLine("\n--- Person Details ---");
            Console.WriteLine("Name:" + name);
            Console.WriteLine("age: " + age);
        }
    }
}