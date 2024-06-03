
namespace NoderNederr
{
    partial class NewTask
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.isBarPanel = new System.Windows.Forms.Panel();
            this.barTaskRadio = new System.Windows.Forms.RadioButton();
            this.kitchenTaskRadio = new System.Windows.Forms.RadioButton();
            this.dateLabel = new System.Windows.Forms.Label();
            this.startDateBox = new System.Windows.Forms.MaskedTextBox();
            this.dueDateBox = new System.Windows.Forms.MaskedTextBox();
            this.dueInLabel = new System.Windows.Forms.Label();
            this.chooseEmployeesLabel = new System.Windows.Forms.Label();
            this.employeesListBox = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.restockRadio = new System.Windows.Forms.RadioButton();
            this.cleanEquipmentRadio = new System.Windows.Forms.RadioButton();
            this.unDefRadio = new System.Windows.Forms.RadioButton();
            this.homePageBotton = new System.Windows.Forms.Button();
            this.isBarPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // isBarPanel
            // 
            this.isBarPanel.Controls.Add(this.barTaskRadio);
            this.isBarPanel.Controls.Add(this.kitchenTaskRadio);
            this.isBarPanel.Location = new System.Drawing.Point(78, 96);
            this.isBarPanel.Name = "isBarPanel";
            this.isBarPanel.Size = new System.Drawing.Size(378, 74);
            this.isBarPanel.TabIndex = 0;
            // 
            // barTaskRadio
            // 
            this.barTaskRadio.AutoSize = true;
            this.barTaskRadio.Location = new System.Drawing.Point(13, 26);
            this.barTaskRadio.Name = "barTaskRadio";
            this.barTaskRadio.Size = new System.Drawing.Size(82, 24);
            this.barTaskRadio.TabIndex = 1;
            this.barTaskRadio.TabStop = true;
            this.barTaskRadio.Text = "Bar task";
            this.barTaskRadio.UseVisualStyleBackColor = true;
            // 
            // kitchenTaskRadio
            // 
            this.kitchenTaskRadio.AutoSize = true;
            this.kitchenTaskRadio.Location = new System.Drawing.Point(242, 26);
            this.kitchenTaskRadio.Name = "kitchenTaskRadio";
            this.kitchenTaskRadio.Size = new System.Drawing.Size(109, 24);
            this.kitchenTaskRadio.TabIndex = 0;
            this.kitchenTaskRadio.TabStop = true;
            this.kitchenTaskRadio.Text = "Kitchen task";
            this.kitchenTaskRadio.UseVisualStyleBackColor = true;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(78, 33);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(44, 20);
            this.dateLabel.TabIndex = 1;
            this.dateLabel.Text = "Date:";
            // 
            // startDateBox
            // 
            this.startDateBox.Location = new System.Drawing.Point(164, 33);
            this.startDateBox.Mask = "00/00/0000";
            this.startDateBox.Name = "startDateBox";
            this.startDateBox.Size = new System.Drawing.Size(125, 27);
            this.startDateBox.TabIndex = 2;
            this.startDateBox.ValidatingType = typeof(System.DateTime);
            // 
            // dueDateBox
            // 
            this.dueDateBox.Location = new System.Drawing.Point(417, 33);
            this.dueDateBox.Mask = "00/00/0000";
            this.dueDateBox.Name = "dueDateBox";
            this.dueDateBox.Size = new System.Drawing.Size(125, 27);
            this.dueDateBox.TabIndex = 4;
            this.dueDateBox.ValidatingType = typeof(System.DateTime);
            // 
            // dueInLabel
            // 
            this.dueInLabel.AutoSize = true;
            this.dueInLabel.Location = new System.Drawing.Point(331, 33);
            this.dueInLabel.Name = "dueInLabel";
            this.dueInLabel.Size = new System.Drawing.Size(55, 20);
            this.dueInLabel.TabIndex = 3;
            this.dueInLabel.Text = "Due in:";
            // 
            // chooseEmployeesLabel
            // 
            this.chooseEmployeesLabel.AutoSize = true;
            this.chooseEmployeesLabel.Location = new System.Drawing.Point(462, 96);
            this.chooseEmployeesLabel.Name = "chooseEmployeesLabel";
            this.chooseEmployeesLabel.Size = new System.Drawing.Size(50, 20);
            this.chooseEmployeesLabel.TabIndex = 5;
            this.chooseEmployeesLabel.Text = "label1";
            // 
            // employeesListBox
            // 
            this.employeesListBox.FormattingEnabled = true;
            this.employeesListBox.ItemHeight = 20;
            this.employeesListBox.Location = new System.Drawing.Point(462, 119);
            this.employeesListBox.Name = "employeesListBox";
            this.employeesListBox.Size = new System.Drawing.Size(215, 24);
            this.employeesListBox.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.restockRadio);
            this.panel1.Controls.Add(this.cleanEquipmentRadio);
            this.panel1.Controls.Add(this.unDefRadio);
            this.panel1.Location = new System.Drawing.Point(78, 188);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(158, 121);
            this.panel1.TabIndex = 7;
            // 
            // restockRadio
            // 
            this.restockRadio.AutoSize = true;
            this.restockRadio.Location = new System.Drawing.Point(13, 76);
            this.restockRadio.Name = "restockRadio";
            this.restockRadio.Size = new System.Drawing.Size(81, 24);
            this.restockRadio.TabIndex = 2;
            this.restockRadio.TabStop = true;
            this.restockRadio.Text = "Restock";
            this.restockRadio.UseVisualStyleBackColor = true;
            // 
            // cleanEquipmentRadio
            // 
            this.cleanEquipmentRadio.AutoSize = true;
            this.cleanEquipmentRadio.Location = new System.Drawing.Point(13, 46);
            this.cleanEquipmentRadio.Name = "cleanEquipmentRadio";
            this.cleanEquipmentRadio.Size = new System.Drawing.Size(143, 24);
            this.cleanEquipmentRadio.TabIndex = 1;
            this.cleanEquipmentRadio.TabStop = true;
            this.cleanEquipmentRadio.Text = "Clean equipment";
            this.cleanEquipmentRadio.UseVisualStyleBackColor = true;
            // 
            // unDefRadio
            // 
            this.unDefRadio.AutoSize = true;
            this.unDefRadio.Location = new System.Drawing.Point(13, 16);
            this.unDefRadio.Name = "unDefRadio";
            this.unDefRadio.Size = new System.Drawing.Size(122, 24);
            this.unDefRadio.TabIndex = 0;
            this.unDefRadio.TabStop = true;
            this.unDefRadio.Text = "UnDefine task";
            this.unDefRadio.UseVisualStyleBackColor = true;
            // 
            // homePageBotton
            // 
            this.homePageBotton.Location = new System.Drawing.Point(632, 409);
            this.homePageBotton.Name = "homePageBotton";
            this.homePageBotton.Size = new System.Drawing.Size(156, 29);
            this.homePageBotton.TabIndex = 8;
            this.homePageBotton.Text = "Back to homepage";
            this.homePageBotton.UseVisualStyleBackColor = true;
            // 
            // NewTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.homePageBotton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.employeesListBox);
            this.Controls.Add(this.chooseEmployeesLabel);
            this.Controls.Add(this.dueDateBox);
            this.Controls.Add(this.dueInLabel);
            this.Controls.Add(this.startDateBox);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.isBarPanel);
            this.Name = "NewTask";
            this.Text = "NewTask";
            this.isBarPanel.ResumeLayout(false);
            this.isBarPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel isBarPanel;
        private System.Windows.Forms.RadioButton barTaskRadio;
        private System.Windows.Forms.RadioButton kitchenTaskRadio;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.MaskedTextBox startDateBox;
        private System.Windows.Forms.MaskedTextBox dueDateBox;
        private System.Windows.Forms.Label dueInLabel;
        private System.Windows.Forms.Label chooseEmployeesLabel;
        private System.Windows.Forms.ListBox employeesListBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton restockRadio;
        private System.Windows.Forms.RadioButton cleanEquipmentRadio;
        private System.Windows.Forms.RadioButton unDefRadio;
        private System.Windows.Forms.Button homePageBotton;
    }
}