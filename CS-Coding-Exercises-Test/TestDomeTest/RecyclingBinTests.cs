using TestDome;

namespace TestDomeTest
{
    [TestFixture]
    public class RecyclingBinTests
    {
        RecyclingBin recyclingBin = new RecyclingBin();
        List<IGrouping<string, string>> recyclablesSorted = new List<IGrouping<string, string>>();

        [OneTimeSetUp]
        public void Init()
        {
            recyclingBin.Add("metal pipe");
            recyclingBin.Add("plastic toy");
            recyclingBin.Add("metal bar");
            recyclingBin.Add("copper wire");
            recyclingBin.Add("plastic button");
            recyclingBin.Add("wire");
            recyclingBin.Add("brass");

            recyclablesSorted = recyclingBin.SortRecyclables();
        }

        //One of the groups returned from SortRecyclables will have "metal" as its key and will contain
        //"metal bar" and "metal pipe".
        [Test]
        public void MetalGroupContainsMetalPipeOnly()
        {
            int metalIndex = recyclablesSorted.FindIndex(x => x.Key.Equals("metal"));
            Assert.That(metalIndex, !Is.EqualTo(-1));
            Assert.That(recyclablesSorted[metalIndex].Count(), Is.EqualTo(1));
            Assert.That(recyclablesSorted[metalIndex].Contains("metal pipe"), Is.True);
        }

        //One of the groups returned from SortRecyclables will have "copper" as its key and will contain
        //"copper wire".
        [Test]
        public void CopperGroupContainsWireOnly()
        {
            int copperIndex = recyclablesSorted.FindIndex(x => x.Key.Equals("copper"));
            Assert.That(copperIndex, !Is.EqualTo(-1));
            Assert.That(recyclablesSorted[copperIndex].Count(), Is.EqualTo(1));
            Assert.That(recyclablesSorted[copperIndex].Contains("copper wire"), Is.True);
        }

        //The List returned from SortRecyclables WILL BE evaluated in the SortRecyclables method.

        //The Add method will add a new recyclable only if it contains a space and the second word has
        //more than 3 characters.
        [Test]
        public void AddsOnlyItemsWithSpaceAndSecondWordLengthThree()
        {
            int brassIndex = recyclablesSorted.FindIndex(x => x.Key.Equals("brass"));
            Assert.That(brassIndex, Is.EqualTo(-1));

            int metalIndex = recyclablesSorted.FindIndex(x => x.Key.Equals("metal"));
            Assert.That(recyclablesSorted[metalIndex].Contains("metal bar"), Is.False);
            Assert.That(recyclablesSorted[metalIndex].Contains("metal pipe"), Is.True);
        }

        //One of the groups returned from SortRecyclables will have "plastic" as its key and will contain
        //"plastic toy".
        [Test]
        public void PlasticToyIsNotPresent()
        {
            int plasticIndex = recyclablesSorted.FindIndex(x => x.Key.Equals("plastic"));
            Assert.That(recyclablesSorted[plasticIndex].Contains("plastic toy"), Is.False);
        }
    }
}
