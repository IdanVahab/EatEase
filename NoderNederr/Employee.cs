using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoderNederr
{
    public abstract class Employee
    {
        private static int idCount = 1;
        private int id;
        private string name;
        private int age;

        public Employee(string name, int age)
        {
            this.id = idCount++;
            this.Age = age;
            this.Name = name;
        }

        public int Id { get => id; }
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public override string ToString()
        {
            return "ID : " + this.id + "\nName : " + this.name + "\nAge : " + this.age;
        }
        //   public bool IsCook() { return true; }
    }
}
