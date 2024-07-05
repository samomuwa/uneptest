using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
namespace UnepProject.Models
{
    public class StaffSoftwareExpertise
    {
       // [Column(TypeName = "varchar(50)")]
        public string SoftwareExpertise { get; set;}
      //  [Column(TypeName = "varchar(50)")]
        public string SoftwareExpertiseLevel { get; set; }
        // Foreign key to staff details
        // [ForeignKey("StaffPersonalInformation")]
      
        public int IndexNumber { get; set; }
      
        public int id { get; set; }
    }
}