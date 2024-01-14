
using System.ComponentModel.DataAnnotations;

namespace core_web_app1.Models
{
    public class Account
    {
        [Required]
        [MinLength(3)]
        [MaxLength(20)]
        public string? Username { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(20)]
        public string? Password { get; set; }

        [Range(18, 60)]
        public int Age { get; set; }

        [Required]
        [EmailAddress]
        public string? Email { get; set; }

        [Url]
        public string? Website { get; set; }


    }
}
