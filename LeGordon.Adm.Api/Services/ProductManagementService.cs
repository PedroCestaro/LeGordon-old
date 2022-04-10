using MediatR;
using AutoMapper;

namespace LeGordon.Adm.Api.Services
{
    public class ProductManagementService: ProductManagement.ProductManagementBase
    {

        public override Task<ProductResgistered> CreateProduct(ProductModel request, ServerCallContext context)
        {
            return base.CreateProduct(request, context);
        }



    }
}
