using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Entities
{
    public class EmpType
    {
        [Key]
        public int EmpTypeId { get; set; }
        [Column(TypeName = "nvarchar(40)")]
        public string EmpTypeName { get; set; }
        public virtual AppUser AppUser { get; set; }
        public int AppUserId { get; set; }
    }
}