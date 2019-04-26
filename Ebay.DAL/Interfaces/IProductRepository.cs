using Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ebay.DAL
{
    public interface IProductRepository 
    {
        ProductDto GetProductById(int id);
        List<ProductDto> GetItemsOfSearchValue(SearchValueDto filter);
    }
}
