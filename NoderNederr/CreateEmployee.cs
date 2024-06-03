using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoderNederr
{
    public partial class CreateEmployee : Form
    {
        public CreateEmployee()
        {
            InitializeComponent();
            jobQuestion.Text = "";
        }

        private void createEmp_Click(object sender, EventArgs e)
        {
            Employee newEmp;
            if (cook.Checked)
            {
                newEmp = new Cook((RoleInKitchen)roles.SelectedItem, nameBox.Text, (int)employeeAge.Value);
                Form1.employees.Add(newEmp);
            }
            else if (bartender.Checked)
            {
                newEmp = new Bartender(((roles.SelectedItem == "Service") ? true : false), nameBox.Text, (int)employeeAge.Value);
                Form1.employees.Add(newEmp);
            }
        }

        private void bartender_CheckedChanged(object sender, EventArgs e)
        {
            string[] isService = { "Service", "Rak Bonim NODDER!!!1" };
            if (cook.Checked)
            {
                roles.DataSource = Enum.GetValues(typeof(RoleInKitchen));
                jobQuestion.Text = "Role in kitchen:";
            }
               
            else if (bartender.Checked)
            {
                roles.DataSource = isService;
                jobQuestion.Text = "Role in bar:";
            }
               
        }

        private void returnToMenu_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Location = this.Location;
            form.StartPosition = FormStartPosition.Manual;
            form.Show();
            this.Close();
        }
    }
}
