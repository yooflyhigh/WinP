using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            public void stat(Object a)
                People p = a();
                
                p.eat();
        }
    }

    public class Peple
    {
        public void eat()
        {
            MessageBox.Show("people eat");
        }
        public void see()
        {

        }
    }
    public class gyunmo : Peple
    {
        public void eat()
        {
            MessageBox.Show("gyunmo eat");

        }
    }
    public class jaehyeok : Peple
    {
        public void eat()
        {
            MessageBox.Show("jaehyeok eat");
        }
    }


 



}
