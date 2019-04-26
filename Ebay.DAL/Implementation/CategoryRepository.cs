using Contracts;
using Ebay.DAL.Interfaces;
using Entity;
using System;
using System.Data.Entity;

namespace Ebay.DAL.Implementation
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly IRepository<Category> _categoryRepository;
        private readonly DbContext _context;

        public CategoryRepository(IRepository<Category> productRepository, DbContext context) // constructor
        {
            _categoryRepository = productRepository;
            _context = context;
        }

        public CategoryDto GetCategoryById(int id)
        {
            Category category = _categoryRepository.GetUserById(id);

            if (category == null)
            {
                throw new NullReferenceException();
            }

            CategoryDto categoryDto = new CategoryDto
            {
               CategoryId = category.CategoryId,
               CategoryName  = category.CategoryName,
               ParentCategory = category.ParentCategory
            };

            return categoryDto;


        }
        
    }
}
