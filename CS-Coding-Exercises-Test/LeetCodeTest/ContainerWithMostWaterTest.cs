using LeetCode;

namespace LeetCodeTest.ContainerWithMostWaterTest;

[TestFixture]
public class ContainerWithMostWaterTest
{
    private ContainerWithMostWater _containerWithMostWater;

    [SetUp]
    public void Setup()
    {
        _containerWithMostWater = new ContainerWithMostWater();
    }

    [Test]
    public void MaxArea_Example1_Returns49()
    {
        int[] height = { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
        int result = _containerWithMostWater.MaxArea(height);
        Assert.That(result, Is.EqualTo(49));
    }

    [Test]
    public void MaxArea_Example2_Returns1()
    {
        int[] height = { 1, 1 };
        int result = _containerWithMostWater.MaxArea(height);
        Assert.That(result, Is.EqualTo(1));
    }
}
