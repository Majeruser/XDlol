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
        public string Type { get; set; }
        public int Buildyear { get; set; }
        public int Hp { get; set; }
        public int Price { get; set; }
        public Cars(string line)
        {
            string[] temp = line.Split(";");
            Brand = temp[0];
            Type = temp[1];
            Buildyear = Convert.ToInt32(temp[2]);
            Hp = Convert.ToInt32(temp[3]);
            Price = Convert.ToInt32(temp[4]);
        }
    }
}
