﻿using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Write
{
    public class Product : Entity
    {
        public Product() 
        { }

        public string Description { get; set; }
        public bool IsActive { get; set; }
        public bool IsStaged { get; set; }
        public string Name { get; set; }
        [Precision(6, 2)]
        public decimal Price { get; set; }
        public string Sku { get; set; }
    }
}