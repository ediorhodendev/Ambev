﻿namespace Ambev.DeveloperEvaluation.WebApi.Features.Product.Create
{
    public class CreateProductResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
    }
}
