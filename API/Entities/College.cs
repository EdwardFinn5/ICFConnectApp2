using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Entities
{
    public class College
    {

        [Key]
        public int CollegeId { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string CollegeName { get; set; }
        [Column(TypeName = "nvarchar(30)")]
        public string CollegeNickname { get; set; }
        [Column(TypeName = "nvarchar(60)")]
        public string CollegeLocation { get; set; }
        public virtual AppUser AppUser { get; set; }
        public int AppUserId { get; set; }
    }
}