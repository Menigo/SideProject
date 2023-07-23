namespace Order
{
    public partial class Form1 : Form
    {
        CheckBox checkBox = new CheckBox();
        Point orginCheckBox = new Point(40, 50);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkBox.Location = new Point(40, 50);
            checkBox.Text = "ด๚ธี";
            this.Controls.Add(checkBox);
        }
    }
}