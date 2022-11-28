using Hot_Desc.DAL.Services.Interfaces;
using Hot_Desc.DAL.UnitOfWork;
using Hot_Desc.Models;
using Microsoft.EntityFrameworkCore;

namespace Hot_Desc.DAL.Services
{
    public class ReservationService : IReservationService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ReservationService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<Reservation> GetReservationsWithEmployeeAndWorkplace()
        {
            return _unitOfWork.Reservations.GetAllWithEmployeeAndWorkplace();
        }

        public IEnumerable<Reservation> CurrentReservations()
        {
            var reservations = _unitOfWork.Reservations.GetAllWithEmployeeAndWorkplace().Where(r => DateTime.Compare(r.TimeTo, DateTime.Now) >= 0).ToList();
            return reservations;
        }
    }
}
