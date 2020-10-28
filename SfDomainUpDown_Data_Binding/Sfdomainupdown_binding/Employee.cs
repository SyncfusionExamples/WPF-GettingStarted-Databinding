using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sfdomainupdown_binding
{
    public class Employee
    {
        private string name;
        private string email;
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
