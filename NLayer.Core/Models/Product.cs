﻿ using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core
{
    public class Product:BaseEntity
    {
        //public Product(string name)
        //{
        //    Name=name ?? throw new ArgumentNullException(nameof(Name));
        //}

        public string Name { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }

        public int CategoryId { get; set; }


        // Nav Prop..

        public Category Category { get; set; }

        // First Value dont be appointed.Because Nullable ProductFeature
        public ProductFeature ProductFeature { get; set; }

    }
}
