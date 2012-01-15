using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Resources;

namespace DirectoryComparer.Services
{
    public class ImagesManager
    {
        public static ImageList GetImages()
        {
            ResourceManager manager = new ResourceManager(typeof(DirectoryComparerIcons));
            ImageList imageList = new ImageList();

            Image folder = (Image)manager.GetObject("folder");            
            imageList.Images.Add(folder);

            return imageList;
        }
    }
}
