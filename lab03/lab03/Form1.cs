using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab03
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Trim() == "")
            {
                label3.Text = "결과 : 아이디를 입력하세요";
            }
            if (CheckData())
            {
                label3.Text = "결과 : 로그인 성공";
            }
        }

        private bool CheckData()
        {
            User user = new User();
            return user.Id.Equals(textBox1.Text) && user.Pw.Equals(textBox2.Text);
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
    class User
    {
        string id;
        string pw;
        public User()
        {
            id = "hallym";
            pw = "12345";
        }
        public string Id { get { return id; } set { id = value; } }
        public string Pw { get { return pw; } set { pw = value; } }

    }
}
