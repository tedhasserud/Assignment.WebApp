﻿namespace WebAuthKey.Models
{
    public class CategoryModel
    {
        public CategoryModel()
        {

        }
        public CategoryModel(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

    }
}
