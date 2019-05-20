using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Student st = new Student();
            string item = string.Empty;
            st.Name = textBox1.Text;
            st.Year = int.Parse(comboBox1.SelectedItem.ToString());

            foreach (RadioButton gr in groupBox1.Controls)
            {
                if (gr.Checked)
                    st.Grade = char.Parse(gr.Text);
            }
            foreach (CheckBox sb in groupBox2.Controls)
            {
                if (sb.Checked)
                    st.Subject += sb.Text + " ";
            }
            item = $"이름 : {st.Name}, 입학년도 : {st.Year.ToString()}, 평점 : {st.Grade.ToString()}, 이수과목 : {st.Subject}";
//            item += st.Name + " " + st.Year.ToString() + " " + st.Grade.ToString() + " " + st.Subject + " ";
            listBox1.Items.Add(item);
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            string name = listBox1.SelectedItem.ToString().Substring(0,1);
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
    public class Student
    {
        string name;
        int year;
        char grade;
        string subject;
        public Student()
        {
            name = string.Empty;
            year = 0;
            grade = '0';
            subject = string.Empty;
        }

        public string Name { get => name; set => name = value; }
        public int Year { get => year; set => year = value; }
        public char Grade { get => grade; set => grade = value; }
        public string Subject { get => subject; set => subject = value; }
    }
}
