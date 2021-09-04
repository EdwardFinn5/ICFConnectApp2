using System;
using System.ComponentModel.DataAnnotations;

namespace API.Entities
{
    public class Photo
    {
        [Key]
        public int PhotoId { get; set; }
        public string StudentUrl { get; set; }
        public string LogoUrl { get; set; }
        public string HrUrl { get; set; }
        public string Description { get; set; }
        public DateTime DateAdded { get; set; }
        public bool IsMainStudent { get; set; } = false;
        public bool IsMainLogo { get; set; } = false;
        public bool IsMainHr { get; set; } = false;
        public string PublicId { get; set; }
        public virtual AppUser AppUser { get; set; }
        public int AppUserId { get; set; }
    }
}