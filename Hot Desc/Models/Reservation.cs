using System.ComponentModel.DataAnnotations;

namespace Hot_Desc.Models
{
    public class Reservation
    {
        public int ReservationId { get; set; }
        public int EmployeeId { get; set; }

        [Required(ErrorMessage = "Selecting a workplace is required!")]
        public int WorkplaceId { get; set; }

        [Display(Name = "Start date")]
        [Required(ErrorMessage = "Start date is required!")]
        public DateTime TimeFrom { get; set; }

        [Display(Name = "End date")]
        [Required(ErrorMessage = "End date is required!")]
        public DateTime TimeTo { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual Workplace Workplace { get; set; }
    }
}
