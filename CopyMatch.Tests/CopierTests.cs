using System;
using CopyMatch.Tests.DummyClasses;
using Xunit;

namespace CopyMatch.Tests
{
    public static class CopierTests
    {
        [Fact]
        public static void NoConversionTest()
        {
            CamelCaseDummyA camelCaseDummyA = new CamelCaseDummyA();
            camelCaseDummyA.LoadDefaults();

            CamelCaseDummyB camelCaseDummyB = new CamelCaseDummyB();

            Copier copier = new Copier();
            copier.Copy(camelCaseDummyA, camelCaseDummyB);


            Assert.Equal(camelCaseDummyA.DummyString, camelCaseDummyB.DummyString);

            Assert.Equal(camelCaseDummyA.DummyInt, camelCaseDummyB.DummyInt);

            Assert.Equal(camelCaseDummyA.DummyDouble, camelCaseDummyB.DummyDouble);

            Assert.Equal(camelCaseDummyA.DummyImage.Height, camelCaseDummyB.DummyImage.Height);
            Assert.Equal(camelCaseDummyA.DummyImage.Width, camelCaseDummyB.DummyImage.Width);
            Assert.Equal(camelCaseDummyA.DummyImage.Data, camelCaseDummyB.DummyImage.Data);

            Assert.NotEqual(camelCaseDummyA.SpecificDummyA, camelCaseDummyB.SpecificDummyB);
        }

        [Fact]
        public static void CamelToSnakeTest()
        {
            CamelCaseDummyA camelCaseDummyA = new CamelCaseDummyA();
            camelCaseDummyA.LoadDefaults();

            SnakeCaseDummyB snakeCaseDummyB = new SnakeCaseDummyB();

            Copier copier = new Copier();
            copier.Copy(camelCaseDummyA, snakeCaseDummyB);


            Assert.Equal(camelCaseDummyA.DummyString, snakeCaseDummyB.dummy_string);

            Assert.Equal(camelCaseDummyA.DummyInt, snakeCaseDummyB.dummy_int);

            Assert.Equal(camelCaseDummyA.DummyDouble, snakeCaseDummyB.dummy_double);

            Assert.Equal(camelCaseDummyA.DummyImage.Height, snakeCaseDummyB.dummy_image.Height);
            Assert.Equal(camelCaseDummyA.DummyImage.Width, snakeCaseDummyB.dummy_image.Width);
            Assert.Equal(camelCaseDummyA.DummyImage.Data, snakeCaseDummyB.dummy_image.Data);

            Assert.NotEqual(camelCaseDummyA.SpecificDummyA, snakeCaseDummyB.specific_dummy_b);
        }

        [Fact]
        public static void SnakeToCamelTest()
        {
            SnakeCaseDummyA snakeCaseDummyA = new SnakeCaseDummyA();
            snakeCaseDummyA.LoadDefaults();

            CamelCaseDummyB camelCaseDummyB = new CamelCaseDummyB();

            Copier copier = new Copier();
            copier.Copy(snakeCaseDummyA, camelCaseDummyB);


            Assert.Equal(snakeCaseDummyA.dummy_string, camelCaseDummyB.DummyString);

            Assert.Equal(snakeCaseDummyA.dummy_int, camelCaseDummyB.DummyInt);

            Assert.Equal(snakeCaseDummyA.dummy_double, camelCaseDummyB.DummyDouble);

            Assert.Equal(snakeCaseDummyA.dummy_image.Height, camelCaseDummyB.DummyImage.Height);
            Assert.Equal(snakeCaseDummyA.dummy_image.Width, camelCaseDummyB.DummyImage.Width);
            Assert.Equal(snakeCaseDummyA.dummy_image.Data, camelCaseDummyB.DummyImage.Data);

            Assert.NotEqual(snakeCaseDummyA.specific_dummy_a, camelCaseDummyB.SpecificDummyB);
        }
    }
}
