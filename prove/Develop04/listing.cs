using System;

 class listing
 {
    int timeInput;
    public void Time(){
        Console.WriteLine("But before we begin, in seconds, how long would you like this activity to go for?");
        timeInput = int.Parse(Console.ReadLine());
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(timeInput);
        DateTime timelimit = futureTime;
    }
    public void Lactivity()
    {
        string[] prompt = {"Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"};
        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        while (startTime <= timelimit)
        {
            string Pr = prompt[randomObject.Next(prompt.5)];
            Console.WriteLine(Pr);
            Console.ReadLine();
            Thread.Sleep(3000);
        }
    }
 }