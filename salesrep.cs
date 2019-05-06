using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grandee_project
{
    public class salesrep
    {
        public int id_sale { get; set; }
        public int id_cus { get; set; }
        public string item { get; set; }
        public string date { get; set; }
        public int bags { get; set; }
        public decimal rate { get; set; }
        public string vehicle_no { get; set; }
        public int total_ammount { get; set; }
        public int paid_amount { get; set; }
        public int balance_amount { get; set; }
        public string cus_name { get; set; }
        public string cus_phone { get; set; }
        public string cus_account { get; set; }

    }
}
