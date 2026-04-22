namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Hello Word";
            label1.ForeColor = Color.Red;
            label1.Font = new Font(label1.Font, FontStyle.Bold);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = string.Empty;
        }
    }
}
