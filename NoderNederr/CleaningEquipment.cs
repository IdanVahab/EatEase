using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoderNederr
{
    class CleaningEquipment : DefTask
    {
        private List<CleaningMaterials> cleaningItemsNeeded;
        public CleaningEquipment(List<CleaningMaterials> cleaningItemsNeeded, ArrayList items, bool manager, DateTime startDate, DateTime dueDate, List<Employee> employees) : base(items, manager, startDate, dueDate, employees)
        {
            this.CleaningItemsNeeded = cleaningItemsNeeded;
        }

        internal List<CleaningMaterials> CleaningItemsNeeded { get => cleaningItemsNeeded; set => cleaningItemsNeeded = value; }
    }
}
