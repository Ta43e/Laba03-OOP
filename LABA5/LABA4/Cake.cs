﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA5
{
    public partial class Cake : Pastry // тортики
    {
        private string CakeName;
        public Cake()
        {
        }

        public Cake(int Cost, string Manufacturer, string name, string delivery, string DateOfManufacture, string CakeName, int Mass)
        {
            this.CakeName = CakeName;
            this.Cost = Cost;
            this.Manufacturer = Manufacturer;
            this.Delivery = delivery;
            this.DateOfManufacture = DateOfManufacture;
            this.Name = name;
            this.Mass = Mass;
        }

        public override string Info()
        {
            return "Данный продукт является: " + GetType().Name + ", он произведён: " + Manufacturer + ", название товара: " +
                CakeName + ", цена: " + Cost + ", доставка: " + Delivery + " Вес: " + Mass; 
        }
    }
}
