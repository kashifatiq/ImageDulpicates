using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImageMagick;
namespace Services
{
    public class ImgMagick
    {
        public bool areImageSame(string firstFilePath, string secondFilePath)
        {
            bool compareResult = false;
            using (var image1 = new MagickImage(firstFilePath))
            using (var image2 = new MagickImage(secondFilePath))
            {
                compareResult = image1.Compare(image2, ErrorMetric.RootMeanSquared) == 0;
            }
            return compareResult;
        }
    }
}
