﻿namespace FashionTrend.Application.UseCases._Product.DeleteProduct
{
    public sealed record DeleteProductResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
