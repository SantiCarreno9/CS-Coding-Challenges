using TestDome;

namespace TestDomeTest
{
    [TestFixture]
    public class BoatMovementTests
    {
        bool[,] gameMatrix =
        {
            {false, true,  true,  false, false, false},
            {true,  true,  true,  false, false, false},
            {true,  true,  true,  true,  true,  true},
            {false, true,  true,  false, true,  true},
            {false, true,  true,  true,  false, true},
            {false, false, false, false, false, false},
        };

        [Test]
        public void ExampleCase()
        {
            Assert.That(BoatMovements.CanTravelTo(gameMatrix, 3, 2, 2, 2), Is.True);// true, Valid move
            Assert.That(BoatMovements.CanTravelTo(gameMatrix, 3, 2, 3, 4), Is.False);// false, Can't travel through land
            Assert.That(BoatMovements.CanTravelTo(gameMatrix, 3, 2, 6, 2), Is.False);// false, Out of bounds
        }

        [Test]
        public void AllCoordinatesInsideGrid()
        {
            Assert.That(BoatMovements.CanTravelTo(gameMatrix, 3, 4, 3, 5), Is.True);
            Assert.That(BoatMovements.CanTravelTo(gameMatrix, 3, 2, 2, 3), Is.False);// false, Out of bounds
        }

        [Test]
        public void SomeCoordinatesAreOutsideGrid()
        {
            Assert.That(BoatMovements.CanTravelTo(gameMatrix, 6, -1, 6, 6), Is.False);// true, Valid move            
        }

    }
}
