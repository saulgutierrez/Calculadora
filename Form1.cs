namespace Calculadora
{
    public partial class Form1 : Form
    {
        bool isClickedAddButton = false;
        bool isClickedSubstractButton = false;
        bool isClickedMultiplyButton = false;
        bool isClickedDivideButton = false;
        bool isClickedEqualsButton = false;
        string firstEntry = String.Empty;
        string secondEntry = String.Empty;
        string showResult = String.Empty;
        float firstValue = 0.0f;
        float secondValue = 0.0f;
        float result = 0.0f;

        public Form1()
        {
            InitializeComponent();
        }

        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.BackColor = Color.Red;
        }

        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.BackColor = Color.FromArgb(32, 28, 28);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void oneButton_Click(object sender, EventArgs e)
        {
            virtualDisplay.Text += "1";
        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            virtualDisplay.Text += "2";
        }

        private void threeButton_Click(object sender, EventArgs e)
        {
            virtualDisplay.Text += "3";
        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            virtualDisplay.Text += "4";
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            virtualDisplay.Text += "5";
        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            virtualDisplay.Text += "6";
        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
            virtualDisplay.Text += "7";
        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            virtualDisplay.Text += "8";
        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            virtualDisplay.Text += "9";
        }

        private void zeroButton_Click(object sender, EventArgs e)
        {
            virtualDisplay.Text += "0";
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            virtualDisplay.Text = String.Empty;
        }

        private void backspaceButton_Click(object sender, EventArgs e)
        {
            string vd = virtualDisplay.Text;
            string vdbs = vd.Substring(0, vd.Length - 1);
            virtualDisplay.Text = vdbs;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            isClickedAddButton = true;
            firstEntry = virtualDisplay.Text;
            virtualDisplay.Text = String.Empty;
        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            isClickedSubstractButton = true;
            firstEntry = virtualDisplay.Text;
            virtualDisplay.Text = String.Empty;
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            isClickedMultiplyButton = true;
            firstEntry = virtualDisplay.Text;
            virtualDisplay.Text = String.Empty;
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            isClickedDivideButton = true;
            firstEntry = virtualDisplay.Text;
            virtualDisplay.Text = String.Empty;
        }

        private void equalsButton_Click(object sender, EventArgs e)
        {
            if (isClickedAddButton == true)
            {
                secondEntry = virtualDisplay.Text;
                firstValue = float.Parse(firstEntry);
                secondValue = float.Parse(secondEntry);
                result = firstValue + secondValue;
                showResult = result.ToString();
                virtualDisplay.Text = showResult;
                isClickedAddButton = false;
            }

            if (isClickedSubstractButton == true)
            {
                secondEntry = virtualDisplay.Text;
                firstValue = float.Parse(firstEntry);
                secondValue = float.Parse(secondEntry);
                result = firstValue - secondValue;
                showResult = result.ToString();
                virtualDisplay.Text = showResult;
                isClickedSubstractButton = false;
            }

            if (isClickedMultiplyButton == true)
            {
                secondEntry = virtualDisplay.Text;
                firstValue = float.Parse(firstEntry);
                secondValue = float.Parse(secondEntry);
                result = firstValue * secondValue;
                showResult = result.ToString();
                virtualDisplay.Text = showResult;
                isClickedMultiplyButton = false;
            }

            if (isClickedDivideButton == true)
            {
                secondEntry = virtualDisplay.Text;
                firstValue = float.Parse(firstEntry);
                secondValue = float.Parse(secondEntry);
                result = firstValue / secondValue;
                showResult = result.ToString();
                virtualDisplay.Text = showResult;
                isClickedDivideButton = false;
            }
        }
    }
}