using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public class ProductDto
    {
            public int ProductId { get; set; }
            public string ProductTitle { get; set; }
            public string ProductDescription { get; set; }
            public string ImagePath { get; set; }
            public CategoryDto CategoryId { get; set; }
            public DateTime? DateCreated { get; set; }
            public int?  CreatedBy { get; set; }
            public DateTime DateModified { get; set; }
            public int ModifiedBy { get; set; }
    }
}
