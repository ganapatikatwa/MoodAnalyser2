using MoodAnalyser;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;

namespace MoodAnalyserTestProject
{
    [TestClass]
    public class UnitTest1
    {
       
            //Test Case 1.1  Given I am in Sad Mood Message Should return Sad Mood

            [TestMethod]
            public void GivenSADMood_ShouldReturnSAD()
            {

                //Arrange

                string message = "I am in Sad Mood";
                MoodAnalyse obj = new MoodAnalyse(message);

                string expected = "Happy";

                //Act

                string actual = obj.AnalyseMood();

                //Assert

                Assert.AreEqual(expected, actual);
            }
        //Test Case 1.2  Given I am in Happy Mood Message Should return Happy Mood

        [TestMethod]
        public void GivenHappyMoodMessage_ShouldReturnHAPPY()
        {

            //Arrange

            string message = "I am in Happy Mood";
            MoodAnalyse obj = new MoodAnalyse(message);

            string expected = "Happy";

            //Act

            string actual = obj.AnalyseMood();

            //Assert

            Assert.AreEqual(expected, actual);
        }
        //Test Case 2.1 Given Null Mood Should Return Happy


        [TestMethod]
        public void GivenNullMood_ShouldReturnHappy()
        {
            //Arrange
            string message = null;
            MoodAnalyse obj = new MoodAnalyse(message);
            //Act
            string actual = obj.AnalyseMood();
            //Assert
            Assert.AreEqual(actual, "Happy");
        }

    }
}