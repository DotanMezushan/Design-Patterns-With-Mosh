using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class PngCompressionStrategy : IImageProcessingStrategy
    {
        public void ProcessImage(string imagePath)
        {
            Console.WriteLine($"Compressing {imagePath} using PNG compression.");
        }
    }
}
