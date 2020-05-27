using System;
using CopyMatch.Tests.DummyClasses;
using Xunit;

namespace CopyMatch.Tests
{
    public static class CopierHelperTests
    {
        [Fact]
        public static void CopierHelperTest()
        {
            CamelCaseDummyA camelCaseDummyA = new CamelCaseDummyA();
            camelCaseDummyA.LoadDefaults();

            CamelCaseDummyB camelCaseDummyB = new CamelCaseDummyB();

            camelCaseDummyB.CopyToOtherClass(camelCaseDummyA);

            Assert.True(camelCaseDummyA.DummyString == camelCaseDummyB.DummyString);

            Assert.True(camelCaseDummyA.DummyInt == camelCaseDummyB.DummyInt);

            Assert.True(Math.Abs(camelCaseDummyA.DummyDouble - camelCaseDummyB.DummyDouble) < 0.01);

            Assert.True(camelCaseDummyA.DummyImage.Height == camelCaseDummyB.DummyImage.Height);
            Assert.True(camelCaseDummyA.DummyImage.Width == camelCaseDummyB.DummyImage.Width);
            Assert.True(camelCaseDummyA.DummyImage.Data == camelCaseDummyB.DummyImage.Data);

            Assert.True(camelCaseDummyA.SpecificDummyA != camelCaseDummyB.SpecificDummyB);
        }
    }
}
