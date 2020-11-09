using System;
using System.Collections.Generic;
using System.Text;

namespace venkat
{
    class MenuItem
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public int Cost { get { return _Cost; }
            set {
                if (value > 0)
                {
                    _Cost = value;
                }
                else
                {
                    throw new Exception("dfdfd");
                }
            } 
        }
        private int _Cost;
    }
}
