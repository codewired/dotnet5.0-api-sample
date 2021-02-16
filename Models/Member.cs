using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SampleWebAPI.Models
{
    public class Member
    {
        public int Id { get; set; }
        public DateTime EnrollmentDate { get; set; }
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(50)]
        public string Lastname { get; set; }
    }
}
