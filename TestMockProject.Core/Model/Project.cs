using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMockProject.Core.Model
{
    public class Project
    {
        public string ProjectId { get; set; }
        public string ProjectName { get; set; }
        public virtual IList<Project_Staff_RoleProject> Project_Staff_RoleProjects { get; set; }
    }
}
