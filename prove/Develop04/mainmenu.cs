using System;

class Program{
    public void ShowMenu()
    {
        string input = "";
        while (input != "4")
        {
            Console.WriteLine("activity Menu:");
            Console.WriteLine();
            Console.WriteLine("1. Breathing exerscise");
            Console.WriteLine("2. Listing activity");
            Console.WriteLine("3. Reflecting activity");
            Console.WriteLine("4. Exit");
            Console.WriteLine();

            Console.WriteLine("Please select an option:");
            input = Console.ReadLine();

            if (input == "1")
            {
                var justBreathe = new Breathing();
                justBreathe.Time;
                justBreathe.breath;
            }
            else if (input == "2")
            {
                var makeList = new listing();
                makeList.Time;
                makeList.Lactivity;
            }
            else if (input == "3")
            {
                var reflection = new reflect();
                reflection.Time;
                reflection.Reflect;
            }
            else if (input == "4")
            {
                Console.WriteLine ("Goodbye, and have a lovely day.");
            }
            else
            {
                Console.WriteLine("I dont think thats an option, Please try again.");
            }
        }
    }
}