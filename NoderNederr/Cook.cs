using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoderNederr
{
    class Cook : Employee
    {
        private RoleInKitchen role;
        public Cook(RoleInKitchen role, string name, int age) : base(name, age)
        {
            this.Role = role;
        }

        internal RoleInKitchen Role { get => role; set => role = value; }

        public override string ToString()
        {
            return base.ToString() + "Job : Cook\nRole in kitchen : " + this.role + "\n";
        }
     //   public bool IsCOOK() { return true; }
    }
    
}
