using Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ebay.DAL.Interfaces
{
    public interface IUserTableRepository
    {
        UserDto GetUserById(int id);
    }
}
