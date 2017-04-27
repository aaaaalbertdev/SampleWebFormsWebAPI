using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Presentation.Models;

namespace Presentation
{
    public class EmployeesController : ApiController
    {
        Employee[] employees = new Employee[] {
            new Employee {EmployeeID=1, FirstName="Albert Rick", LastName="Martires", Status="Active"},
            new Employee {EmployeeID=2, FirstName="Ellen", LastName="Adarna", Status="Active"},
            new Employee {EmployeeID=3, FirstName="Blake", LastName="Lively", Status="Active"},
            new Employee {EmployeeID=4, FirstName="Liza", LastName="Soberano", Status="Active"},
            new Employee {EmployeeID=5, FirstName="Gal", LastName="Gadot", Status="Resigned"},
            new Employee {EmployeeID=6, FirstName="Katie", LastName="Cassidy", Status="Resigned"},
            new Employee {EmployeeID=7, FirstName="Caity", LastName="Lotz", Status="Transferred"},
            new Employee {EmployeeID=8, FirstName="Yam", LastName="Concepcion", Status="Transferred"},
            new Employee {EmployeeID=9, FirstName="Ritz", LastName="Azul", Status="Resigned"}
        };

        [HttpGet]
        public IEnumerable<Entities.Employee> GetEmployees()
        {
            return employees;
        }

        [HttpGet]
        public IEnumerable<Entities.Employee> GetEmployeesByStatus(string status)
        {
            return employees.Where(
                (p) => string.Equals(p.Status, status,
                    StringComparison.OrdinalIgnoreCase));
        }

        [HttpGet]
        public Employee GetEmployeeById(long id)
        {
            var employee = employees.FirstOrDefault((p) => p.EmployeeID == id);
            if (employee == null)
            {
                return null;
            }
            return employee;
        }

        public void Post([FromBody]string value)
        {
        }

        public void Put(int id, [FromBody]string value)
        {
        }

        public void Delete(int id)
        {
        }
    }
}