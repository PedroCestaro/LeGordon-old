﻿using LeGordon.Adm.Entities;

namespace LeGordon.Adm.Services
{
    public interface IProductService
    {
        Task CreateProduct(ProductDto dto);
    }
}