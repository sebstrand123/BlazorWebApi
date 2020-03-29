using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor.Models
{
    public class CaseStatusClass
    {
        public int Id { get; set; }
        [Required]
        public string Status { get; set; }
    }
}
