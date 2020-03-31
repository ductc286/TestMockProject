using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMockProject.Core.Model
{
    public class Staff
    {
        public Staff()
        {
            //this.Staff_RoleProjects = new HashSet<Staff_RoleProject>();
        }
        public string StaffId { get; set; }
        public string StaffName { get; set; }
        public string Email { get; set; }
        public virtual IList<Staff_RoleProject> Staff_RoleProjects { get; set; }
    }
}
