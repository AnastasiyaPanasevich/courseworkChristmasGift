﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text;
using System.Text.Json.Serialization;

namespace GiftLib
{
    [JsonDerivedType(typeof(Gift))]
    [JsonDerivedType(typeof(Candles))]
    [JsonDerivedType(typeof(Clothes))]
    [JsonDerivedType(typeof(Cookie))]

    public abstract class Gift
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public double Weight { get; set; }

        private string _id;
        private string _name;
        private double _price;
        private double _weight;

        public Gift() { }
        public Gift(string id, string name, double price, double weight)
        {
            _id = id;
            _name = name;
            _price = price;
            _weight = weight;
        }
    }
}
