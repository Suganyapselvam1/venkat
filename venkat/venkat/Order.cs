using System;
using System.Collections.Generic;
using System.Text;

namespace venkat
{
    class Order
    {
        public Order()
        {
            menuitems=new List<MenuItem>();
        }
        public List<MenuItem> menuitems { get; set; }
        public int Total { get {
                int m = 0;
                for (int i = 0; i < menuitems.Count; i++)
                {
                    m = m + menuitems[i].Cost;
                }
                return m;
            } }
    }
}
