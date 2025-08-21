using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects_Harjo_Ryan
{
    internal class Computer : IBootUp
    {
        // Indicates whether the computer is powered on or off
        public bool IsOn { get; set; }
        // Brand of the computer (e.g., Dell)
        public string Brand { get; set; }
        // Type of the computer (e.g., All-in-One, Laptop)
        public string Type { get; set; }
        // Constructor to initialize brand, type, and power state
        public Computer(string brand, string type, bool isOn)
        {
            Brand = brand;
            Type = type;
            IsOn = isOn;
        }
        // Implementation of PowerOnOff method toggles power state and prints status
        public void PowerOnOff()
        {
            // Toggle the power state
            IsOn = !IsOn;
            // Display appropriate message based on power state
            if (IsOn == true)
            {
                Console.WriteLine("The computer is booting up!");
            }
            else
            {
                Console.WriteLine("The computer is shutting down!");

            }

        }
        // Override ToString to provide a meaningful string representation of the object
        public override string ToString()
        {
            return $"The computer is made by {Brand} and is a(n) {Type} computer, it is on: {IsOn}!";
        }

    }
}