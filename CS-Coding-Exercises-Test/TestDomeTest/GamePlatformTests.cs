namespace TestDomeTest
{
    [TestFixture]
    public class GamePlatformTests
    {
        [Test]
        public void ExampleExercise()
        {
            const double initialSpeed = 60;
            int[] inclinations = new int[] { 0, 30, 0, -45, 0 };
            double actualResult = GamePlatform.CalculateFinalSpeed(initialSpeed, inclinations);
            double expectedResult = 75;
            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }

        [Test]
        public void SpeedReducedToZeroOrBelow()
        {
            const double initialSpeed = 60;
            int[] inclinations = new int[] { 0, 30, 0, 30, 0 };
            double actualResult = GamePlatform.CalculateFinalSpeed(initialSpeed, inclinations);
            Assert.That(actualResult, Is.AtMost(0));
        }

        [Test]
        public void VariousInclines()
        {
            const double initialSpeed = 60;
            int[] inclinations = new int[] { 15, 0, -15, 30, -45 };
            double actualResult = GamePlatform.CalculateFinalSpeed(initialSpeed, inclinations);
            double expectedResult = 75;
            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }
    }
}
