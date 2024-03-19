//Készítsen grafikus alkalmazást a következő feladatok megoldására, amelynek projektjét sudokuGUI néven mentse el!
namespace sudokuGUI
{
    public partial class sudokuGUI : Form
    {
        public sudokuGUI()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            int num = int.Parse(sizeTextBox.Text);
            if (num > 4)
            {
                num--;
            }
            sizeTextBox.Text = num.ToString();
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            int num = int.Parse(sizeTextBox.Text);
            if (num < 9)
            {
                num++;
            }
            sizeTextBox.Text = num.ToString();
        }

        private void stateTextBox_TextChanged_1(object sender, EventArgs e)
        {
            sizeLabel.Text = "Hossz: " + stateTextBox.Text.Length;
        }

        private void resultButton_Click(object sender, EventArgs e)
        {
            int size = int.Parse(sizeTextBox.Text);
            int length = stateTextBox.Text.Length;
            if (length < size)
            {
                MessageBox.Show($"A feladvány rövid: kell még {size - length} számjegy!");
            }
            else if (size < length)
            {
                MessageBox.Show($"A feladvány hosszú: kell még {length - size} számjegy!");
            }
            else
            {
                MessageBox.Show($"A feladvány megfelelő hosszúságú!");
            }
        }
    }
}
