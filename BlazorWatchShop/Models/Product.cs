﻿namespace BlazorWatchShop.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public decimal Price { get; set; }
        public string Specifications { get; set; }
        public List<int> RealatedIds { get; set; }

        private List<ProductReview> reviews = new List<ProductReview>();
        public List<ProductReview> Reviews { get => reviews; set => reviews = value; }
    }
}
