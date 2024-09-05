using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webshop.Model
{
    public class Order
    {
        public int OrderID { get; set; }
        public int CustomerID {  get; set; }
        public float TotalPrice { get; set; }
        public int PointsEarned { get; set; }
        public int PointsUsed { get; set; }
        public string Status { get; set; }

    }
}
