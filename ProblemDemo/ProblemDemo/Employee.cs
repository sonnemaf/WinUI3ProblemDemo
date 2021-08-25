using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemDemo {
    public class Employee {
        public Employee(string name, double salary) {
            this.Name = name;
            this.Salary = salary;
        }

        public string Name { get; set; }
        public double Salary { get; set; }
    }
}
