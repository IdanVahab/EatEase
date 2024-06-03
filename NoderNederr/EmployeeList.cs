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
    public partial class EmployeeList : Form
    {
        public EmployeeList()
        {
            InitializeComponent();
            foreach (Employee emp in Form1.employees)
                employeesPanel.Controls.Add(createLabel(emp.ToString()));
        }

        private Label createLabel(string text)
        {
            Label label = new Label();
            label.Text = text;
            label.AutoSize = true;
            label.BackColor = Color.White;
            label.ForeColor = Color.Blue;
            return label;
        }

        private void backToManu_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Location = this.Location;
            form.StartPosition = FormStartPosition.Manual;
            form.Show();
            this.Close();
        }


    }
}
