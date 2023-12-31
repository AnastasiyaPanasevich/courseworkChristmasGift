﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasGiftClient.Model.Gifts
{
    public class Ornaments : Gift
    {
        public OrnamentsMaterial Material { get; set; }
        private OrnamentsMaterial _material;

        public Ornaments(string id, string name, double price, double weight, OrnamentsMaterial material) : base(id, name, price, weight)
        {
            _material = material;
        }
    }
}
