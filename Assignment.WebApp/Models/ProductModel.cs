﻿namespace Assignment.WebApp.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string EAN { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
        public int CategoryId { get; set; }
    }
}
