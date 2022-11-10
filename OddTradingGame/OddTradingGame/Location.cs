using System;
using System.Collections.Generic;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddTradingGame
{
    public class Location
    {
        public string name { get; set; }

        public string description { get; set; }

        public string imagePath { get; set; }

        public string imageName { get; set; }

        public Location()
        {

        }

        public Location(string myName, string myDescription, string myImagePath, string myImageName)
        {
            name =  myName;
            description = myDescription;    
            imagePath = myImagePath;
            imageName = myImageName;
        }




    }
}
