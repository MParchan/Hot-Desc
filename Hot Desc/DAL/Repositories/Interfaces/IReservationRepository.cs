using Hot_Desc.Models;
using System.Linq.Expressions;

namespace Hot_Desc.DAL.Repositories.Interfaces
{
    public interface IReservationRepository
    {
        Reservation GetById(int id);
        IEnumerable<Reservation> GetAll();
        public IEnumerable<Reservation> GetAllWithEmployeeAndWorkplace();
        void Add(Reservation reservation);
    }
}
