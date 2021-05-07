using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppKeep.Data.Repository
{
    public class UserMachineRepository : Repository<UserMachineEntity>, IUserMachineRepository
    {
        public UserMachineRepository(AppKeepContext context) : base(context)
        {

        }

        public async Task<List<UserMachineEntity>> GetUserMachines(int userId)
        {
            var userMachines = await GetAll()
                .Include(u => u.User)
                .Include(u => u.Machine)
                .Where(u => u.UserId == userId)
                .ToListAsync();

            return userMachines;
        }

        public async Task<UserMachineEntity> UpdateAsync(UserMachineEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException($"{nameof(AddAsync)} entity must not be null");
            }

            try
            {
                var userMachine = _context.UserMachines.First(e => e.UserMachineId == entity.UserMachineId);
                _context.Entry(userMachine).CurrentValues.SetValues(entity);
                await _context.SaveChangesAsync();

                return entity;
            }
            catch (Exception ex)
            {
                throw new Exception($"{nameof(entity)} could not be updated: {ex.Message}");
            }
        }
    }
}