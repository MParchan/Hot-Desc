using Hot_Desc.Models;
using System.Linq.Expressions;

namespace Hot_Desc.DAL.Repositories.Interfaces
{
    public interface IEquipmentForWorkplaceRepository
    {
        EquipmentForWorkplace GetById(int id);
        IEnumerable<EquipmentForWorkplace> GetAll();
        public EquipmentForWorkplace Find(Expression<Func<EquipmentForWorkplace, bool>> expression);
    }
}
