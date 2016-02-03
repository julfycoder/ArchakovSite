using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Drawing;

namespace ArchakovPictureSite.Models
{
    public class ImagesIterator
    {
        List<Image> images = new List<Image>();
        public ImagesIterator(Image[] images)
        {
            this.images.AddRange(images);
        }
        public Image[] Cut(int beginIndex, int endIndex)
        {
            Image[] cutted = new Image[endIndex - beginIndex];
            for (int i = beginIndex; i < endIndex; i++) cutted[i - beginIndex] = images[i];
            return cutted;
        }
    }
}