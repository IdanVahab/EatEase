using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoderNederr
{
    class Bartender : Employee
    {
        private bool service;
        public Bartender(bool service, string name, int age) : base(name, age)
        {
            this.Service = service;
        }

        public bool Service { get => service; set => service = value; }

        public override string  ToString()
        {
            return base.ToString() + "Job : Bartender\nIs give service : " + this.service + "\n";
        }
      //  public bool IsCOOK() { return false; }
    }
}
