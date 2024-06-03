using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoderNederr
{
    class Restock : DefTask
    {
        private bool isInStock; // true == Restock the
        public Restock(bool isInStock, ArrayList items, bool manager, DateTime startDate, DateTime dueDate, List<Employee> employees) : base(items, manager, startDate, dueDate, employees)
        {
            this.IsInStock = isInStock;
        }

        public bool IsInStock { get => isInStock; set => isInStock = value; }
    }
}
