﻿namespace WebAuthKey.Models
{
    public class ProductModel
    {
        public ProductModel()
        {

        }
        public ProductModel(int id, string ean, string name, string description, decimal price, string category)
        {
            Id = id;
            EAN = ean;
            Name = name;
            Description = description;
            Price = price;
            Category = category;
        }

        public int Id { get; set; }  
        public string EAN { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
    }
}
