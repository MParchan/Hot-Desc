using Hot_Desc.Models;

namespace Hot_Desc.DAL.Services.Interfaces
{
    public interface IReservationService
    {
        public IEnumerable<Reservation> GetReservationsWithEmployeeAndWorkplace();
        public IEnumerable<Reservation> CurrentReservations();
    }
}
