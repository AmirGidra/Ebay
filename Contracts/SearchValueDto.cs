using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public class SearchValueDto
    {
        public string SearchValue { get; set; }
        public int CategoryId { get; set; }
        public int Condition { get; set; }
        public bool FreeShipping { get; set; }
        public double Price { get; set; }
    }
}
