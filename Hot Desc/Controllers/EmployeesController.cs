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
    public class EmployeesController : Controller
    {
        private readonly IEmployeeService _service;

        public EmployeesController(IEmployeeService servise)
        {
            _service = servise;
        }

       
        // GET: Employees/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Employees/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("EmployeeId,FirstName,LastName")] Employee employee)
        {
            if (ModelState.IsValid)
            {
                _service.AddEmployee(employee);
                return RedirectToAction("Index", "HotDesc");
            }
            return View(employee);
        }

       
    }
}
