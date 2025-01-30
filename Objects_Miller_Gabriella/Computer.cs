using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects_Miller_Gabriella
{

    // The Computer class implements the IBootUp interface (assuming IBootUp is defined elsewhere)
    class Computer : IBootUp
    {
        // Public property to track whether the computer is powered on or off
        public bool IsOn { get; set; }

        // Public property to store the brand of the computer
        public string Brand { get; set; }

        // Public property to store the type of the computer (e.g., "All-in-One", "Laptop")
        public string Type { get; set; }

        // Constructor to initialize a Computer object with brand, type, and power state
        public Computer(string brand, string type, bool isOn)
        {
            Brand = brand;
            Type = type;
            IsOn = isOn;
        }

        // Method to toggle the power state of the computer
        public void PowerOnOff()
        {

            IsOn = !IsOn; 

            if (IsOn == true)
            {
                Console.WriteLine("The computer is booting up!");
            }
            else
            {
                Console.WriteLine("The computer is shutting down!");
            }
        }

        // Overrides the default ToString() method to provide a meaningful string representation of a Computer object
        public override string ToString()
        {
            return $"The computer is made by {Brand} and is a(n) {Type} computer, it is on: {IsOn}!";
        }

    }
}
