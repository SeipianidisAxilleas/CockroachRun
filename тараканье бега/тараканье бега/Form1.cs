using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace тараканье_бега
{
    public partial class Form1 : Form
    {
        string name1 , name2 ;
        int flag1;
        int x1 , x2 ;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Имя не введено!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            flag1 = 1;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            name1 = textBox1.Text;
            name2 = textBox2.Text;
            if(flag1 != 0)
            {
                Random rnd = new Random();
                int count = rnd.Next(6);
                x1 += count;
                label1.Text = x1.ToString();
                pictureBox1.Left = x1;

                count = rnd.Next(6);
                x2 += count;
                label2.Text = x2.ToString();
                pictureBox2.Left = x2;
            }
            if((x1 >= 688) || (x2 >= 688))
            {
                flag1= 0;
                if(x1 >= 688)
                {
                    label3.Text = $"Игрок {name1} победил!";
                }
                else if (x2 >= 688)
                {
                    label3.Text = $"Игрок {name2} победил!";
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "O";
            label2.Text = "O";
            label3.Text = "";
            pictureBox1.Left = 1;
            pictureBox2.Left = 2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "O";
            label2.Text = "O";
            label3.Text = "";
            pictureBox1.Left = 1;
            pictureBox2.Left = 2;
            flag1 = 0;
        }
    }
}
