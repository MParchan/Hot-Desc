using System.ComponentModel.DataAnnotations;

namespace Hot_Desc.Models
{
    public class EquipmentForWorkplace
    {
        public int EquipmentForWorkplaceId { get; set; }
        public int WorkplaceId { get; set; }

        [Display(Name = "Type of equipment")]
        [Required(ErrorMessage = "Type of equipment is required!")]
        public int EquipmentId { get; set; }

        [Display(Name = "Count")]
        [Required(ErrorMessage = "Count is required!")]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter correct number")]
        public int Count { get; set; }

        public virtual Workplace Workplace { get; set; }
        public virtual Equipment Equipment { get; set; }
    }
}
