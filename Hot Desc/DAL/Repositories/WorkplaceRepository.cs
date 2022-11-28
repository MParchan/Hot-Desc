using Hot_Desc.DAL.Repositories.Interfaces;
using Hot_Desc.Models;
using Microsoft.EntityFrameworkCore;

namespace Hot_Desc.DAL.Repositories
{
    public class WorkplaceRepository : IWorkplaceRepository
    {
        protected readonly HotDescDbContext _context;
        public WorkplaceRepository(HotDescDbContext context)
        {
            _context = context;
        }
        public Workplace GetById(int id)
        {
            return _context.Workplaces.Find(id);
        }
        public IEnumerable<Workplace> GetAll()
        {
            return _context.Workplaces.ToList();
        }
        public IEnumerable<Workplace> WorkplacesWithEquipments()
        {
            return _context.Workplaces.Include(w => w.EquipmentForWorkplaces).ToList();
        }
    }
}
