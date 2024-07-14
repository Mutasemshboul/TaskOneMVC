using System.ComponentModel.DataAnnotations.Schema;

namespace TaskOneMVC.Models
{
    public class User
    {
        public int UserId { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string Role { get; set; }  

        public int? EmployeeID { get; set; }

        [ForeignKey("EmployeeID")]
        public Employees Employee { get; set; }

    }
}
