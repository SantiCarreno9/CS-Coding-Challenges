using static TestDome.RoutePlanner;

namespace TestDomeTest
{
    [TestFixture]
    public class RoutePlannerTests
    {
        bool[,] mapMatrix = {
            {true, false, false},
            {true, true, false},
            {false, true, true}
        };

        bool[,] mapMatrix2 = {
            {true, false, true, false},
            {true, true, false, true},
            {false, true, true, false},
            {false, false, true, true}
        };

        [Test]
        public void FalseIfStartsFromFalse()
        {
            Assert.That(RouteExists(0, 1, 0, 0, mapMatrix), Is.False);
            Assert.That(RouteExists(2, 0, 1, 1, mapMatrix), Is.False);

            Assert.That(RouteExists(0, 1, 0, 2, mapMatrix2), Is.False);
            Assert.That(RouteExists(2, 2, 2, 3, mapMatrix2), Is.False);
        }

        [Test]
        public void FalseIfDestinationIsFalse()
        {
            Assert.That(RouteExists(0, 0, 0, 1, mapMatrix), Is.False);
            Assert.That(RouteExists(1, 1, 2, 0, mapMatrix), Is.False);
        }

        [Test]
        public void FalseIfStartIsOutsideMap()
        {
            Assert.That(RouteExists(-1, 0, 0, 0, mapMatrix), Is.False);
            Assert.That(RouteExists(5, 5, 2, 0, mapMatrix), Is.False);
        }

        [Test]
        public void FalseIfDestinationIsOutsideMap()
        {
            Assert.That(RouteExists(0, 0, 0, -1, mapMatrix), Is.False);
            Assert.That(RouteExists(1, 0, -2, 5, mapMatrix), Is.False);
        }

        [Test]
        public void FalseIfNotReachable()
        {
            Assert.That(RouteExists(0, 0, 1, 2, mapMatrix2), Is.False);
            Assert.That(RouteExists(0, 2, 1, 2, mapMatrix2), Is.False);
        }

        [Test]
        public void TrueIfReachable()
        {
            Assert.That(RouteExists(1, 1, 2, 1, mapMatrix), Is.True);
            Assert.That(RouteExists(1, 0, 0, 0, mapMatrix), Is.True);
        }

        #region MapMatrix
        [Test]
        public void ExampleCase()
        {
            Assert.That(RouteExists(0, 0, 2, 2, mapMatrix), Is.True);
        }

        [Test]
        public void TopCases()
        {
            //First Item
            Assert.That(RouteExists(0, 0, 0, 1, mapMatrix), Is.False);
            Assert.That(RouteExists(0, 0, 0, 2, mapMatrix), Is.False);

            Assert.That(RouteExists(0, 0, 1, 0, mapMatrix), Is.True);
            Assert.That(RouteExists(0, 0, 1, 1, mapMatrix), Is.True);
            Assert.That(RouteExists(0, 0, 1, 2, mapMatrix), Is.False);

            Assert.That(RouteExists(0, 0, 2, 0, mapMatrix), Is.False);
            Assert.That(RouteExists(0, 0, 2, 1, mapMatrix), Is.True);
            Assert.That(RouteExists(0, 0, 2, 2, mapMatrix), Is.True);

            //Second Item
            for (int i = 0; i < mapMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < mapMatrix.GetLength(1); j++)
                    Assert.That(RouteExists(0, 1, i, j, mapMatrix), Is.False);
            }

            //Third Item
            for (int i = 0; i < mapMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < mapMatrix.GetLength(1); j++)
                    Assert.That(RouteExists(0, 2, i, j, mapMatrix), Is.False);
            }
        }

        [Test]
        public void MiddleCases()
        {
            //First Item
            Assert.That(RouteExists(1, 0, 0, 0, mapMatrix), Is.True);
            Assert.That(RouteExists(1, 0, 0, 1, mapMatrix), Is.False);
            Assert.That(RouteExists(1, 0, 0, 2, mapMatrix), Is.False);

            Assert.That(RouteExists(1, 0, 1, 1, mapMatrix), Is.True);
            Assert.That(RouteExists(1, 0, 1, 2, mapMatrix), Is.False);

            Assert.That(RouteExists(1, 0, 2, 0, mapMatrix), Is.False);
            Assert.That(RouteExists(1, 0, 2, 1, mapMatrix), Is.True);
            Assert.That(RouteExists(1, 0, 2, 2, mapMatrix), Is.True);

            //Second Item
            Assert.That(RouteExists(1, 1, 0, 0, mapMatrix), Is.True);
            Assert.That(RouteExists(1, 1, 0, 1, mapMatrix), Is.False);
            Assert.That(RouteExists(1, 1, 0, 2, mapMatrix), Is.False);

            Assert.That(RouteExists(1, 1, 1, 0, mapMatrix), Is.True);
            Assert.That(RouteExists(1, 1, 1, 2, mapMatrix), Is.False);

            Assert.That(RouteExists(1, 1, 2, 0, mapMatrix), Is.False);
            Assert.That(RouteExists(1, 1, 2, 1, mapMatrix), Is.True);
            Assert.That(RouteExists(1, 1, 2, 2, mapMatrix), Is.True);

            //Third Item
            for (int i = 0; i < mapMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < mapMatrix.GetLength(1); j++)
                    Assert.That(RouteExists(1, 2, i, j, mapMatrix), Is.False);
            }
        }

        [Test]
        public void DownCases()
        {
            //First Item
            for (int i = 0; i < mapMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < mapMatrix.GetLength(1); j++)
                    Assert.That(RouteExists(2, 0, i, j, mapMatrix), Is.False);
            }

            //Second Item
            Assert.That(RouteExists(2, 1, 0, 0, mapMatrix), Is.True);
            Assert.That(RouteExists(2, 1, 0, 1, mapMatrix), Is.False);
            Assert.That(RouteExists(2, 1, 0, 2, mapMatrix), Is.False);

            Assert.That(RouteExists(2, 1, 1, 0, mapMatrix), Is.True);
            Assert.That(RouteExists(2, 1, 1, 1, mapMatrix), Is.True);
            Assert.That(RouteExists(2, 1, 1, 2, mapMatrix), Is.False);

            Assert.That(RouteExists(2, 1, 2, 0, mapMatrix), Is.False);
            Assert.That(RouteExists(2, 1, 2, 2, mapMatrix), Is.True);

            //Third Item
            Assert.That(RouteExists(2, 2, 0, 0, mapMatrix), Is.True);
            Assert.That(RouteExists(2, 2, 0, 1, mapMatrix), Is.False);
            Assert.That(RouteExists(2, 2, 0, 2, mapMatrix), Is.False);

            Assert.That(RouteExists(2, 2, 1, 0, mapMatrix), Is.True);
            Assert.That(RouteExists(2, 2, 1, 1, mapMatrix), Is.True);
            Assert.That(RouteExists(2, 2, 1, 2, mapMatrix), Is.False);

            Assert.That(RouteExists(2, 2, 2, 0, mapMatrix), Is.False);
            Assert.That(RouteExists(2, 2, 2, 1, mapMatrix), Is.True);

        }

        #endregion
    }
}
