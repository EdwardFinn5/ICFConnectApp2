using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Entities
{
    public class Position
    {
        [Key]
        public int PositionId { get; set; }
        [Column(TypeName = "nvarchar(60)")]
        public string PositionName { get; set; }

        [Column(TypeName = "nvarchar(12)")]
        public string PositionType { get; set; }
        [Column(TypeName = "nvarchar(60)")]
        public string PositionLocation { get; set; }
        public string Positioninfo { get; set; }
        public string LookingFor { get; set; }
        public DateTime StartDate { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string HowToApply { get; set; }
        [DataType(DataType.Url)]
        public string ApplyUrl { get; set; }
        public DateTime ApplyDeadline { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string HrContact { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string HrContactTitle { get; set; }
        [DataType(DataType.EmailAddress)]
        public string HrEmail { get; set; }
        public virtual AppUser AppUser { get; set; }
        public int AppUserId { get; set; }
    }
}