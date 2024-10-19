namespace CRICKETNEW
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Login L1 = new Login();
            L1.ShowDialog();
            this.Hide();
        }
    }
}