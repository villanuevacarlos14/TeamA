namespace AppKeep.Domain
{
    public class UpkeepProfile
    {
        public int Likes { get; set; }
        public string ProfileJSON { get; set; }
        public int UpkeepProfileId { get; set; }
        public int UpkeepProfileTemplateId { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
        public UserMachine UserMachine { get; set; }
        public int UserMachineId { get; set; }
    }
}