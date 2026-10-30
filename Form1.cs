using System.Globalization;

namespace Calculator
{
    public partial class Form1 : Form
    {

        private double savedNumber;
        private string operation = "";
        private bool newNumber = false;
        private bool unaryResult = false;
        private int numberBase = 10;

        public Form1()
        {
            InitializeComponent();

            Button[] digits =
            {
        btn0, btn1, btn2, btn3, btn4,
        btn5, btn6, btn7, btn8, btn9
    };

            foreach (Button button in digits)
            {
                button.Click += Digit_Click;
            }

            btnClear.Click += Clear_Click;
            btnDot.Click += Dot_Click;
            btnSing.Click += Sign_Click;
            btnAdd.Click += Operation_Click;
            btnSubtract.Click += Operation_Click;
            btnMultiply.Click += Operation_Click;
            btnDivide.Click += Operation_Click;
            btnEquals.Click += Operation_Click;
            btnPower.Click += Operation_Click;
            btnSqrt.Click += Scientific_Click;
            btnSquare.Click += Scientific_Click;
            btnSin.Click += Scientific_Click;
            btnCos.Click += Scientific_Click;

            foreach (Control control in Controls)
            {
                if (control is Button button && button.Text == "<-")
                    button.Click += Backspace_Click;
            }

            cmbBase.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBase.Items.Clear();
            cmbBase.Items.AddRange(new object[] { "2", "10", "16" });
            cmbBase.SelectedIndex = 1;
            cmbBase.SelectedIndexChanged += BaseChanged;

            foreach (Control control in Controls)
            {
                if (control is Button button &&
                    button.Text.Length == 1 &&
                    "ABCDEF".Contains(button.Text))
                {
                    button.Click += Digit_Click;
                }
            }

            UpdateBaseButtons();

        }

        private void Digit_Click(object? sender, EventArgs e)
        {
            PrepareInput();
            if (sender is not Button button)
                return;

            if (txtDisplay.Text == "0")
                txtDisplay.Text = button.Text;
            else
                txtDisplay.Text += button.Text;
        }

        private void Clear_Click(object? sender, EventArgs e)
        {
            unaryResult = false;
            txtDisplay.Text = "0";
            savedNumber = 0;
            operation = "";
            newNumber = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cmbBase_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Dot_Click(object? sender, EventArgs e) 
        {
            PrepareInput();
            if (!txtDisplay.Text.Contains("."))
                txtDisplay.Text += ".";
        }

        private void Sign_Click(object? sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
                return;

            if (txtDisplay.Text.StartsWith("-"))
                txtDisplay.Text = txtDisplay.Text.Substring(1);
            else
                txtDisplay.Text = "-" + txtDisplay.Text;
            unaryResult = true;
        }

        private void PrepareInput()
        {
            unaryResult = false;
            if (newNumber)
            {
                txtDisplay.Text = "0";
                newNumber = false;
            }
        }

        private void Operation_Click(object? sender, EventArgs e)
        {
            if (sender is not Button button)
                return;

            if (!TryReadNumber(out double number))
            {
                MessageBox.Show("Некорректное или слишком большое число.");
                return;
            }

            if (operation != "" && (!newNumber || unaryResult))
            {
                if (operation == "/" && number == 0)
                {
                    MessageBox.Show("На ноль делить нельзя.");
                    return;
                }

                number = operation switch
                {
                    "+" => savedNumber + number,
                    "-" => savedNumber - number,
                    "*" => savedNumber * number,
                    "/" => savedNumber / number,
                    "x^y" => Math.Pow(savedNumber, number),
                    _ => number
                };

                if (!double.IsFinite(number))
                {
                    MessageBox.Show("Слишком большой результат.");
                    return;
                }

                if (!ShowNumber(number))
                    return;
            }


            savedNumber = number;
            operation = button.Text == "=" ? "" : button.Text;
            newNumber = true;
            unaryResult = false;
        }

        private void Backspace_Click(object? sender, EventArgs e)
        {
            if (newNumber)
                return;

            string text = txtDisplay.Text;

            txtDisplay.Text = text.Length > 1
                ? text.Substring(0, text.Length - 1)
                : "0";

            if (txtDisplay.Text == "-")
                txtDisplay.Text = "0";
        }

        private void Scientific_Click(object? sender, EventArgs e)
        {
            if (sender is not Button button)
                return;

            if (!TryReadNumber(out double number))
            {
                MessageBox.Show("Некорректное число.");
                return;
            }

            double result = button.Text switch
            {
                "sqrt" => Math.Sqrt(number),
                "x^2" => number * number,
                "sin" => Math.Sin(number * (Math.PI / 180)),
                "cos" => Math.Cos(number * (Math.PI / 180)),
                _ => number
            };

            if (!double.IsFinite(result))
            {
                MessageBox.Show("Результат не определён или слишком большой.");
                return;
            }

            if (!ShowNumber(result))
                return;

            newNumber = true;
            unaryResult = true;
        }

        private bool TryReadNumber(out double number)
        {
            if (numberBase == 10)
            {
                return double.TryParse(txtDisplay.Text, NumberStyles.Float,
                    CultureInfo.InvariantCulture, out number)
                    && double.IsFinite(number);
            }

            number = 0;
            string text = txtDisplay.Text;
            bool negative = text.StartsWith("-");

            if (negative)
                text = text.Substring(1);

            if (text.Length == 0)
                return false;

            foreach (char symbol in text)
            {
                int digit = "0123456789ABCDEF".IndexOf(symbol);

                if (digit < 0 || digit >= numberBase)
                    return false;

                number = number * numberBase + digit;

                if (number > 9007199254740991d)
                    return false;
            }

            if (negative)
                number = -number;

            return true;
        }

        private bool ShowNumber(double number)
        {
            if (numberBase == 10)
            {
                txtDisplay.Text = number.ToString(
                    "G15", CultureInfo.InvariantCulture);
                return true;
            }

            if (number != Math.Truncate(number))
            {
                MessageBox.Show("Для дробного результата выбери систему 10.");
                return false;
            }

            if (Math.Abs(number) > 9007199254740991d)
            {
                MessageBox.Show("Число слишком большое для перевода.");
                return false;
            }

            long integer = (long)Math.Abs(number);
            string text = Convert.ToString(integer, numberBase).ToUpperInvariant();

            txtDisplay.Text = number < 0 ? "-" + text : text;
            return true;
        }

        private void BaseChanged(object? sender, EventArgs e)
        {
            if (!int.TryParse(cmbBase.SelectedItem?.ToString(),
                out int nextBase) || nextBase == numberBase)
                return;

            if (!TryReadNumber(out double number))
            {
                MessageBox.Show("Не удалось прочитать число. Нажми AC.");
                cmbBase.SelectedItem = numberBase.ToString();
                return;
            }

            int previousBase = numberBase;
            numberBase = nextBase;

            if (!ShowNumber(number))
            {
                numberBase = previousBase;
                cmbBase.SelectedItem = previousBase.ToString();
                return;
            }

            UpdateBaseButtons();
        }

        private void UpdateBaseButtons()
        {
            foreach (Control control in Controls)
            {
                if (control is not Button button)
                    continue;

                if (button.Text.Length == 1)
                {
                    int digit = "0123456789ABCDEF".IndexOf(button.Text[0]);

                    if (digit >= 0)
                        button.Enabled = digit < numberBase;
                }
            }

            btnDot.Enabled = numberBase == 10;
        }

    }

}