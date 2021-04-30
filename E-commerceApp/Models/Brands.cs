using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceApp1.Models
{
    public class Brands:BaseEntity <int>
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string ShortDescription { get; set; }

        public string ImageId { get; set; }
    }
}
