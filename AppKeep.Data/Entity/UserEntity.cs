using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppKeep.Data
{
    [Table("appkeepuser")]
    public class UserEntity
    {
        [Key]
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }

        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public UserTypeEnum UserType { get; set; } = UserTypeEnum.NotSet;
        public string UserMachineCategories { get; set; }
    }

    public enum UserTypeEnum
    {
        NotSet = 0,
        Owner = 1,
        Assistant = 2
    }
}