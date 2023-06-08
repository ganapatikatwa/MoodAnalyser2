using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    public class MoodAnalyse
    {
        public string HAPPYMOOD = "Happy";
        public string SADMOOD = "Sad";
        public string AnalyseMood(string message)
        {
            if (message.ToUpper().Contains("SAD"))
            {
                return "Sad Mood";
            }
            else
            {
                return "Happy Mood";
            }

        }
    }
}
