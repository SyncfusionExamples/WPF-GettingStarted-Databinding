using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sfdomainupdown_binding
{
    public class ViewModel
    {
        private List<Employee> employees;
        public List<Employee> Employees
        {
            get { return employees; }
            set { employees = value; }
        }
        public ViewModel()
        {
            Employees = new List<Employee>();
            populateItem();
        }
        private void populateItem()
        {
            Employees.Add(new Employee { Name = "Lucas", Email = "lucas@syncfusion.com" });
            Employees.Add(new Employee { Name = "James", Email = "james@syncfusion.com" });
            Employees.Add(new Employee { Name = "Jacob", Email = "jacob@syncfusion.com" });
        }
    }
}
