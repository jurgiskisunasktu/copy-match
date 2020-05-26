using System;
using CopyMatch.Tests.DummyClasses;
using Xunit;

namespace CopyMatch.Tests
{
    public static class CopierTests
    {
        [Fact]
        public static void CopyTest()
        {
            DummyA dummyA = new DummyA();
            dummyA.LoadDefaults();

            DummyB dummyB = new DummyB();

            Copier copier = new Copier();
            copier.Copy(dummyA, dummyB);


            Assert.True(dummyA.DummyString == dummyB.DummyString);

            Assert.True(dummyA.DummyInt == dummyB.DummyInt);

            Assert.True(Math.Abs(dummyA.DummyDouble - dummyB.DummyDouble) < 0.01);

            Assert.True(dummyA.DummyImage.Height == dummyB.DummyImage.Height);
            Assert.True(dummyA.DummyImage.Width == dummyB.DummyImage.Width);
            Assert.True(dummyA.DummyImage.Data == dummyB.DummyImage.Data);

            Assert.True(dummyA.SpecificDummyA != dummyB.SpecificDummyB);
        }
    }
}
