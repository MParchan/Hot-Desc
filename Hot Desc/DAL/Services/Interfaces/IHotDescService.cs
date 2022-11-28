using Hot_Desc.Models;

namespace Hot_Desc.DAL.Services.Interfaces
{
    public interface IHotDescService
    {
        public IEnumerable<Employee> GetEmployees();
        public IEnumerable<Workplace> GetWorkplaces();
        public IEnumerable<Equipment> GetEquipments();
        public void AddReservation(Reservation reservation);
        public IEnumerable<Workplace> AvailableWorkplaces(DateTime timeFrom, DateTime timeTo, List<int> count);
    }
}
