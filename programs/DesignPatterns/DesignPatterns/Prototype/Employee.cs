using System;
using System.Collections.Generic;

namespace DesignPatterns
{
    class Employee : ICloneable
    {
        private string name;
        private string id;
        private double salary;
        public Employee(string name, string id, double salary)
        {
            this.name = name;
            this.id = id;
            this.salary = salary;
        }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
        public String toString()
        {
            return "Name : " + this.name + ", Id : " + this.id + ", Salary : " + this.salary;
        }
    }
}
