using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoderNederr
{
    abstract class Task
    {
        private static int idCounter = 1;
        private int id;
        private bool done=false;
        private bool manager; //false=="Kitchen Manager",true=="Bar Manager"
        private DateTime startDate;
        private DateTime dueDate;
        private DateTime endDate;
        private List<Employee> employees;

        public Task(bool manager, DateTime startDate, DateTime dueDate, List<Employee> employees)
        {
            this.id = idCounter++;
            this.Manager = manager;
            this.StartDate = startDate;
            this.DueDate = dueDate;
            this.Employees = employees;
        }

        public int Id { get => id; set => id = value; }
        public bool Done { get => done; set => done = value; }
        public bool Manager { get => manager; set => manager = value; }
        public DateTime StartDate { get => startDate; set => startDate = value; }
        public DateTime DueDate { get => dueDate; set => dueDate = value; }
        public DateTime EndDate { get => endDate; set => endDate = value; }
        internal List<Employee> Employees { get => employees; set => employees = value; }

        public override string ToString()
        {
            return "ID : " + this.id + "\nFirst date  : " + this.startDate + "\nDue in : " + this.dueDate + "\nManager : " + (manager ? "Shaked Mashilker" : "Idan Vahab") + "Employees : " + this.employees + "Is done : " + (done ? "Yes\nFinish date : " + this.endDate : "No\n");
        }
    }
}
