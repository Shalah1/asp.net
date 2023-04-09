using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class EmployeeModel
    {
        /*  public int Eid { get; set; }
          public string Ename { get; set; }
          public string Eemail { get; set; }
          public string Eaddress { get; set; }
          public string Epn { get; set; }
      */

            public int EId { get; set; }
            public string EName { get; set; }
            public string EPassword { get; set; }
            public string EEmail { get; set; }
            public string EAddress { get; set; }
            public string EPhone { get; set; }
            public byte[] EPicture { get; set; }
            public int EBasicSalary { get; set; }
            public int EFastiveBonus { get; set; }
            public int EPerformBonus { get; set; }
            public string ESchedule { get; set; }

    }
}
