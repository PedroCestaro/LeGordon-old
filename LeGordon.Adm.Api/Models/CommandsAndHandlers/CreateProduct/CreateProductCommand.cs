﻿using MediatR;

namespace Legordon.Adm.Api.Models
{
    public class CreateProductCommand : IRequest<Unit>
    {
        public String ProductName { get; set; }
        public String ProductDescription { get; set; }
        public Int32 CategoryId { get; set; }
        public Double Value { get; set; }   
        public List<Images> ProductImages { get; set; }
    }
}
