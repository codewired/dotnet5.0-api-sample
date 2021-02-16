using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SampleWebAPI.Models
{
    public class Claim
    {
        public int Id { get; set; }
        public DateTime ClaimDate { get; set; }
        [Required]
        public decimal ClaimAmount { get; set; }
        public virtual Member Member { get; set; }
    }
}
