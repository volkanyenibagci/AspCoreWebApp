using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspCoreWebApp.Entities.Models
{
    public class BaseEntity
    {
        public bool? Status { get; set; }

        public DateTime? CreateDateTime { get; set; }
    }
}
