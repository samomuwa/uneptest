using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace UnepProject.Models
{
    public class StaffExamplesofProjects
    {
       // [Column(TypeName = "varchar(50)")]
        public string ProjectTitleAndLocation { get; set; }
       // [Column(TypeName = "varchar(50)")]
        public  string LevelofResponsibility{ get; set; }
       // [Column(TypeName = "varchar(500)")]
        public string BriefDescriptionOfRole{ get; set; }
        // Foreign key to staff details
        //[ForeignKey("StaffPersonalInformation")]
      
        public int IndexNumber_staff { get; set; }
        
        public int id { get; set; }


    }
}