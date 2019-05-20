using System;
using System.Windows.Forms;

namespace wf03
{
    public partial class Form1 : Form
    {
        Calculator cal;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cal = new Calculator();  //Calculator 클래스 객체 생성, 연산 메소드 호출
        }
        private void Button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);

            if (textBox1.Text.Trim() == "" || textBox2.Text.Trim() == "")
            {
                MessageBox.Show("피연산자를 입력해 주세요");
                textClear();
            }
            else if (btn.Text.ToString().Equals("+"))
            {
                textBox3.Text = cal.plus(a, b).ToString();
            }
            else if (btn.Text.ToString().Equals("-"))
            {
                textBox3.Text = cal.minus(a, b).ToString();
            }
            else if (btn.Text.ToString().Equals("*"))
            {
                textBox3.Text = cal.multiply(a, b).ToString();
            }
            else
            {
                textBox3.Text = cal.divide(a, b).ToString();
            }
        }
        private void textClear()
        {
            textBox1.Clear();
            textBox2.Clear();
        }
}
class Calculator
    {
        public double plus(double a, double b)
        {
            return a + b;
        } //계산 결과 반환
        public double minus(double a, double b)
        {
            return a - b;
        }
        public double multiply(double a, double b)
        {
            return a * b;
        }
        public double divide(double a, double b)
        {
            return a / b;
        }
    }
}
