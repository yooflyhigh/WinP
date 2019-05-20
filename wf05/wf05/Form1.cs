using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        { //등록 버튼
            string item = string.Empty;
            string place = string.Empty; //거주지처리
                                         //콤보 박스에서 선택된 항목을 문자열로 반환
            place = comboBox1.SelectedItem.ToString();
            string sex = string.Empty; //성별처리

            foreach (RadioButton cb in groupBox1.Controls)
            {
                //그룹박스내의 라디오버튼 처리
                if (cb.Checked)
                    sex = cb.Text + " ";
            }
            string hob = string.Empty; //취미처리
                                       //그룹박스내의 체크 상자에서 선택된 항목처리
            foreach (CheckBox cb in groupBox2.Controls)
            {
                if (cb.Checked)
                    hob += cb.Text + " ";
            }
            item += textBox1.Text + " " + place + " " + sex + " " + hob + " ";
            listBox1.Items.Add(item); //리스트 상자에 이름, 거주지, 성별, 취미를 추가
        }

        private void button2_Click(object sender, EventArgs e)
        { //조회 버튼
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
        { //삭제 버튼
            string name = listBox1.SelectedItem.ToString().Substring(0, 1);
            MessageBox.Show(name + "..님을 삭제합니다.", "삭제확인");
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

    }
}
