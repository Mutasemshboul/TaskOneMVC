using System.ComponentModel.DataAnnotations;

namespace TaskOneMVC.Models
{
    public class Contact
    {
        public int ContactId { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(100)]
        public string Email { get; set; }

        [Required]
        [StringLength(1000)]
        public string Message { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime DateSent { get; set; }
    }
}
