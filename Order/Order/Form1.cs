namespace Order
{
    public partial class Form1 : Form
    {
        string[] listStr = {"�|�׶� 25��","���׶� 50��", "�J���� 40��", "�^�Y�� 30��", "������ 20��", "�S�C�� 30��", "���j�z 80��" };
        Point orginCheckBox = new Point(40, 50);
        int nextY = 0;
        int nextX = 0;
        Dictionary<CheckBox, TextBox> list = new Dictionary<CheckBox, TextBox>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            foreach (var item in listStr)
            {
                CheckBox checkBox = new CheckBox();
                checkBox.Text = item;
                checkBox.Location = new Point(orginCheckBox.X+ nextX, orginCheckBox.Y + nextY);
                checkBox.AutoSize = true;
                checkBox.CheckedChanged += CheckMenu;
                this.Controls.Add(checkBox);
                nextY += 30;

                TextBox textBox = new TextBox();
                textBox.Text = "0";
                textBox.Location = new Point(orginCheckBox.X+ nextX, orginCheckBox.Y + nextY);
                textBox.Size = new Size(checkBox.Width,textBox.Height);
                this.Controls.Add(textBox);
                nextY += 30;
                if (nextY >= 300)
                {
                    nextY = 0;
                    nextX += 200;
                }

                list.Add(checkBox, textBox);

            }

            Button button = new Button();
            button.AutoSize = true;
            button.Text = "����";
            button.Location = new Point(40, 380);
            this.Controls.Add(button);
            this.AutoSize = true;
        }


        private void CheckMenu(object sender, EventArgs e)
        {
            list.ContainsKey((CheckBox)sender);
        }
    }
}