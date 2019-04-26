using Contracts;
using Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Ebay.DAL.Implementation
{
    public class ProductRepository : IProductRepository
    {
        private readonly IRepository<Product> _productrepository;
        private readonly DbContext _context;

        public ProductRepository(IRepository<Product> productRepository, DbContext context)
        {
            _productrepository = productRepository;
            _context = context;
        }

        public ProductDto GetProductById(int id)
        {
            Product item = _productrepository.GetUserById(id);
    
            
            if( item == null )
            {
                throw new NullReferenceException();
            }

            ProductDto itemDto = new ProductDto
            {
                ProductId = item.ProductId,
                ProductTitle = item.ProductTitle,
                ProductDescription = item.ProductDescription,
                ImagePath = item.ImagePath,
                CategoryId = new CategoryDto
                {
                    CategoryId = item.CategoryId
                }
            };
            
            return itemDto;
        }
        public List<ProductDto> GetItemsOfSearchValue(SearchValueDto filter)
        {
            var items = _productrepository.GetAll().Where(x => (filter.SearchValue == "" || x.ProductTitle.Contains(filter.SearchValue))
                && (filter.CategoryId == 0 || x.ProductId == filter.CategoryId)).ToList();
            
            List<ProductDto> productDtos = new List<ProductDto>();
            return productDtos;

        }
    }

        

   
}
