﻿namespace WebAuthKey.Models
{
    public class UpdateProductModel
    {
        public UpdateProductModel()
        {

        }

        public UpdateProductModel(int id, string ean, string name, string description, decimal price, int categoryId)
        {
            Id = id;
            EAN = ean;
            Name = name;
            Description = description;
            Price = price;
            CategoryId = categoryId;
        }

        public int Id { get; set; }
        public string EAN { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; } 
        public int CategoryId { get; set; }

    }
}
