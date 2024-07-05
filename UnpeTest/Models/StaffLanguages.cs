using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
namespace UnepProject.Models
{
    public class StaffLanguages
    {
       // [Column(TypeName = "varchar(50)")]
        public string Language { get; set; }
       // [Column(TypeName = "varchar(50)")]
        public string SoftwareExpertiseLevel { get; set; }
        // Foreign key to staff details
        //[ForeignKey("StaffPersonalInformation")]
        
        public int IndexNumber { get; set; }
        
        public int id { get; set; }
    
}
}