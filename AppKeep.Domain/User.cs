using AppKeep.Data;

namespace AppKeep.Domain
{
    public class User
    {
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
}