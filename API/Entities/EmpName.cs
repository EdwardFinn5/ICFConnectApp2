using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Entities
{
    public class EmpName
    {
        [Key]
        public int EmpNameId { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string CompanyName { get; set; }




    }
}