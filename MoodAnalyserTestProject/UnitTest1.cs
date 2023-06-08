using MoodAnalyser;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;

namespace MoodAnalyserTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Test Case 1.1  Given I am in Sad Mood Should return Sad Mood

            //Arrange
            MoodAnalyse obj = new MoodAnalyse();
            string message = "I am in happy Mood";
            string expected = "Happy Mood";
            //act
            string actual = obj.AnalyseMood(message);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AnyMood()
        {
            MoodAnalyse obj = new MoodAnalyse();
            string message = "I am in Any Mood";
            string expected = "Happy Mood";
            //act
            string actual = obj.AnalyseMood(message);
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}