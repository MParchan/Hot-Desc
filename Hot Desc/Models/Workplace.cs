namespace Hot_Desc.Models
{
    public class Workplace
    {
        public int WorkplaceId { get; set; }
        public int Floor { get; set; }
        public int Room { get; set; }
        public int Table { get; set; }

        public virtual ICollection<Reservation> Reservations { get; set; }
        public virtual ICollection<EquipmentForWorkplace> EquipmentForWorkplaces { get; set; }
    }
}
