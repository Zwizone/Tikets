namespace Tiket12
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void CountButton_Click(object sender, EventArgs e)
        {
            string str = MainTextBox.Text;
            char[] operators = { '-', '+', '*', ':' };
            var data = str.Split(operators, StringSplitOptions.None);
            double a = double.Parse(data[0]);
            double b = double.Parse(data[1]);
            if (str.Contains("+"))
                ResultLabel.Text = (a + b).ToString();
            else if (str.Contains("-"))
                ResultLabel.Text = (a - b).ToString();
            else if (str.Contains("*"))
                ResultLabel.Text = (a*b).ToString();
            else
                ResultLabel.Text = (a / b).ToString();
        }
    }
}
