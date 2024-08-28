using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class ImageProcessor
    {
        private IImageProcessingStrategy _strategy;

        public void SetStrategy(IImageProcessingStrategy strategy)
        {
            _strategy = strategy;
        }

        public void ExecuteStrategy(string imagePath)
        {
            _strategy.ProcessImage(imagePath);
        }
    }

}
