
namespace NoderNederr
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.createEmployee = new System.Windows.Forms.Button();
            this.listOfEmployees = new System.Windows.Forms.Button();
            this.createTask = new System.Windows.Forms.Button();
            this.listOfTasks = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createEmployee
            // 
            this.createEmployee.Location = new System.Drawing.Point(112, 57);
            this.createEmployee.Name = "createEmployee";
            this.createEmployee.Size = new System.Drawing.Size(249, 84);
            this.createEmployee.TabIndex = 0;
            this.createEmployee.Text = "Create Employee";
            this.createEmployee.UseVisualStyleBackColor = true;
            this.createEmployee.Click += new System.EventHandler(this.createEmployee_Click);
            // 
            // listOfEmployees
            // 
            this.listOfEmployees.Location = new System.Drawing.Point(112, 225);
            this.listOfEmployees.Name = "listOfEmployees";
            this.listOfEmployees.Size = new System.Drawing.Size(249, 84);
            this.listOfEmployees.TabIndex = 1;
            this.listOfEmployees.Text = "List of employees";
            this.listOfEmployees.UseVisualStyleBackColor = true;
            this.listOfEmployees.Click += new System.EventHandler(this.listOfEmployees_Click);
            // 
            // createTask
            // 
            this.createTask.Location = new System.Drawing.Point(451, 57);
            this.createTask.Name = "createTask";
            this.createTask.Size = new System.Drawing.Size(249, 84);
            this.createTask.TabIndex = 2;
            this.createTask.Text = "Create task";
            this.createTask.UseVisualStyleBackColor = true;
            this.createTask.Click += new System.EventHandler(this.createTask_Click);
            // 
            // listOfTasks
            // 
            this.listOfTasks.Location = new System.Drawing.Point(451, 225);
            this.listOfTasks.Name = "listOfTasks";
            this.listOfTasks.Size = new System.Drawing.Size(249, 84);
            this.listOfTasks.TabIndex = 3;
            this.listOfTasks.Text = "List of tasks";
            this.listOfTasks.UseVisualStyleBackColor = true;
            this.listOfTasks.Click += new System.EventHandler(this.listOfTasks_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listOfTasks);
            this.Controls.Add(this.createTask);
            this.Controls.Add(this.listOfEmployees);
            this.Controls.Add(this.createEmployee);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button createEmployee;
        private System.Windows.Forms.Button listOfEmployees;
        private System.Windows.Forms.Button createTask;
        private System.Windows.Forms.Button listOfTasks;
    }
}

