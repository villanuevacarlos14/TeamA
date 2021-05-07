namespace AppKeep.Data.Repository
{
    public class UserRepository : Repository<UserEntity>, IUserRepository
    {
        public UserRepository(AppKeepContext context) : base(context)
        {

        }
    }
}