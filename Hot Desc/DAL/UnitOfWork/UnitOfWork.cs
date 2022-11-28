using Hot_Desc.DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Hot_Desc.DAL.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork(
        IEmployeeRepository employeesRepository,
        IWorkplaceRepository workplaceRepository,
        IEquipmentRepository equipmentRepository,
        IEquipmentForWorkplaceRepository equipmentForWorkplaceRepository,
        IReservationRepository reservationRepository)
        {
            Employees = employeesRepository;
            Workplaces = workplaceRepository;
            Equipments = equipmentRepository;
            EquipmentsForWorkplaces = equipmentForWorkplaceRepository;
            Reservations = reservationRepository;
        }

        public IEmployeeRepository Employees { get; set; }
        public IWorkplaceRepository Workplaces { get; set; }
        public IEquipmentRepository Equipments { get; set; }
        public IEquipmentForWorkplaceRepository EquipmentsForWorkplaces { get; set; }
        public IReservationRepository Reservations { get; set; }
    }
}
