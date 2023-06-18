using System;

namespace MoodAnalyser
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Mood Analyser Program");

            //Creating object of MoodAnalyser class

            MoodAnalyse moodobj = new MoodAnalyse();

            Console.WriteLine("Enter your Mood:");
            string message = Console.ReadLine();

            Console.WriteLine(moodobj.AnalyseMood(message+"Mood"));
        }
    }
}