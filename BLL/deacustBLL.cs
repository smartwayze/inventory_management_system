using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaadStationers1.BLL
{
    class deacustBLL
    {
        public int id { get; set; }
        public string type { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string contact { get; set; }
        public string address { get; set; }
        public DateTime added_date { get; set; }
        public int added_by { get; set; }
        public int pre_balance { get; set; }
    }
}
