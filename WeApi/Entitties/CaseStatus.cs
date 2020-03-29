using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WeApi.Entitties
{
    public class CaseStatus
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Status { get; set; }

        public ICollection<Case> Case { get; set; }
    }
}
