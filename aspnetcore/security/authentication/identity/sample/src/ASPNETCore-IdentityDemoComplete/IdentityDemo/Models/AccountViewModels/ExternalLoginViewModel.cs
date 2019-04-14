using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityDemo.Models.AccountViewModels
{
    public class ExternalLoginViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public DateTime? DOB { get; internal set; }
        public string Name { get; internal set; }
        public string Gender { get; internal set; }
        public string Picture { get; internal set; }
    }
}
