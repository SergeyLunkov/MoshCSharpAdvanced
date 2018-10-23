using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{

    class Program
    {
        static void Main(string[] args)
        {
            var processor = new PhotoProcess();
            var filters = new PhotoFilters();
            Action<Photo> filterHandler = filters.ApplyBrightness;
            filterHandler += filters.ApplyContrast;
            filterHandler += filters.RemoveRedEye;

            processor.Process("photo.jpg", filterHandler);
        }
    }
}
