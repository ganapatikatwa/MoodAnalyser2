using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    public class MoodAnalyse
    {
        //Refactor to take message in Constructor
        public string message;
        public MoodAnalyse()
        {

        }

        public MoodAnalyse(string message)
        {
            this.message = message;
        }

        public string AnalyseMood()
        {
            try
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
            catch (Exception ex)
            {
                return "Happy";
            }


        }


    }
}
