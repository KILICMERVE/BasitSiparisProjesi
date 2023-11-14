using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Product : CommonEntity,IEntity
    {
        public string ProductName { get; set; }
        //public int ColorId { get; set; }
        public string Size { get; set; }
        public Color ProductColor { get; set; }
        //public ICollection<Order> Orders { get; set; }
    }
}
