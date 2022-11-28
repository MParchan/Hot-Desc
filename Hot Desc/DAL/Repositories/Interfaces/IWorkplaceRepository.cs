using Hot_Desc.Models;

namespace Hot_Desc.DAL.Repositories.Interfaces
{
    public interface IWorkplaceRepository
    {
        Workplace GetById(int id);
        IEnumerable<Workplace> GetAll();
        public IEnumerable<Workplace> WorkplacesWithEquipments();
    }
    
}
