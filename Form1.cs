namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            totalWindow.KeyPress += new KeyPressEventHandler(totalWindow_KeyPress);
        }

        List<decimal> numbers = new List<decimal>();
        List<string> operations = new List<string>();

        private void Form1_Load(object sender, EventArgs e)
        {
            totalWindow.Focus();
        }

        private void totalWindow_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                e.KeyChar != '+' && e.KeyChar != '-' &&
                e.KeyChar != '*' && e.KeyChar != '/' &&
                e.KeyChar != '.' && e.KeyChar != '\b' &&
                e.KeyChar != '\r')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains("."))
            {
                e.Handled = true;
            }

            if (e.KeyChar == '\b')
            {
                if (totalWindow.Text.Length > 0)
                {
                    totalWindow.Text = totalWindow.Text.Substring(0, totalWindow.Text.Length - 1);
                }
                e.Handled = true;
                UpdateDisplay();
            }

            // Handle arithmetic operators and Enter key
            if (char.IsDigit(e.KeyChar) || e.KeyChar == '+' || e.KeyChar == '-' ||
                            e.KeyChar == '*' || e.KeyChar == '/' || e.KeyChar == '\r')
            {
                if (e.KeyChar == '\r') // Enter key
                {
                    btnEqual_Click(sender, e);
                }
                else
                {
                    ProcessKeyPress(e.KeyChar);
                }
                e.Handled = true;
            }

            if (e.KeyChar == '.')
            {
                btnDecimal_Click(sender, e);
                e.Handled = true;
            }
        }

        private void ProcessKeyPress(char key)
        {
            if (char.IsDigit(key) || key == '.')
            {
                totalWindow.Text += key;
            }
            else
            {
                // It's an operator (+, -, *, /)
                if (decimal.TryParse(totalWindow.Text, out decimal number))
                {
                    numbers.Add(number);
                    operations.Add(key.ToString());
                    totalWindow.Clear();
                    UpdateDisplay();
                }
            }
            UpdateOngoingCalculationLabel();
        }

        private void UpdateDisplay()
        {
            try
            {
                if (numbers.Count == 0 || operations.Count == 0)
                {
                    return;  // No numbers or operations to process
                }

                decimal result = numbers[0];
                string displayText = result.ToString();

                for (int i = 0; i < operations.Count; i++)
                {
                    if (numbers.Count > i + 1)
                    {
                        if (operations[i] == "+")
                        {
                            result += numbers[i + 1];
                        }
                        else if (operations[i] == "-")
                        {
                            result -= numbers[i + 1];
                        }
                        else if (operations[i] == "*")
                        {
                            result *= numbers[i + 1];
                        }
                        else if (operations[i] == "/")
                        {
                            if (numbers[i + 1] == 0)
                            {
                                throw new DivideByZeroException();
                            }
                            result /= numbers[i + 1];
                        }

                        displayText += " " + operations[i] + " " + numbers[i + 1].ToString();
                    }
                }

                ongoingCalcLabel.Text = displayText;
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid number.");
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Cannot divide by zero.");
            }
        }


        private void btn1_Click(object sender, EventArgs e)
        {
            totalWindow.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            totalWindow.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            totalWindow.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            totalWindow.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            totalWindow.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            totalWindow.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            totalWindow.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            totalWindow.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            totalWindow.Text += "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            totalWindow.Text += "0";
        }

        private void btnEraser_Click(object sender, EventArgs e)
        {
            totalWindow.Clear();
            numbers.Clear();
            operations.Clear();
            ongoingCalcLabel.Text = "";
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            ProcessOperator("+");
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            ProcessOperator("-");
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            ProcessOperator("*");
        }

        private void btnDivided_Click(object sender, EventArgs e)
        {
            ProcessOperator("/");
        }

        private void ProcessOperator(string operatorSymbol)
        {
            if (decimal.TryParse(totalWindow.Text, out decimal number))
            {
                numbers.Add(number);
                operations.Add(operatorSymbol);
                totalWindow.Clear();
                UpdateDisplay();
            }
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(totalWindow.Text, out decimal lastNumber))
            {
                numbers.Add(lastNumber);
            }

            try
            {
                decimal result = numbers[0];
                string displayText = result.ToString();

                for (int i = 0; i < operations.Count; i++)
                {
                    if (operations[i] == "+")
                    {
                        result += numbers[i + 1];
                    }
                    else if (operations[i] == "-")
                    {
                        result -= numbers[i + 1];
                    }
                    else if (operations[i] == "*")
                    {
                        result *= numbers[i + 1];
                    }
                    else if (operations[i] == "/")
                    {
                        if (numbers[i + 1] == 0)
                        {
                            throw new DivideByZeroException();
                        }
                        result /= numbers[i + 1];
                    }

                    displayText += " " + operations[i] + " " + numbers[i + 1].ToString();
                }

                totalWindow.Text = result % 1 == 0 ? result.ToString("0") : result.ToString();

                numbers.Clear();
                operations.Clear();

                UpdateOngoingCalculationLabel();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid number.");
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Cannot divide by zero.");
            }
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            if (totalWindow.Text.Length > 0)
            {
                totalWindow.Text = totalWindow.Text.Substring(0, totalWindow.Text.Length - 1);
            }
            UpdateDisplay();
        }

        private void btn2x_Click(object sender, EventArgs e)
        {
            try
            {
                decimal num1 = decimal.Parse(totalWindow.Text);
                decimal result = num1 * num1;
                totalWindow.Text = result % 1 == 0 ? result.ToString("0") : result.ToString();
            }

            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid number.");
            }
        }

        private void btnProcent_Click(object sender, EventArgs e)
        {
            try
            {
                decimal num1 = decimal.Parse(totalWindow.Text);
                decimal result = num1 / 100;
                totalWindow.Text = result % 1 == 0 ? result.ToString("0") : result.ToString();
            }

            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid number.");
            }
        }

        private void ongoingCalcLabel_Click(object sender, EventArgs e)
        {

        }
        private void UpdateOngoingCalculationLabel()
        {
            string displayText = "";

            for (int i = 0; i < numbers.Count; i++)
            {
                displayText += numbers[i];

                if (i < operations.Count)
                {
                    displayText += " " + operations[i];
                }
            }

            ongoingCalcLabel.Text = displayText;
        }

        private void btnsquareroot_Click(object sender, EventArgs e)
        {
            try
            {
                decimal num1 = decimal.Parse(totalWindow.Text);

                double sqrtResult = Math.Sqrt((double)num1);

                decimal result = (decimal)sqrtResult;

                totalWindow.Text = result % 1 == 0 ? result.ToString("0") : result.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid number.");
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Cannot calculate the square root of a negative number.");
            }
        }

        private void clearWindow_Click(object sender, EventArgs e)
        {
            totalWindow.Clear();
        }

        private void btnInverse_Click(object sender, EventArgs e)
        {
            try
            {
                decimal num = decimal.Parse(totalWindow.Text);

                if (num == 0)
                {
                    MessageBox.Show("Cannot calculate the reciprocal of zero.");
                    return;
                }

                decimal result = 1 / num;

                totalWindow.Text = result % 1 == 0 ? result.ToString("0") : result.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid number.");
            }
        }

        private void btnPlusMinus_Click(object sender, EventArgs e)
        {
            try
            {
                decimal num = decimal.Parse(totalWindow.Text);

                // Multiply by -1 to swap positive/negative
                num = num * -1;

                totalWindow.Text = num.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid number.");
            }
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            if (!totalWindow.Text.Contains("."))
            {
                totalWindow.Text += ".";
            }
        }
    }
}
