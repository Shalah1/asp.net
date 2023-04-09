using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class CustomerModel
    {
        /*   public int C_ID { get; set; }
           public string C_Name { get; set; }
           public string C_Password { get; set; }
           public string C_Email { get; set; }
           public string C_Address { get; set; }
           public string C_Phone { get; set; }
           public Nullable<int> V_ID { get; set; }*/
        /*
                public int Cid { get; set; }
                public string Cname { get; set; }
                public string Cpassword { get; set; }
                public string Cemail { get; set; }
                public string Caddress { get; set; }
                public string Cpn { get; set; }
                public int VoucherID { get; set; }
        */
        public int CId { get; set; }
        public string CName { get; set; }
        public string CPassword { get; set; }
        public string CEmail { get; set; }
        public string CAddress { get; set; }
        public string CPhone { get; set; }
        public byte[] CPicture { get; set; }
        public int VouId { get; set; }


    }
}
