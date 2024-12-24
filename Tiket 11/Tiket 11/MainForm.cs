namespace Tiket_11
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void CountButton_Click(object sender, EventArgs e)
        {
            string str = StringTextBox.Text;
            const string vowels = "AaEeIiOoYyUu";
            const string consonants = "QqWwRrTtPpSsDdFfGgHhJjKkLlZzXxCcVvBbNnMm";
            const string marks = ",.?!;:";
            const string space = " ";
            const string numbers = "1234567890";
            int vowelsCount = 0;
            for (int i = 0; i < str.Length; i++)
            {
                for (int j = 0; j < vowels.Length; j++)
                {
                    if (str[i] == vowels[j]) vowelsCount++;
                }
            }
            VowelsLabel.Text =$"Гласных {vowelsCount.ToString()}";

            int consonantsCount = 0;
            for (int i = 0; i < str.Length; i++)
            {
                for (int j = 0; j < consonants.Length; j++)
                {
                    if (str[i] == consonants[j]) consonantsCount++;
                }
            }
            ConsonantsLabel.Text = $"Согласных {consonantsCount.ToString()}";

            int numbersCount = 0;
            for (int i = 0; i < str.Length; i++)
            {
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (str[i] == numbers[j]) numbersCount++;
                }
            }
            NumbersLabel.Text = $"Цифр {numbersCount.ToString()}";

            int marksCount = 0;
            for (int i = 0; i < str.Length; i++)
            {
                for (int j = 0; j < marks.Length; j++)
                {
                    if (str[i] == marks[j]) marksCount++;
                }
            }
            MarksLabel.Text = $"Знаков препинания {marksCount.ToString()}";

            int spaceCount = 0;
            for (int i = 0; i < str.Length; i++)
            {
                for (int j = 0; j < space.Length; j++)
                {
                    if (str[i] == space[j]) spaceCount++;
                }
            }
            SpaceLabel.Text = $"Пробелов {spaceCount.ToString()}";
        }
    }
}
