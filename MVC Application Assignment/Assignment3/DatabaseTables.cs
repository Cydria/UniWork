using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class DatabaseTables
    {
        public class StaffMembersContext : DbContext
        {
            public StaffMembersContext() : base("MySqlConnection") { }
            public DbSet<StaffMember> StaffMembers { get; set; }
        }
        [Table("StaffMember")]
        public class StaffMember
        {
            [Key]
            public string officer_ID { get; set; }
            public string first_name { get; set; }
            public string surname { get; set; }
            public string skill_level { get; set; }
            public string assigned_ambulance { get; set; }
        }

        public class AmbulancesContext : DbContext
        {
            public AmbulancesContext() : base("MySqlConnection") { }
            public DbSet<Ambulance> Ambulances { get; set; }
        }
        [Table("Ambulances")]
        public class Ambulance
        {
            [Key]
            public string ambulance_ID { get; set; }
            public string station { get; set; }
        }
    }
}
