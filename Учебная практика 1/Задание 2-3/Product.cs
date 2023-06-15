﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2
{
    class Product
    {
        public decimal Price { get; set; }
        public string Name { get; set; }

        public Product (string Name, decimal Price)
        {
            this.Name = Name;
            this.Price = Price;
        }

        public string GetInfo ()
        {
            return $"Наименование: {Name}; Цена: {Price}";
        }

    }
}
