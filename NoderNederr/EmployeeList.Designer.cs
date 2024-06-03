
namespace NoderNederr
{
    partial class EmployeeList
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
            this.backToManu = new System.Windows.Forms.Button();
            this.employeesPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // backToManu
            // 
            this.backToManu.Location = new System.Drawing.Point(589, 407);
            this.backToManu.Name = "backToManu";
            this.backToManu.Size = new System.Drawing.Size(197, 29);
            this.backToManu.TabIndex = 0;
            this.backToManu.Text = "Back to menu";
            this.backToManu.UseVisualStyleBackColor = true;
            this.backToManu.Click += new System.EventHandler(this.backToManu_Click);
            // 
            // employeesPanel
            // 
            this.employeesPanel.Location = new System.Drawing.Point(12, 12);
            this.employeesPanel.Name = "employeesPanel";
            this.employeesPanel.Size = new System.Drawing.Size(776, 389);
            this.employeesPanel.TabIndex = 1;
            // 
            // EmployeeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.employeesPanel);
            this.Controls.Add(this.backToManu);
            this.Name = "EmployeeList";
            this.Text = "EmployeeList";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backToManu;
        private System.Windows.Forms.FlowLayoutPanel employeesPanel;
    }
}