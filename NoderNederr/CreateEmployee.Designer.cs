
namespace NoderNederr
{
    partial class CreateEmployee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.returnToMenu = new System.Windows.Forms.Button();
            this.nameLable = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.employeeAge = new System.Windows.Forms.NumericUpDown();
            this.jobs = new System.Windows.Forms.GroupBox();
            this.bartender = new System.Windows.Forms.RadioButton();
            this.cook = new System.Windows.Forms.RadioButton();
            this.createEmp = new System.Windows.Forms.Button();
            this.roles = new System.Windows.Forms.ComboBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.jobQuestion = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.employeeAge)).BeginInit();
            this.jobs.SuspendLayout();
            this.SuspendLayout();
            // 
            // returnToMenu
            // 
            this.returnToMenu.Location = new System.Drawing.Point(649, 409);
            this.returnToMenu.Name = "returnToMenu";
            this.returnToMenu.Size = new System.Drawing.Size(139, 29);
            this.returnToMenu.TabIndex = 0;
            this.returnToMenu.Text = "Return to menu";
            this.returnToMenu.UseVisualStyleBackColor = true;
            this.returnToMenu.Click += new System.EventHandler(this.returnToMenu_Click);
            // 
            // nameLable
            // 
            this.nameLable.AutoSize = true;
            this.nameLable.Location = new System.Drawing.Point(106, 58);
            this.nameLable.Name = "nameLable";
            this.nameLable.Size = new System.Drawing.Size(52, 20);
            this.nameLable.TabIndex = 1;
            this.nameLable.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Age:";
            // 
            // employeeAge
            // 
            this.employeeAge.Location = new System.Drawing.Point(192, 105);
            this.employeeAge.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.employeeAge.Minimum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.employeeAge.Name = "employeeAge";
            this.employeeAge.Size = new System.Drawing.Size(150, 27);
            this.employeeAge.TabIndex = 4;
            this.employeeAge.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // jobs
            // 
            this.jobs.Controls.Add(this.bartender);
            this.jobs.Controls.Add(this.cook);
            this.jobs.Location = new System.Drawing.Point(192, 181);
            this.jobs.Name = "jobs";
            this.jobs.Size = new System.Drawing.Size(360, 133);
            this.jobs.TabIndex = 5;
            this.jobs.TabStop = false;
            this.jobs.Text = "Job:";
            // 
            // bartender
            // 
            this.bartender.AutoSize = true;
            this.bartender.Location = new System.Drawing.Point(201, 55);
            this.bartender.Name = "bartender";
            this.bartender.Size = new System.Drawing.Size(95, 24);
            this.bartender.TabIndex = 1;
            this.bartender.TabStop = true;
            this.bartender.Text = "Bartender";
            this.bartender.UseVisualStyleBackColor = true;
            this.bartender.CheckedChanged += new System.EventHandler(this.bartender_CheckedChanged);
            // 
            // cook
            // 
            this.cook.AutoSize = true;
            this.cook.Location = new System.Drawing.Point(56, 55);
            this.cook.Name = "cook";
            this.cook.Size = new System.Drawing.Size(64, 24);
            this.cook.TabIndex = 0;
            this.cook.TabStop = true;
            this.cook.Text = "Cook";
            this.cook.UseVisualStyleBackColor = true;
            this.cook.CheckedChanged += new System.EventHandler(this.bartender_CheckedChanged);
            // 
            // createEmp
            // 
            this.createEmp.Location = new System.Drawing.Point(342, 342);
            this.createEmp.Name = "createEmp";
            this.createEmp.Size = new System.Drawing.Size(62, 29);
            this.createEmp.TabIndex = 6;
            this.createEmp.Text = "Create";
            this.createEmp.UseVisualStyleBackColor = true;
            this.createEmp.Click += new System.EventHandler(this.createEmp_Click);
            // 
            // roles
            // 
            this.roles.FormattingEnabled = true;
            this.roles.Location = new System.Drawing.Point(585, 232);
            this.roles.Name = "roles";
            this.roles.Size = new System.Drawing.Size(151, 28);
            this.roles.TabIndex = 7;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(192, 58);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(125, 27);
            this.nameBox.TabIndex = 8;
            // 
            // jobQuestion
            // 
            this.jobQuestion.AutoSize = true;
            this.jobQuestion.Location = new System.Drawing.Point(585, 190);
            this.jobQuestion.Name = "jobQuestion";
            this.jobQuestion.Size = new System.Drawing.Size(33, 20);
            this.jobQuestion.TabIndex = 9;
            this.jobQuestion.Text = "----";
            // 
            // CreateEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.jobQuestion);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.roles);
            this.Controls.Add(this.createEmp);
            this.Controls.Add(this.jobs);
            this.Controls.Add(this.employeeAge);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameLable);
            this.Controls.Add(this.returnToMenu);
            this.Name = "CreateEmployee";
            this.Text = "CreateEmployee";
            ((System.ComponentModel.ISupportInitialize)(this.employeeAge)).EndInit();
            this.jobs.ResumeLayout(false);
            this.jobs.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button returnToMenu;
        private System.Windows.Forms.Label nameLable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown employeeAge;
        private System.Windows.Forms.GroupBox jobs;
        private System.Windows.Forms.RadioButton bartender;
        private System.Windows.Forms.RadioButton cook;
        private System.Windows.Forms.Button createEmp;
        private System.Windows.Forms.ComboBox roles;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label jobQuestion;
        private System.Windows.Forms.Timer timer1;
    }
}