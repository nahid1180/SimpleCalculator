using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Simple_CalculatorApp
{
    public partial class simpleCalculatorUI : Form
    {
        public simpleCalculatorUI()
        {
            InitializeComponent();
        }
        double firstNumber;
        double secondNumber;
        double addResult;
        double subtractResult;
        double multiplyResult;
        double divideResult;
        
        private void addButton_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
            secondNumber = Convert.ToDouble(secondNumberTextBox.Text);
            addResult = Convert.ToDouble(firstNumber + secondNumber);
            resultTextBox.Text = Convert.ToString(addResult);            
        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
            secondNumber = Convert.ToDouble(secondNumberTextBox.Text);
            subtractResult = Convert.ToDouble(firstNumber - secondNumber);
            resultTextBox.Text = Convert.ToString(subtractResult);            
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
            secondNumber = Convert.ToDouble(secondNumberTextBox.Text);
            multiplyResult = Convert.ToDouble(firstNumber * secondNumber);
            resultTextBox.Text = Convert.ToString(multiplyResult);            
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
            secondNumber = Convert.ToDouble(secondNumberTextBox.Text);
            divideResult = Convert.ToDouble(firstNumber / secondNumber);
            resultTextBox.Text = Convert.ToString(divideResult);            
        }

        

    }
}
