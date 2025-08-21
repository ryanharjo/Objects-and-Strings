namespace Objects_Harjo_Ryan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a new Computer object with brand "Dell", type "All-in-One", and powered on (true)
            Computer myComputer = new Computer("Dell", "All-in-One", true);
            // Cast the Computer object to an interface type IBootUp
            IBootUp myBootUp = myComputer;
            // Check if the Computer object equals the IBootUp interface reference (should be true since they refer to the same object)
            Console.WriteLine(myComputer.Equals(myBootUp));
            // Create another Computer object with the same values
            Computer myOtherComputer = new Computer("Dell", "All-in-One", true);
            // Check if the two Computer objects are equal based on the overridden Equals method
            Console.WriteLine(myComputer.Equals(myOtherComputer));

            // Call ToString() method on myComputer and store the result in myString
            string myString = myComputer.ToString();
            // Check if the string representation of myComputer is equal to myString (should be true)
            Console.WriteLine(myString == myComputer.ToString());
            // Check if the string representation of myOtherComputer is equal to myString (depends on ToString implementation)
            Console.WriteLine(myString == myOtherComputer.ToString());
            // Print the type of myComputer (should print "Computer")
            Console.WriteLine(myComputer.GetType());
            // Print the type of myBootUp (even though it's an interface reference, the underlying type is Computer)
            Console.WriteLine(myBootUp.GetType());
            // Call a method PowerOnOff on myOtherComputer (probably toggles the power state)
            myOtherComputer.PowerOnOff();
            // Check again if myString is equal to the string representation of myOtherComputer after toggling power
            Console.WriteLine(myString == myOtherComputer.ToString());
            // Check if myString contains the character 'i'
            Console.WriteLine(myString.Contains('i'));
            // Print myString in uppercase letters
            Console.WriteLine(myString.ToUpper());


        }
    }
}
