using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMockProject.Core.Model
{
    public class Project_Staff_RoleProject
    {
        public string Project_Staff_RoleProjectId { get; set; }
        public string ProjectId { get; set; }
        public string Staff_RoleProjectId { get; set; }
        public virtual IList<Staff_RoleProject> Staff_RoleProjects { get; set; }
        public virtual IList<Project> Projects { get; set; }
    }
}
