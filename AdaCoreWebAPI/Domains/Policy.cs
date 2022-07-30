using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AdaCoreWebAPI.Domains
{
    public class Policy
    {
        [Key]
        public string PolicyNo { get; set; }
        public string Branch { get; set; }
        public double Premium { get; set; }
    }
}
