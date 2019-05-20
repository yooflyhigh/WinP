using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            label1.Text = "버튼 스타일 : " + b.FlatStyle.ToString();
        }
        /*
        private void Button1_Click(object sender, EventArgs e)
        {
            label1.Text = "버튼 스타일 : " + FlatStyle.Flat.ToString();
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            label1.Text = "버튼 스타일 : " + FlatStyle.Popup.ToString();
        }
        private void Button3_Click(object sender, EventArgs e)
        {
            label1.Text = "버튼 스타일 : " + FlatStyle.Standard.ToString();
        }
        private void Button4_Click(object sender, EventArgs e)
        {
            label1.Text = "버튼 스타일 : " + FlatStyle.System.ToString();
        }
        */
    }
}
