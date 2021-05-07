namespace AppKeep.Data.Repository
{
    public class MyPlanRepository : Repository<MyPlanEntity>, IMyPlanRepository
    {
        public MyPlanRepository(AppKeepContext context) : base(context)
        {

        }
    }
}