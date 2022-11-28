using Hot_Desc.DAL.Repositories.Interfaces;
using Hot_Desc.Models;

namespace Hot_Desc.DAL.Repositories
{
    public class EquipmentRepository : IEquipmentRepository
    {
        protected readonly HotDescDbContext _context;
        public EquipmentRepository(HotDescDbContext context)
        {
            _context = context;
        }
        public Equipment GetById(int id)
        {
            return _context.Equipments.Find(id);
        }
        public IEnumerable<Equipment> GetAll()
        {
            return _context.Equipments.ToList();
        }
    }
}
