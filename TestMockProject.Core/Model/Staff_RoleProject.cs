using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMockProject.Core.Model
{
    public class Staff_RoleProject
    {
        public string Staff_RoleProjectId { get; set; }
        public string RoleProjectId { get; set; }
        public string StaffId { get; set; }
        public virtual IList<Staff> Staffs { get; set; }
        public virtual IList<RoleProject> RoleProjects { get; set; }
    }
}
