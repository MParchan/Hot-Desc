using Hot_Desc.DAL.Repositories.Interfaces;

namespace Hot_Desc.DAL.UnitOfWork
{
    public interface IUnitOfWork
    {
        IEmployeeRepository Employees { get; set; }
        IEquipmentRepository Equipments { get; set; }
        IEquipmentForWorkplaceRepository EquipmentsForWorkplaces { get; set;  }
        IReservationRepository Reservations { get; set; }
        IWorkplaceRepository Workplaces { get; set; }
    }
}
