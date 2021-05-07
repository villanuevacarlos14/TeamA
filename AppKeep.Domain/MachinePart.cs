namespace AppKeep.Domain
{
    public class MachinePart
    {
        public int PartId { get; set; }
        public int MachineId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}