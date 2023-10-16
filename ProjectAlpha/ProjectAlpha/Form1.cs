using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectAlpha
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private string calculate(
            double firstNumber,
            string arithmeticOperator,
            double secondNumber
        ) {
            string resultStatement = "";
            double result = 0.0;

            switch (arithmeticOperator)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    break;
                case "*":
                    result = firstNumber * secondNumber;
                    break;
                case "/":
                    result = firstNumber / secondNumber;
                    break;
            }

            resultStatement = firstNumber + " " + arithmeticOperator + " " + secondNumber + " = " + result;

            return resultStatement;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string messageBoxTitle = "Calculator Result";
            string messageBoxBody = "";

            try {
                double firstNumber = Convert.ToDouble(firstNumberTextbox.Text);
                string arithmeticOperator = operatorComboBox.Text;
                double secondNumber = Convert.ToDouble(secondNumberTextBox.Text);

                string calculationResult = calculate(firstNumber, arithmeticOperator, secondNumber);
                
                messageBoxBody = calculationResult;
            } catch {
                messageBoxBody = "Invalid operation!";
            }

            MessageBox.Show(messageBoxBody, messageBoxTitle);
        }
    }
}
