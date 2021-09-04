using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Entities
{
    public class HomeCity
    {
        [Key]
        public int HomeCityId { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string HomeCityName { get; set; }
        public virtual AppUser AppUser { get; set; }
        public int AppUserId { get; set; }
    }
}