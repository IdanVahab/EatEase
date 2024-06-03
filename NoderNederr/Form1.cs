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
    public partial class Form1 : Form
    {
        public static List<Employee> employees = new List<Employee>();
        public Form1()
        {
            InitializeComponent();
        }

        private void createEmployee_Click(object sender, EventArgs e)
        {
            CreateEmployee form = new CreateEmployee();
            form.Location = this.Location;
            form.StartPosition = FormStartPosition.Manual;
            form.Show();
            this.Close();
        }

        private void listOfEmployees_Click(object sender, EventArgs e)
        {
            EmployeeList form = new EmployeeList();
            form.Location = this.Location;
            form.StartPosition = FormStartPosition.Manual;
            form.Show();
            this.Close();
        }

        private void createTask_Click(object sender, EventArgs e)
        {

        }

        private void listOfTasks_Click(object sender, EventArgs e)
        {

        }
    }
}
