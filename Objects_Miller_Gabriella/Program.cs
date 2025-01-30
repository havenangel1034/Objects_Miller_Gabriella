namespace Objects_Miller_Gabriella
{
    internal class Program
    {
        static void Main(string[] args)


        {   // Creating an instance of the Computer class with specified attributes
            Computer myComputer = new Computer("Apple", "All-in-One", true);
            // Assigning the Computer instance to an interface reference (assuming Computer implements IBootUp)
            IBootUp myBootUp = myComputer;
            // Checking if myComputer is equal to myBootUp (likely comparing references)
            Console.WriteLine(myComputer.Equals(myBootUp));

            // Creating another Computer instance with the same attributes as myComputer
            Computer myOtherComputer = new Computer("Apple", "All-in-One", true);
            // Checking if myComputer is equal to myOtherComputer (likely comparing object instances)
            Console.WriteLine(myComputer.Equals(myOtherComputer));

            // Converting myComputer to a string representation
            string myString = myComputer.ToString();
            // Assigning myString to another string variable (both initially hold the same reference)
            string myOtherString = myString;

            // Modifying myString (strings are immutable, so this creates a new string object)
            myString = "Hi!";

            // Printing the modified myString and the unchanged myOtherString
            Console.WriteLine(myString); // Outputs "Hi!"
            Console.WriteLine(myOtherString); // Outputs original string representation of myComputer


            // Checking if myString is equal to the string representation of myComputer
            Console.WriteLine(myString == myComputer.ToString());
            // Checking if myString is equal to myOtherComputer's string representation
            Console.WriteLine(myString == myOtherComputer.ToString());

            // Printing the runtime type of myComputer
            Console.WriteLine(myComputer.GetType());
            // Printing the runtime type of myBootUp (since it's referencing myComputer, the type should be Computer)
            Console.WriteLine(myBootUp.GetType());


            // Toggling the power state of myOtherComputer (assuming PowerOnOff() changes some internal state)
            myOtherComputer.PowerOnOff();

            // Checking if myString is still equal to myOtherComputer's string representation after power change
            Console.WriteLine(myString == myOtherComputer.ToString());
            // Printing myString (remains unchanged)
            Console.WriteLine(myString);
            // Printing myOtherComputer's string representation (which might have changed after PowerOnOff())
            Console.WriteLine(myOtherComputer.ToString());

            // Checking if myString contains the character 'i' (case-sensitive check)
            Console.WriteLine(myString.Contains('i'));

            // Converting myString to uppercase and printing it
            Console.WriteLine(myString.ToUpper());
        }
    }
}