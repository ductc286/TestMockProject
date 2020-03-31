using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMockProject.Core.Model
{
    public class MyContext : DbContext
    {
        public MyContext(): base("MyConnectionString")
        {
            Database.SetInitializer<MyContext>(new MyInitializer());
            
        }

        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<RoleProject> RoleProjects { get; set; }
        public DbSet<Project_Staff_RoleProject> Project_Staff_RoleProjects { get; set; }
        public DbSet<Staff_RoleProject> Staff_RoleProjects { get; set; }
        public DbSet<Claim> Claims { get; set; }
    }
}
