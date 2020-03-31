using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMockProject.Core.Model
{
    public class MyInitializer : CreateDatabaseIfNotExists<MyContext>
    {
        protected override void Seed(MyContext context)
        {
            Staff staff = new Staff()
            {
                StaffId = "staff1",
                StaffName = "duc",
                Email = "staff1@gmail.com"
            };
            context.Staffs.Add(staff);
            context.SaveChanges();
            base.Seed(context);
        }
    }
}
