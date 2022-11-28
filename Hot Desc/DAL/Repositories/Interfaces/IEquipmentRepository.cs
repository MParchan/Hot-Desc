using Hot_Desc.Models;

namespace Hot_Desc.DAL.Repositories.Interfaces
{
    public interface IEquipmentRepository
    {
        Equipment GetById(int id);
        IEnumerable<Equipment> GetAll();
    }
}
