using System;

class reflect{
    int timeInput;
    public void Time(){
        Console.WriteLine("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
        Console.WriteLine("But before we begin, in seconds, how long would you like this activity to go for?");
        timeInput = int.Parse(Console.ReadLine());
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(timeInput);
        DateTime timelimit = futureTime;
    }
    public void Prompts(){
        string[] mainPrompt = {"Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless."};
        string[] subPrompt = {"Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?"};
    }
    private void Reflect(){
        string mP = mainPrompt[randomObject.Next(mainPrompt.Count)];
        Console.WriteLine(mP);
        Thread.Sleep(5000);
         while (startTime <= timelimit){
            string sP = subPrompt[randomObject.Next(subPrompt.Count)];
            Console.WriteLine(sP);
            Thread.Sleep(5000);
         }
    }
}