using Contracts;
using Ebay.DAL.Interfaces;
using Entity;
using System;
using System.Data.Entity;

namespace Ebay.DAL.Implementation
{
    public class UserTableRepository : IUserTableRepository
    {
        private readonly IRepository<UserTable> _userRepository;
        private readonly DbContext _context;

        public UserTableRepository(IRepository<UserTable> userRepository, DbContext context) // constructor
        {
            _userRepository = userRepository;
            _context = context;
        }

        public UserDto GetUserById(int id)
        {
            UserTable user = _userRepository.GetUserById(id);

            if (user == null)
            {
                throw new NullReferenceException();

            }
            UserDto userDto = new UserDto
            {
                UserId = user.UserId,
                UserName = user.Username,
                UserPasssword = user.UserPassword,

            };
            return userDto;
           
        }
    }
}
