using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf02
{
    public partial class Form1 : Form
    {
        private string strTemp;
        public Form1()
        {
            InitializeComponent();
        }

        private void UpdateLabel(string s, bool b)
        {
            if (b)
            {
                label1.Text += s;  // label1의 Text 프로퍼티에 문자열 추가
            }
            else
            {
                string strTemp = label1.Text;
                int i = strTemp.IndexOf(s);
                //체크가 해제된 컨트롤 을 문자열 출력에서 제거 
                label1.Text = strTemp.Remove(i, s.Length);
            }
        }

        private void checkbox1_CheckedChanged(object sender, EventArgs e)
        {
            UpdateLabel(checkBox1.Text, checkBox1.Checked);
        }
        private void checkbox2_CheckedChanged(object sender, EventArgs e)
        {
            UpdateLabel(checkBox2.Text, checkBox2.Checked);
        }
        private void checkbox3_CheckedChanged(object sender, EventArgs e)
        {
            UpdateLabel(checkBox3.Text, checkBox3.Checked);
        }
        private void checkbox4_CheckedChanged(object sender, EventArgs e)
        {
            UpdateLabel(checkBox4.Text, checkBox4.Checked);
        }

    }
}
