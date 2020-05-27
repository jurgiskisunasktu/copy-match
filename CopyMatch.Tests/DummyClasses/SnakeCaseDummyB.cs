namespace CopyMatch.Tests.DummyClasses
{
    public class SnakeCaseDummyB
    {
        public string dummy_string { get; set; }
        public int dummy_int { get; set; }
        public double dummy_double { get; set; }
        public DummyImage dummy_image { get; set; }

        public string specific_dummy_b { get; set; }

        public SnakeCaseDummyB()
        {
            dummy_image = new DummyImage();
        }

        public void LoadDefaults()
        {
            dummy_string = "Class B Dummy";

            dummy_int = 222;

            dummy_double = 222222;

            dummy_image.Height = 222;
            dummy_image.Width = 222;
            dummy_image.Data = new byte[dummy_image.Height * dummy_image.Width];

            specific_dummy_b = "String value that only DummyB class object should have";
        }
    }
}
