using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DilmanovaDPattermsDZ1
{
  
    public abstract class Image
    {
        string imageName;
        DateTime imageDate;
        int imageSize;
        public Image(string name, DateTime dateTime, int size)
        {
            imageName = name;
            imageDate = dateTime;
            imageSize = size;
        }
        public abstract  Image Clone();
        }
   
}

