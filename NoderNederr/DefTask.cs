using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoderNederr
{
    abstract class DefTask : Task
    {
        //private bool isRestock;
        private ArrayList items;
        protected DefTask(ArrayList items, bool manager, DateTime startDate, DateTime dueDate, List<Employee> employees) : base(manager, startDate, dueDate, employees)
        {
            this.items = items;
        }

        public ArrayList Items { get => items; set => items = value; }

        public override string ToString()
        {
            return this.items + "\n" + base.ToString();
        }
    }
}
