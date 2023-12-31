﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiftLib
{
    [Serializable]
    public class Clothes : Gift
    {
        public Fabric Fabric { get; set; }
        private Fabric _fabric;

        public Clothes(int id, string name, double price, double weight, Fabric fabric) : base(id, name, price, weight)
        {
            _fabric = fabric;
        }
        public Clothes(string[] data) : base(data)
        {
            _fabric = (Fabric)Convert.ToInt32(data[4]);
        }

        public override string ToString()
        {
            return base.ToString() + $" ({_fabric})";
        }

    }
}
