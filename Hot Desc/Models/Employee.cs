using System.ComponentModel.DataAnnotations;

namespace Hot_Desc.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }

        [Display(Name = "Name")]
        [Required(ErrorMessage = "Name is required!")]
        [MaxLength(50, ErrorMessage = "Name can be up to 50 characters long")]
        public string FirstName { get; set; }

        [Display(Name = "Last name")]
        [Required(ErrorMessage = "Last name is required!")]
        [MaxLength(50, ErrorMessage = "Last name can be up to 50 characters long")]
        public string LastName { get; set; }

        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
