﻿namespace API.Entities
{
    public class Product : BaseEntity
    {

        public string Name { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public double Price { get; set; }

        public Category Category { get; set; }

        public int CategoryId { get; set; }
    }
}
