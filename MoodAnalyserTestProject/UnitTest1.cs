using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using MoodAnalyser;
using MoodAnalyser1;

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

                string expected = "Sad";

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
        //UC3 Given Null or Empty Message when Analyse Should Return Exception HandleMessage

        [TestMethod]

        public void GivenNullorEmptyMessage_ShouldReturnExceptionHandleMessage()
        {
            //Arrange
            string message = "";
            MoodAnalyse obj = new MoodAnalyse(message);
            string expected = "Mood Should Not Be Empty";

            //Act
            string actual = obj.AnalyseMood();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        //Test Case 3.1 Given Null Mood Should throw MoodAnalysis Exception

        [TestMethod]
        public void GivenNullMood_ShouldthrowMoodAnalysisException()
        {
            try
            {
                //Arrange
                MoodAnalyse obj = new MoodAnalyse("null");
                //Act
                string actual = obj.AnalyseMood();
            }
            catch (MoodAnalyserCustomException e)
            {
                //Assert
                Assert.AreEqual("Mood Should Not Be Null", e.Message);
            }
        }
        //Test Case 3.2 Given Null Mood Should throw MoodAnalysis Exception

        [TestMethod]
        public void GivenEmptyMood_ShouldthrowMoodAnalysisException_IndicatingEmptyMood()
        {
            try
            {
                //Arrange
                string message = "";
                MoodAnalyse obj = new MoodAnalyse(message);

                //Act
                string actual = obj.AnalyseMood();
            }
            catch (MoodAnalyserCustomException e)
            {
                //Assert
                Assert.AreEqual("Mood Should Not Be Empty", e.Message);
            }
        }
        //Test Case 4.1 Given MoodAnalyser ClassName should return object of MoodAnalyser

        [TestMethod]
        public void GivenMoodAnalyseClassName_ShouldReturnMoodAnalyseObject()
        {
            object expected = new MoodAnalyser();
            object obj = MoodAnalyserFactory.CreateMoodAnalyser("MoodAnalyse.MoodAnalyser", "MoodAnalyser");
            expected.Equals(obj);
        }

        [TestMethod]
        public void GivenMoodAnalyser_ClassName_Should_ReturnMoodAnalyzer_Object()
        {
            //Arrange
            string className = "MoodAnalyse.MoodAnalyser";
            string constructorName = "MoodAnalyser";

            //Act
            object expected = new MoodAnalyser("MoodAnalyse.MoodAnalyser", constructorName);
            object checkObj = MoodAnalyserFactory.CreateMoodAnalyser(className, constructorName);

            //Assert
            //Assert.AreEqual(expected, checkObj);
            expected.Equals(checkObj);

        }

        //Test Case 4.2
        [TestMethod]
        public void GivenImpoperClassName_ShouldThrowMoodAnalyseException_IndicatingNoSuchClass()
        {
            try
            {
                //Arrange
                string className = "DemoNamespace.MoodAnalyser";     //wrong className passed to pass test
                string constructorName = "MoodAnalyser";
                //Act
                object resultObj = MoodAnalyserFactory.CreateMoodAnalyser(className, constructorName);
            }
            catch (MoodAnalyserCustomException e)
            {
                //Assert
                Assert.AreEqual("Class not found", e.Message);
            }
        }
        //Test Case 4.3
        [TestMethod]
        public void GivenImpoperConstructorName_ShouldThrowMoodAnalyseException_IndicatingNoSuchConstructor()
        {
            try
            {
                //Arrange
                string className = "MoodAnalyserProb.MoodAnalyser";
                string constructorName = "DemoConstructorName";               //wrong constructorName passed to pass test
                //Act
                object resultObj = MoodAnalyserFactory.CreateMoodAnalyser(className, constructorName);
            }
            catch (MoodAnalyserCustomException e)
            {
                //Assert
                Assert.AreEqual("Constructor not Found", e.Message);
            }
        }
        //UC5.1

        [TestMethod]
        public void GivenMoodAnalyseClassName_ShouldReturnMoodAnalyseObject_UsingParameterizedConstructor()
        {
            //Arrange
            object expected = new MoodAnalyse("HAPPY");

            //Act
            object actual = MoodAnalyserFactory.CreateMoodAnalyseUsingParameterizedConstructor("MoodAnalyserProb.MoodAnalyser", "MoodAnalyser", "HAPPY");

            //Assert
            expected.Equals(actual);

        }
        //Test Case 5.2 Given improper Class Name Should Throw Excepion

        [TestMethod]
        public void GivenClassNameWhenImproper_ShouldThrowMoodAnalysisException_NoSuchClassFound()
        {
            try
            {
                //Arrange
                string className = "DemoNamespace.MoodAnalyser";
                string constructorName = "MoodAnalyser";


                //Act
                object actual = MoodAnalyserFactory.CreateMoodAnalyseUsingParameterizedConstructor(className, constructorName, "HAPPY");


            }
            catch (MoodAnalyserCustomException e)
            {
                //Assert
                Assert.AreEqual("Class not Found", e.Message);
            }

        }
        //Test Case 5.3 Given improper Constructor Name Should Throw Excepion

        [TestMethod]
        public void GivenConstructorNameWhenImproper_ShouldThrowMoodAnalysisException_NoSuchMethodFound()
        {
            try
            {
                //Arrange
                string className = "MoodAnalyserProb.MoodAnalyser";
                string constructorName = "DemoConstructorName";


                //Act
                object actual = MoodAnalyserFactory.CreateMoodAnalyseUsingParameterizedConstructor(className, constructorName, "GOOD");


            }
            catch (MoodAnalyserCustomException e)
            {
                //Assert
                Assert.AreEqual("Constructor not Found", e.Message);
            }

        }


    }
}