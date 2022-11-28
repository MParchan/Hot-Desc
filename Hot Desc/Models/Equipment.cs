namespace Hot_Desc.Models
{
    public class Equipment
    {
        public int EquipmentId { get; set; }
        public string Type { get; set; }

        public virtual ICollection<EquipmentForWorkplace> EquipmentForWorkplace { get; set; }
    }
}
