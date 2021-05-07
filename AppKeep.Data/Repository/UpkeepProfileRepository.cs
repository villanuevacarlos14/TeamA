namespace AppKeep.Data.Repository
{
    public class UpkeepProfileRepository : Repository<UpkeepProfileEntity>, IUpkeepProfileRepository
    {
        public UpkeepProfileRepository(AppKeepContext context) : base(context)
        {

        }
    }
}