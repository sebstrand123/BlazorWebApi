using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WeApi.Entitties
{
    public class Case
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public DateTime Register { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string CustomerName { get; set; }
        [Required]
        public string Status { get; set; }

        public CaseStatus CaseStatus { get; set; }
        public Customer Customer { get; set; }
    }
}
