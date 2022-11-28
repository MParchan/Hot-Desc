using Hot_Desc.DAL.Repositories.Interfaces;
using Hot_Desc.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Linq.Expressions;

namespace Hot_Desc.DAL.Repositories
{
    public class ReservationRepository : IReservationRepository
    {
        protected readonly HotDescDbContext _context;
        public ReservationRepository(HotDescDbContext context)
        {
            _context = context;
        }
        public Reservation GetById(int id)
        {
            return _context.Reservations.Find(id);
        }
        public void Add(Reservation reservation)
        {
            _context.Reservations.Add(reservation);
            _context.SaveChanges();
        }
        public IEnumerable<Reservation> GetAll()
        {
            return _context.Reservations.ToList();
        }

        public IEnumerable<Reservation> GetAllWithEmployeeAndWorkplace()
        {
            return _context.Reservations.Include(r => r.Employee).Include(r => r.Workplace).ToList();
        }
    }
}
