using System.ComponentModel.DataAnnotations;

namespace API.Entities
{
    public class UserType
    {
        [Key]
        public int UserTypeId { get; set; }
        public string UserTypeName { get; set; }

    }
}