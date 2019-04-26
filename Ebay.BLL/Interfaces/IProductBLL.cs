using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ebay.BLL
{
    public interface IProductBLL
    {
        bool ValidateId(int id);
        bool ValidatePrice(double price);

    }
}
