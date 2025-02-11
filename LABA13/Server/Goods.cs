﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    [Serializable]
    public abstract class Goods // товар
    {
        public int Cost;
        public string Manufacturer;
        public string Name;
        [NonSerialized]
        public string Delivery;
        public Goods(int cost, string manufacturer, string name, string delivery)
        {
            Cost = cost;
            Manufacturer = manufacturer;
            Name = name;
            Delivery = delivery;
        }

        public Goods() { }
        public override string ToString()
        {
            return "Cost: " + Cost + " " +
                   "Manufacturer: " + Manufacturer;
        }

        public abstract string Info();

    }
}
