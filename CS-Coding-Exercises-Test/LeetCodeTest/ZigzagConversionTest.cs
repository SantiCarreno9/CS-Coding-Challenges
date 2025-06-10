using LeetCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTest.ZigzagConversionTest;


[TestFixture]
public class ZigzagConversionTest
{
    ZigzagConversion zigzagConversion;

    [SetUp]
    public void Setup()
    {
        zigzagConversion = new ZigzagConversion();
    }

    [Test]
    public void TestConvertWithOneRow()
    {
        Assert.That(zigzagConversion.Convert("A", 1), Is.EqualTo("A"));
    }

    [Test]
    public void TestConvertWithTwoRows()
    {
        Assert.That(zigzagConversion.Convert("AB", 2), Is.EqualTo("AB"));
    }

    [Test]
    public void TestConvertWithThreeRows()
    {
        //Assert.That(zigzagConversion.Convert("PAYPALISHIRING", 3), Is.EqualTo("PAHNAPLSIIGYIR"));
        Assert.That(zigzagConversion.Convert("0123456789J", 3), Is.EqualTo("0481357926J"));
    }

    [Test]
    public void TestConvertWithFourRows()
    {
        //Assert.That(zigzagConversion.Convert("PAYPALISHIRING", 4), Is.EqualTo("PINALSIGYAHRPI"));
        Assert.That(zigzagConversion.Convert("0123456789JQK", 4), Is.EqualTo("06K157Q248J39"));        
    }

    [Test]
    public void TestConvertWithFiveRows()
    {
        //Assert.That(zigzagConversion.Convert("PAYPALISHIRING", 5), Is.EqualTo("PHASIYIRPLIGAN"));
        Assert.That(zigzagConversion.Convert("0123456789JQK", 5), Is.EqualTo("0817926J35Q4K"));
    }
}
