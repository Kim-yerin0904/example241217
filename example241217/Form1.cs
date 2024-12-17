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
            string example = "동해 물과 백두산이";
            result[0] = example.IndexOf("백두산").ToString();
            example = "토요일에 먹는 토마토";
            result[1] = example.LastIndexOf("토").ToString();
            example = "질서 있는 퇴장";
            result[2] = example.Contains("퇴").ToString();
            example = "그 사람의 그림자는 그랬다.";
            result[3] = example.Replace("그","이");
            example = "삼성 갤럭시";
            result[4] = example.Insert(2, "애플");
            example = "오늘은 왠지 더 배고프다";
            result[5] = example.Remove(7,1);
            example = "이름,나이,전화번호";
            string[] words = example.Split(',');
            for (int i=0; i<words.Length; i++)
            {
                result[i+6] = words[i];
            }
            example = "우리 나라 만세";
            result[9] = example.Substring(3,2);

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
