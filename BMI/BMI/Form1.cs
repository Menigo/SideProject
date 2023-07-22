using System.Text;

namespace BMI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void result_btn_Click(object sender, EventArgs e)
        {
            float height = float.Parse(height_txtBox.Text) / 100;
            float weith = float.Parse(width_txtBox.Text);

            StringBuilder stringBuilder = new StringBuilder();

            float bmi = weith / (height * height);

            stringBuilder.AppendLine("您的bmi為:" + bmi.ToString("#.#"));

            if(bmi < 18.5)
                stringBuilder.AppendLine("您的體重過輕");
            if(bmi >= 18.5 && bmi < 24)
                stringBuilder.AppendLine("您的體重正常");
            if(bmi >= 24)
            {
                stringBuilder.AppendLine("您的體重過重");
                if (27 <= bmi && bmi < 30)
                    stringBuilder.AppendLine("且輕度肥胖");
                if (30 <= bmi && bmi < 35)
                    stringBuilder.AppendLine("且中度肥胖");
                if (35 <= bmi)
                    stringBuilder.AppendLine("且重度肥胖");

            }
            result_txtBox.Text = stringBuilder.ToString();

        }

        private void text_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar < 48 | (int)e.KeyChar > 57) & (int)e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}