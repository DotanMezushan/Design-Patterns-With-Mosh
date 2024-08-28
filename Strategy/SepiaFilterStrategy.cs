using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class SepiaFilterStrategy : IImageProcessingStrategy
    {
        public void ProcessImage(string imagePath)
        {
            Console.WriteLine($"Applying sepia filter to {imagePath}.");
        }
    }

}
