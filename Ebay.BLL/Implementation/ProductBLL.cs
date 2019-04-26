using Ebay.BLL.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ebay.BLL
{
    public class ProductBLL : IProductBLL
    {
        public bool ValidateId(int id)
        {
            if (id == 0)
            {
                throw new BLLCustomException("Id is not valid!");
            }
            return true;
        }
        public bool ValidatePrice(double price)
        {
            if (price < 2)
            {
                throw new BLLCustomException("Price is not valid!");
            }
            return true;
        }

    }

}
