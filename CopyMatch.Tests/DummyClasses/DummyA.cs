namespace CopyMatch.Tests.DummyClasses
{
    public class DummyA
    {
        public string DummyString { get; set; }
        public int DummyInt { get; set; }
        public double DummyDouble { get; set; }
        public DummyImage DummyImage { get; set; }

        public string SpecificDummyA { get; set; }

        public DummyA()
        {
            DummyImage = new DummyImage();
        }

        public void LoadDefaults()
        {
            DummyString = "Class A Dummy";

            DummyInt = 111;

            DummyDouble = 111111;

            DummyImage.Height = 111;
            DummyImage.Width = 111;
            DummyImage.Data = new byte[DummyImage.Height * DummyImage.Width];

            SpecificDummyA = "String value that only DummyA class object should have";
        }
    }
}
