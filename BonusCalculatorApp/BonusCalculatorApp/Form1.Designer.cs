namespace BonusCalculatorApp
{
    partial class bonusCalculatorUI
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
            this.salaryLebel = new System.Windows.Forms.Label();
            this.showButton = new System.Windows.Forms.Button();
            this.bonusLebel = new System.Windows.Forms.Label();
            this.totalSalaryLebel = new System.Windows.Forms.Label();
            this.salaryTextBox = new System.Windows.Forms.TextBox();
            this.bonusTextBox = new System.Windows.Forms.TextBox();
            this.totalSalaryTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // salaryLebel
            // 
            this.salaryLebel.AutoSize = true;
            this.salaryLebel.Location = new System.Drawing.Point(42, 30);
            this.salaryLebel.Name = "salaryLebel";
            this.salaryLebel.Size = new System.Drawing.Size(92, 13);
            this.salaryLebel.TabIndex = 0;
            this.salaryLebel.Text = "Enter Your Salary:";
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(135, 98);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(118, 23);
            this.showButton.TabIndex = 1;
            this.showButton.Text = "Show Total Salary";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // bonusLebel
            // 
            this.bonusLebel.AutoSize = true;
            this.bonusLebel.Location = new System.Drawing.Point(45, 60);
            this.bonusLebel.Name = "bonusLebel";
            this.bonusLebel.Size = new System.Drawing.Size(65, 13);
            this.bonusLebel.TabIndex = 2;
            this.bonusLebel.Text = "Your Bonus:";
            // 
            // totalSalaryLebel
            // 
            this.totalSalaryLebel.AutoSize = true;
            this.totalSalaryLebel.Location = new System.Drawing.Point(45, 151);
            this.totalSalaryLebel.Name = "totalSalaryLebel";
            this.totalSalaryLebel.Size = new System.Drawing.Size(76, 13);
            this.totalSalaryLebel.TabIndex = 3;
            this.totalSalaryLebel.Text = "Total Salary is:";
            // 
            // salaryTextBox
            // 
            this.salaryTextBox.Location = new System.Drawing.Point(153, 30);
            this.salaryTextBox.Name = "salaryTextBox";
            this.salaryTextBox.Size = new System.Drawing.Size(100, 20);
            this.salaryTextBox.TabIndex = 4;
            // 
            // bonusTextBox
            // 
            this.bonusTextBox.Location = new System.Drawing.Point(153, 60);
            this.bonusTextBox.Name = "bonusTextBox";
            this.bonusTextBox.Size = new System.Drawing.Size(100, 20);
            this.bonusTextBox.TabIndex = 5;
            // 
            // totalSalaryTextBox
            // 
            this.totalSalaryTextBox.Location = new System.Drawing.Point(153, 144);
            this.totalSalaryTextBox.Name = "totalSalaryTextBox";
            this.totalSalaryTextBox.Size = new System.Drawing.Size(100, 20);
            this.totalSalaryTextBox.TabIndex = 6;
            // 
            // bonusCalculatorUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 176);
            this.Controls.Add(this.totalSalaryTextBox);
            this.Controls.Add(this.bonusTextBox);
            this.Controls.Add(this.salaryTextBox);
            this.Controls.Add(this.totalSalaryLebel);
            this.Controls.Add(this.bonusLebel);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.salaryLebel);
            this.Name = "bonusCalculatorUI";
            this.Text = "Bonus Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label salaryLebel;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Label bonusLebel;
        private System.Windows.Forms.Label totalSalaryLebel;
        private System.Windows.Forms.TextBox salaryTextBox;
        private System.Windows.Forms.TextBox bonusTextBox;
        private System.Windows.Forms.TextBox totalSalaryTextBox;
    }
}

