using Hot_Desc.DAL.Services.Interfaces;
using Hot_Desc.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;

namespace Hot_Desc.Controllers
{
    public class HotDescController : Controller
    {
        private readonly IHotDescService _service;
        public HotDescController(IHotDescService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            ViewBag.Employees = _service.GetEmployees();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DateReservation(int? employeeId)
        {
            if (employeeId != null)
            {
                HttpContext.Session.SetInt32("EmployeeId", (int)employeeId);
                ViewBag.Workplaces = _service.GetWorkplaces();
                return View();
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult RequiredEquipment(DateTime timeFrom, DateTime timeTo)
        {
            ViewBag.TimeFrom = timeFrom;
            ViewBag.TimeTo = timeTo;
            return View(_service.GetEquipments());
        }
   
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AvailableWorkplaces(DateTime timeFrom, DateTime timeTo, List<int> count)
        {
            ViewBag.EmployeeId = HttpContext.Session.GetInt32("EmployeeId");
            ViewBag.TimeFrom = timeFrom;
            ViewBag.TimeTo = timeTo;
            ViewBag.Workplaces = _service.AvailableWorkplaces(timeFrom, timeTo, count);
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateReservation([Bind("ReservationId,EmployeeId,WorkplaceId,TimeFrom,TimeTo")] Reservation reservation)
        {
            ViewBag.WorkplaceId = reservation.WorkplaceId;
            _service.AddReservation(reservation);
            return View();
        }

    }
}
