using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Hot_Desc.Models;
using Hot_Desc.DAL.Services.Interfaces;

namespace Hot_Desc.Controllers
{
    public class ReservationsController : Controller
    {
        private readonly IReservationService _service;

        public ReservationsController(IReservationService servis)
        {
            _service = servis;
        }
     
        public IActionResult Index()
        {
            ViewBag.Employees = _service.GetEmployees();
            return View(_service.CurrentReservations(null));
        }
        [HttpGet]
        public IActionResult Index(int? employeeId)
        {
            if(employeeId != null)
            {
                var employee = _service.GetEmployee((int)employeeId);
                ViewBag.Employee = employee.FirstName + " " + employee.LastName;
            }
            ViewBag.Employees = _service.GetEmployees();
            return View(_service.CurrentReservations(employeeId));
        }

    }
}
