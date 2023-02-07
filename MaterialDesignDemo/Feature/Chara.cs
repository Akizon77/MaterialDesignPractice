using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MaterialDesignDemo.Feature
{
   
    public class Chara
    {
        public string CharUrl { get; set; }
        public string CityID { get; set; }

        public Chara() { }
        public Chara(string charUrl, string cityID)
        {
            CharUrl = charUrl;
            CityID = cityID;
        }

        
    }
}
