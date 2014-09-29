using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BonusCalculatorApp
{
    public partial class bonusCalculatorUI : Form
    {
        public bonusCalculatorUI()
        {
            InitializeComponent();
        }
        double salary;
        double totalSalary;       
        private void showButton_Click(object sender, EventArgs e)
        {
            
            
            salary=Convert.ToDouble(salaryTextBox.Text);            
            if (salary > 10000) 
            {
                totalSalary = Convert.ToDouble(salary * 0.05);
                bonusTextBox.Text = Convert.ToString(totalSalary);               
                totalSalaryTextBox.Text=Convert.ToString(totalSalary + salary);               
            }
            else if (salary >= 8000 && salary <= 10000)
            {
                totalSalary = Convert.ToDouble(salary * 0.06);
                bonusTextBox.Text = Convert.ToString(totalSalary);
                totalSalaryTextBox.Text = Convert.ToString(totalSalary + salary);               
            }
            else
            {                
                totalSalary = Convert.ToDouble(salary * 0.07);
                bonusTextBox.Text = Convert.ToString(totalSalary);
                totalSalaryTextBox.Text = Convert.ToString(totalSalary + salary);                
            }
            
        }
    }
}
