namespace CopyMatch.Tests.DummyClasses
{
    public class SnakeCaseDummyA
    {
        public string dummy_string { get; set; }
        public int dummy_int { get; set; }
        public double dummy_double { get; set; }
        public DummyImage dummy_image { get; set; }

        public string specific_dummy_a { get; set; }

        public SnakeCaseDummyA()
        {
            dummy_image = new DummyImage();
        }

        public void LoadDefaults()
        {
            dummy_string = "Class A Dummy";

            dummy_int = 111;

            dummy_double = 111111;

            dummy_image.Height = 111;
            dummy_image.Width = 111;
            dummy_image.Data = new byte[dummy_image.Height * dummy_image.Width];

            specific_dummy_a = "String value that only DummyA class object should have";
        }
    }
}
