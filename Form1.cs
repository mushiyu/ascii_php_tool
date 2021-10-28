using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ascii_php_tool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str2 = textBox1.Text;
            byte[] array = System.Text.Encoding.ASCII.GetBytes(str2);  //数组array为对应的ASCII数组    
            string ASCIIstr2 = null;
            string ASCIIstr3 = null;
            for (int i = 0; i < array.Length; i++)
            {
                int asciicode = (int)(array[i]);
                if (i < array.Length - 1)
                {
                    ASCIIstr2 = ASCIIstr2 + Convert.ToString(asciicode) + ',';//字符串ASCIIstr2 为对应的ASCII字符串
                    ASCIIstr3 += "chr(" + Convert.ToString(asciicode) + ")" + '.';
                }
                else
                {
                    ASCIIstr2 = ASCIIstr2 + Convert.ToString(asciicode);
                    ASCIIstr3 += "chr(" + Convert.ToString(asciicode) + ")";
                }
            }
            textBox2.Text = ASCIIstr2;
            textBox3.Text = ASCIIstr3;

        }
    }
}
