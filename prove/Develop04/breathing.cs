using System;

class Breathing{
    int timeInput;
    public void Time(){
        Console.WriteLine("But before we begin, in seconds, how long would you like this activity to go for?");
        timeInput = int.Parse(Console.ReadLine());
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(timeInput);
        DateTime timelimit = futureTime;
    }
    private void breath(){
        Console.WriteLine("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
         while (startTime <= timelimit)
        {
            Console.WriteLine("Breathe in...");
            Console.Write("♥");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("♦");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("♣");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("♠");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.WriteLine("Breathe out...");
            Console.Write("♥");
            Thread.Sleep(1500);
            Console.Write("\b \b");
            Console.Write("♦");
            Thread.Sleep(1500);
            Console.Write("\b \b");
            Console.Write("♣");
            Thread.Sleep(1500);
            Console.Write("\b \b");
            Console.Write("♠");
            Thread.Sleep(500);
            Console.Write("\b \b");
        }
    }
}