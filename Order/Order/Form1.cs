using System.Text;

namespace Order
{
    public partial class Form1 : Form
    {
        string[] listStr = {"�|�׶� 25 ��","���׶� 50 ��", "�J���� 40 ��", "�^�Y�� 30 ��", "������ 20 ��", "�S�C�� 30 ��", "���j�z 80 ��" };
        Point orginCheckBox = new Point(40, 50);
        int nextY = 0;
        int nextX = 0;
        Dictionary<CheckBox, TextBox> list = new Dictionary<CheckBox, TextBox>();
        Label label = new Label();
        Button button = new Button();

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
                textBox.Enabled = false;
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

            
            button.AutoSize = true;
            button.Text = "����";
            button.Location = new Point(40, 380);
            button.Click += CheckOut;
            this.Controls.Add(button);
            this.AutoSize = true;

        }


        private void CheckMenu(object sender, EventArgs e)
        {
            CheckBox currentCheckBox = (CheckBox)sender;
            if (list.ContainsKey(currentCheckBox)){
                TextBox currentTextBox = list[(CheckBox)sender];

                if (currentCheckBox.Checked)
                {
                    currentTextBox.Enabled = true;
                    currentTextBox.Text = "1";
                }
                else
                {
                    currentTextBox.Enabled = false;
                    currentTextBox.Text = "0";
                }
                
            }

        }

        private void CheckOut(object sender, EventArgs e)
        {
            int sum = 0;
            StringBuilder stringBuilder = new StringBuilder();
            foreach (CheckBox checkBox in list.Keys)
            {
                if (checkBox.Checked)
                {
                    int count = Convert.ToInt32(list[checkBox].Text);
                    int money = Convert.ToInt32(checkBox.Text.Split(' ')[1]);
                    sum += count*money;
                    stringBuilder.AppendLine(checkBox.Text.Split(' ')[0] + "x" + count);
                }
            }

            stringBuilder.AppendLine("�`�@ : "+ sum.ToString()+"��");

            Form2 form2 = new Form2(stringBuilder.ToString());
            form2.ShowDialog();
            //label.Text = "�`�M:"+sum.ToString();
            foreach (CheckBox checkBox in list.Keys)
            {
                checkBox.Checked = false;
            }
        }
    }
}