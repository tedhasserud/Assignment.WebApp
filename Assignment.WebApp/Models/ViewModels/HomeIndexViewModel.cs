﻿namespace Assignment.WebApp.Models.ViewModels
{
    public class HomeIndexViewModel
    {
        public ProductModel ProductForm { get; set; }
        public IEnumerable<ProductModel> Products { get; set; }
        public CategoryModel CategoryForm { get; set; }
        public IEnumerable<CategoryModel> Categories { get; set; }
    }
}
