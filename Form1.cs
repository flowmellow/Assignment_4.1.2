namespace Assignment_4._1._2
{
    public partial class Calculator : Form, ICalculator
    {
        double firstNumber = 0;
        string operation = "";


        public Calculator()
        {
            InitializeComponent();
        }

        public void Add()
        {
            firstNumber = Convert.ToDouble(resultTextBox.Text);
            resultTextBox.Text = "0";
            operation = "+";
        }

        public void Subtract()
        {
            firstNumber = Convert.ToDouble(resultTextBox.Text);
            resultTextBox.Text = "0";
            operation = "-";
        }

        public void Divide()
        {
            firstNumber = Convert.ToDouble(resultTextBox.Text);
            resultTextBox.Text = "0";
            operation = "/";
        }

        public void Multiply()
        {
            firstNumber = Convert.ToDouble(resultTextBox.Text);
            resultTextBox.Text = "0";
            operation = "*";
        }


        private void oneButton_Click(object sender, EventArgs e)
        {
            if (resultTextBox.Text == "0" && resultTextBox.Text != null)
            {
                resultTextBox.Text = "1";
            }
            else
            {
                resultTextBox.Text = resultTextBox.Text + "1";
            }

        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            if (resultTextBox.Text == "0" && resultTextBox.Text != null)
            {
                resultTextBox.Text = "2";
            }
            else
            {
                resultTextBox.Text = resultTextBox.Text + "2";
            }
        }

        private void threeButton_Click(object sender, EventArgs e)
        {
            if (resultTextBox.Text == "0" && resultTextBox.Text != null)
            {
                resultTextBox.Text = "3";
            }
            else
            {
                resultTextBox.Text = resultTextBox.Text + "3";
            }
        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            if (resultTextBox.Text == "0" && resultTextBox.Text != null)
            {
                resultTextBox.Text = "4";
            }
            else
            {
                resultTextBox.Text = resultTextBox.Text + "4";
            }
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            if (resultTextBox.Text == "0" && resultTextBox.Text != null)
            {
                resultTextBox.Text = "5";
            }
            else
            {
                resultTextBox.Text = resultTextBox.Text + "5";
            }
        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            if (resultTextBox.Text == "0" && resultTextBox.Text != null)
            {
                resultTextBox.Text = "6";
            }
            else
            {
                resultTextBox.Text = resultTextBox.Text + "6";
            }
        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
            if (resultTextBox.Text == "0" && resultTextBox.Text != null)
            {
                resultTextBox.Text = "7";
            }
            else
            {
                resultTextBox.Text = resultTextBox.Text + "7";
            }
        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            if (resultTextBox.Text == "0" && resultTextBox.Text != null)
            {
                resultTextBox.Text = "8";
            }
            else
            {
                resultTextBox.Text = resultTextBox.Text + "8";
            }
        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            if (resultTextBox.Text == "0" && resultTextBox.Text != null)
            {
                resultTextBox.Text = "9";
            }
            else
            {
                resultTextBox.Text = resultTextBox.Text + "9";
            }
        }

        private void zeroButton_Click(object sender, EventArgs e)
        {
            if (resultTextBox.Text == "0" && resultTextBox.Text != null)
            {
                resultTextBox.Text = "0";
            }
            else
            {
                resultTextBox.Text = resultTextBox.Text + "0";
            }
        }

        private void decimalButton_Click(object sender, EventArgs e)
        {
            if (resultTextBox.Text == "0" && resultTextBox.Text != null)
            {
                resultTextBox.Text = ".";
            }
            else
            {
                resultTextBox.Text = resultTextBox.Text + ".";
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            if (resultTextBox.Text == "0" && resultTextBox.Text != null)
            {
                resultTextBox.Text = "0";
            }
            else
            {
                resultTextBox.Text = "0";
            }
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            Subtract();
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            Multiply();
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            Divide();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":                    
                    double addNumber = Convert.ToDouble(resultTextBox.Text);
                    double addTotal = firstNumber + addNumber;
                    resultTextBox.Text = Convert.ToString(addTotal);
                    break;
                case "-":
                    double minusNumber = Convert.ToDouble(resultTextBox.Text);
                    double minusTotal = firstNumber - minusNumber;
                    resultTextBox.Text = Convert.ToString(minusTotal);
                    break;
                case "*":
                    double multiplyNumber = Convert.ToDouble(resultTextBox.Text);
                    double multiplyTotal = firstNumber * multiplyNumber;
                    resultTextBox.Text = Convert.ToString(multiplyTotal);
                    break;
                case "/":
                    double divideNumber = Convert.ToDouble(resultTextBox.Text);

                    if (divideNumber == 0)
                    {
                        resultTextBox.Text = "Zero is an invalid input";
                    }
                    else
                    {
                        double divideTotal = firstNumber / divideNumber;
                        resultTextBox.Text = Convert.ToString(divideTotal);
                    }                    
                    break;
               
            }
        }
    }
}
