using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace example241217
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string[] result = new string[10];
            result[0] = "동해 물과 백두산이".IndexOf("백두산").ToString();
            result[1] = "토요일에 먹는 토마토".LastIndexOf("토").ToString();
            result[2] = "질서 있는 퇴장".Contains("퇴").ToString();
            result[3] = "그 사람의 그림자는 그랬다.".Replace("그","이");
            result[4] = "삼성 갤럭시".Insert(2, "애플");
            result[5] = "오늘은 왠지 더 배고프다".Remove(7,1);
            string[] words = "이름,나이,전화번호".Split(',');
            for (int i=0; i<words.Length; i++)
            {
                result[i+6] = words[i];
            }
            result[9] = "우리 나라 만세".Substring(3,2);

            foreach(string a in result)
            {
                textBox1.Text += a+"\r\n";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
