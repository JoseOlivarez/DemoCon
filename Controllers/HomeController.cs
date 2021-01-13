using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DemoCon.Models;
namespace DemoCon.Controllers 
{
    public class HomeController : Controller
    {
        // GET: HomeController
        public ViewResult Index()
        {
            var model = new Employee();
            using (var context = new dbContextEmployee())
            {
                SQLEmployeeData sqlData = new SQLEmployeeData(context); //instance of sql employeedata funciton
                sqlData.Add(model); // employee model
            }
            return View();
        }
        public class SQLEmployeeData
        {
            private dbContextEmployee _context { get; set; }
            public SQLEmployeeData(dbContextEmployee context)
            {
                _context = context;
            }
            public void Add(Employee emp)
            {
                _context.Add(emp);
                _context.SaveChanges();
            }
            //public Employee Get(int ID)
            //{
            //    return _context.EmployeeName.FirstOrDefault(e => e.Id == ID);
            //}
            public IEnumerable<Employee> GetAll()
            {
                return _context.EmployeeName.ToList<Employee>();
            }
        }
            // GET: HomeController/Details/5
            public ActionResult Details(int id)
        {
            return View();
        }

        // GET: HomeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HomeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HomeController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HomeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HomeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HomeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
