using System;
using System.Collections.Generic;
using System.Text;

namespace venkat
{
    class Order
    {
        public List<MenuItem> menuitem { get; set; }
        public int Total { get {
                int m = 0;
                for (int i = 0; i < menuitem.Count; i++)
                {
                    m = m + menuitem[i].Cost;
                }
                return m;
            } }
    }
}
