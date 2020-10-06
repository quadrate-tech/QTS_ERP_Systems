using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QTS_ERP_Systems.Model
{
    class Item
    {
        public string item_id { get; set; }
        public int item_code { get; set; }
        public string item_name { get; set; }
        public string printable_name { get; set; }
        public string unit_type { get; set; }
        public int unit_cost { get; set; }
        public int selling_price { get; set; }
        public bool is_service { get; set; }
      
    }
}
