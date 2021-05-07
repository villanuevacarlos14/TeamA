using AppKeep.Data;
using AppKeep.Data.Repository;
using AppKeep.Domain;
using AppKeep.Service.Mapping;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppKeep.Service
{
    public class UserService : IUserService, IAutoMapperService
    {
        private readonly IUserRepository _userRepository;

        public IMapper Mapper
        {
            get { return ObjectMapper.Mapper; }
        }

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<User> AddUserAsync(User user)
        {
            var userEntity = Mapper.Map<UserEntity>(user);

            userEntity = await _userRepository.AddAsync(userEntity);

            user = Mapper.Map<User>(userEntity);

            return user;
        }

        public async Task<List<User>> GetAllUsersAsync()
        {
            var userEntities = await _userRepository.GetAll().ToListAsync();

            return Mapper.Map<List<User>>(userEntities);
        }

        public async Task<User> GetUserByIdAsync(int id)
        {
            var userEntity = await _userRepository.GetAsync(id);

            var user = Mapper.Map<User>(userEntity);

            return user;
        }

        public async Task<User> GetUserByEmailAsync(string email)
        {
            var userEntity = await _userRepository
                .GetAll()
                .FirstOrDefaultAsync(u => u.Email == email);

            var user = Mapper.Map<User>(userEntity);

            return user;
        }

        public async Task<User> UpdateUserAsync(User user)
        {
            var userEntity = Mapper.Map<UserEntity>(user);

            userEntity = await _userRepository.UpdateAsync(userEntity);

            user = Mapper.Map<User>(userEntity);

            return user;
        }
    }
}