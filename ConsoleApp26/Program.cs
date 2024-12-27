using System;

namespace ConsoleApp26
{
    class Program
    {
        static void Main(string[] args)
        {
            Phone phone = new Phone();
            Console.WriteLine(phone.GetBrand);
            Console.WriteLine(phone.GetBatteryLevel);
            phone.AddBatteryLevel(50);
        }


    }
}