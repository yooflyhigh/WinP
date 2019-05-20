using System;
using System.Windows.Forms;

namespace wf05
{
    public class User
    {
        string name, place, sex, hob;
        public string Name
        {
            set{name = value;}
            get{return name;}
        }
        public string Place
        {
            set { place = value; }
            get { return place; }
        }
        public string Sex
        {
            set { sex = value; }
            get { return sex; }
        }
        public string Hob
        {
            set { hob = value; }
            get { return hob; }
        }
        public User()
        {
            name = place = sex = hob = string.Empty;
        }
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        { 
            User us = new User();

            string item = string.Empty;
            us.Name = textBox1.Text;
            us.Place = comboBox1.SelectedItem.ToString();

            foreach (RadioButton cb in groupBox1.Controls)
            {
                if (cb.Checked)
                    us.Sex = cb.Text + " ";
            }
            foreach (CheckBox cb in groupBox2.Controls)
            {
                if (cb.Checked)
                    us.Hob += cb.Text + " ";
            }
            item += us.Name + " " + us.Place + " " + us.Sex + " " + us.Hob + " ";
            listBox1.Items.Add(item);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int idx = listBox1.FindString(textBox1.Text);
            if (idx != -1)
            {
                listBox1.SetSelected(idx, true);
            }
            else
            {
                MessageBox.Show(textBox1.Text + "님은 미등록.", "등록확인");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string name = listBox1.SelectedItem.ToString().Substring(0, 1);
            MessageBox.Show(name + "..님을 삭제합니다.", "삭제확인");
            listBox1.Items.Remove(listBox1.SelectedItem);
        }
    }
}
