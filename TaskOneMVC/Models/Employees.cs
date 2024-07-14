using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TaskOneMVC.Models
{
    public class Employees
    {
        public int EmployeesId { get; set; }
        public string Name { get; set; }


        public DateTime BirthDate { get; set; }


        public string PhoneNumber { get; set; }

        public string NationalID { get; set; }

        public string Nationality { get; set; }

        public string MaritalStatus { get; set; }

        public string PersonalPhoto { get; set; }

        public DateTime EntryDate { get; set; }

        
        public string Password { get; set; }

        public int? DepartmentID { get; set; }

        [ForeignKey("DepartmentID")]
        public Department Department { get; set; }
    }
}
