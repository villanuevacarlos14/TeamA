using System.ComponentModel.DataAnnotations;

namespace AppKeep.Domain
{
    public class Machine
    {
        public int MachineId { get; set; }

        [Required]
        [MinLength(1, ErrorMessage = "Category is required.")]
        public string Category { get; set; } = string.Empty;
        
        [Required]
        [MinLength(1, ErrorMessage = "Name is required.")]
        public string Name { get; set; }

        public string Make { get; set; }

        public string Description { get; set; }

        public string ImgFile { get; set; }
    }
}