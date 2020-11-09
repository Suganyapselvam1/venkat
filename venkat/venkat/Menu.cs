using System;
using System.Collections.Generic;
using System.Text;

namespace venkat
{
    class Menu
    {
        public Menu()
        {
            items = new List<MenuItem>();
        }
        public string Name { get; set; }
        public List<MenuItem> items;
        public void AddMenuItem(string name,string description,int cost)
        {
            MenuItem menuitem = new MenuItem();
            menuitem.Name = name;
            menuitem.Description = description;
            menuitem.Cost = cost;
            items.Add(menuitem);
        }
        
    }
}
