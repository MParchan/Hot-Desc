using Hot_Desc.DAL.Repositories.Interfaces;
using Hot_Desc.DAL.Services.Interfaces;
using Hot_Desc.DAL.UnitOfWork;
using Hot_Desc.Models;
using Microsoft.EntityFrameworkCore;

namespace Hot_Desc.DAL.Services
{
    public class HotDescService : IHotDescService
    {
        private readonly IUnitOfWork _unitOfWork;

        public HotDescService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<Employee> GetEmployees()
        {
            return _unitOfWork.Employees.GetAll();
        }

        public IEnumerable<Workplace> GetWorkplaces()
        {
            return _unitOfWork.Workplaces.GetAll();
        }

        public IEnumerable<Equipment> GetEquipments()
        {
            return _unitOfWork.Equipments.GetAll();
        }
        public void AddReservation(Reservation reservation)
        {
            _unitOfWork.Reservations.Add(reservation);
        }
        public IEnumerable<Workplace> AvailableWorkplaces(DateTime timeFrom, DateTime timeTo, List<int> count)
        {
            var reservedWorkplaces = _unitOfWork.Reservations.GetAll().Where(r =>
                                        (DateTime.Compare(r.TimeFrom, timeFrom) >= 0 && DateTime.Compare(r.TimeFrom, timeTo) <= 0) ||
                                        (DateTime.Compare(r.TimeFrom, timeFrom) <= 0 && DateTime.Compare(r.TimeTo, timeFrom) >= 0)).ToList().Select(r => r.WorkplaceId).ToList();
            var workplaces = _unitOfWork.Workplaces.GetAll();
            List<Workplace> availableWorkplaces = new();
            foreach (var workplace in workplaces)
            {
                if (!reservedWorkplaces.Contains(workplace.WorkplaceId))
                {
                    bool suit = true;
                    for (int i = 0; i < count.Count; i++)
                    {
                        var eq = _unitOfWork.EquipmentsForWorkplaces.Find(e => e.WorkplaceId == workplace.WorkplaceId && e.EquipmentId == i + 1);
                        if (eq != null)
                        {
                            if (eq.Count < count[i])
                            {
                                suit = false;
                                break;
                            }
                        }
                    }
                    if (suit == true)
                    {
                        availableWorkplaces.Add(workplace);
                    }
                }
            }
            return availableWorkplaces;
        }


    }
}
