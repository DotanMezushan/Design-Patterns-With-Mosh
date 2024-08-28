using Strategy;

public class Program
{
    public static void Main()
    {
        ImageProcessor processor = new ImageProcessor();

        string imagePath = "example-image.jpg";

        processor.SetStrategy(new JpegCompressionStrategy());
        processor.ExecuteStrategy(imagePath);

        processor.SetStrategy(new PngCompressionStrategy());
        processor.ExecuteStrategy(imagePath);

        processor.SetStrategy(new BlackAndWhiteFilterStrategy());
        processor.ExecuteStrategy(imagePath);

        processor.SetStrategy(new SepiaFilterStrategy());
        processor.ExecuteStrategy(imagePath);
    }
}
