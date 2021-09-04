using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Entities
{
    public class AppUser
    {
        [Key]
        public int AppUserId { get; set; }
        [DataType(DataType.EmailAddress)]
        public string UserName { get; set; }
        [Column(TypeName = "nvarchar(30)")]
        public string FirstName { get; set; }
        [Column(TypeName = "nvarchar(30)")]
        public string LastName { get; set; }
        [Column(TypeName = "nvarchar(8)")]
        public string AppUserType { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastActive { get; set; }
        public Boolean Active { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string EmpName { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        public string EmpNum { get; set; }
        public string EmpInfo { get; set; }
        [Column(TypeName = "nvarchar(10)")]
        public string ClassYear { get; set; }
        public DateTime GradDate { get; set; }
        [DataType(DataType.EmailAddress)]
        public string BestEmail { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string BestPhone { get; set; }
        public string Athletics { get; set; }
        public string Arts { get; set; }
        public string ExtraCurricular { get; set; }
        public string AcademicPlus { get; set; }
        public string WorkPlus { get; set; }
        [Column(TypeName = "nvarchar(5)")]
        public string GPA { get; set; }
        public string DreamJob { get; set; }
        public ICollection<Photo> Photos { get; set; }
        public ICollection<College> Colleges { get; set; }
        public ICollection<EmpType> EmpTypes { get; set; }
        public ICollection<HomeCity> HomeCities { get; set; }
        public ICollection<Major> Majors { get; set; }
        public ICollection<Position> Positions { get; set; }

    }
}