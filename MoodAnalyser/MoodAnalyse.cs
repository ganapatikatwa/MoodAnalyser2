using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    public class MoodAnalyse
    {
        public string message;
        public MoodAnalyse()
        {

        }
        public MoodAnalyse(string message)
        {
            this.message = message;
        }
        public string AnalyseMood(string message)
        {
            try
            {
                if (message.ToUpper().Contains("SAD"))
                {
                    return "Sad Mood";
                }
                else if(message.ToUpper().Contains("HAPPY"))
                {
                    return "Happy Mood";
                }
                else
                {
                    throw (new Exception("null"));
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        
        }
    }
}
