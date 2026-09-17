using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XDlol
{
    public class Cars
    {
        public string Brand { get; set; }
        public string type { get; set; }
        public int buildyear { get; set; }
        public int hp { get; set; }
        public int price { get; set; }
        public Cars(string line)
        {
            string[] temp = line.Split(";");
            Brand = temp[0];
            type = temp[1];
            buildyear = Convert.ToInt32(temp[2]);
            hp = Convert.ToInt32(temp[3]);
            price = Convert.ToInt32(temp[4]);
        }
    }
}
