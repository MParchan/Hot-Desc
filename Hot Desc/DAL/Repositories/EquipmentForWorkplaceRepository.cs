using Hot_Desc.DAL.Repositories.Interfaces;
using Hot_Desc.Models;
using System.Linq.Expressions;

namespace Hot_Desc.DAL.Repositories
{
    public class EquipmentForWorkplaceRepository : IEquipmentForWorkplaceRepository
    {
        protected readonly HotDescDbContext _context;
        public EquipmentForWorkplaceRepository(HotDescDbContext context)
        {
            _context = context;
        }
        public EquipmentForWorkplace GetById(int id)
        {
            return _context.EquipmentsForWorkplaces.Find(id);
        }
        public IEnumerable<EquipmentForWorkplace> GetAll()
        {
            return _context.EquipmentsForWorkplaces.ToList();
        }
        public EquipmentForWorkplace Find(Expression<Func<EquipmentForWorkplace, bool>> expression)
        {
            return _context.EquipmentsForWorkplaces.Where(expression).FirstOrDefault();
        }
    }
}
