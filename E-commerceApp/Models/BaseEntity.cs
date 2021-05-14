using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceApp1.Models
{
    public class BaseEntity <T>
    {
        public BaseEntity()
        {
            CreationDate = DateTime.Now;
            IsDelete = false;
        }

        [Key]

        public T Id { get; set; }

        public DateTime CreationDate { get; set; }

        public DateTime LastModify { get; set; }

        public bool IsDelete { get; set; }
    }
}
