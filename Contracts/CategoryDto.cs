using System;

namespace Contracts
{
    public class CategoryDto
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public int? ParentCategory { get; set; }
        
    }
}
