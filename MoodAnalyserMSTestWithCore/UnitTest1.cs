
using MoodAnalyserAppWithCore;
using MoodAnalyserMSTestWithCore;
 

namespace MoodAnalyserMSTestWithCore
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenSadMoodShouldReturnSAD()
        {
            string expected = "SAD";
            string message = "I am in Sad Mood";

            MoodAnalyser moodAnalyse = new MoodAnalyser(message);

            string mood = moodAnalyse.AnalyseMood();

            Assert.AreEqual(expected, mood);
        }
    }
}