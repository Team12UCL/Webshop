using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webshop.Model
{
    public class ShoppingCartLine
    {
        public int CartLineID { get; set; }
        public int CartID { get; set; }
        public int Production { get; set; }
        public int Quantity { get; set; }
    }
}
