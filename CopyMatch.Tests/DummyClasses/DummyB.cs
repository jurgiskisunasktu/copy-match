namespace CopyMatch.Tests.DummyClasses
{
    public class DummyB
    {
        public string DummyString { get; set; }
        public int DummyInt { get; set; }
        public double DummyDouble { get; set; }
        public DummyImage DummyImage { get; set; }

        public string SpecificDummyB { get; set; }

        public DummyB()
        {
            DummyImage = new DummyImage();
        }

        public void LoadDefaults()
        {
            DummyString = "Class B Dummy";

            DummyInt = 222;

            DummyDouble = 222222;

            DummyImage.Height = 222;
            DummyImage.Width = 222;
            DummyImage.Data = new byte[DummyImage.Height * DummyImage.Width];

            SpecificDummyB = "String value that only DummyB class object should have";
        }
    }
}
