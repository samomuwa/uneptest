using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace UnepProject.Models
{

    public class StaffPersonalInformation
    {
        
        [System.ComponentModel.DataAnnotations.Key]
        public int IndexNumber { get; set; }
       // [Column(TypeName= "varchar(200)")]
       public string FullNames { get; set; }
     //   [Column(TypeName = "varchar(100)")]
        public string Email { get; set; }
       // [Column(TypeName = "varchar(100)")]
        public  string CurrentLocation { get; set; }
      //  [Column(TypeName = "varchar(100)")]
        public string HighestLevelOfEducation { get; set; }
     //   [Column(TypeName = "varchar(100)")]
        public string DutyStation { get; set; }
     //   [Column(TypeName = "varchar(100)")]
        public bool AvailabilityForRemoteWork { get; set; }


    }
}