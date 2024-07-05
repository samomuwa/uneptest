using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using UnepProject.Models;
using Microsoft.Extensions.Configuration;
namespace UnpeTest.Models
{
    public class DataContext: DbContext
    {
        public DataContext(string connString)
        : base(connString)
    {
        }

        public DataContext()
        {

        }
        public DbSet<StaffPersonalInformation> StaffPersonalInformation { get; set; }
        public DbSet<StaffSoftwareExpertise> StaffSoftwareExpertise { get; set; }
        public DbSet<StaffLanguages> StaffLanguages { get; set; }
        public DbSet<StaffExamplesofProjects> StaffExamplesofProjects { get; set; }
    }
}