using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace المحاضرة_الخامسة
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
            int s = 0;
            bool f = false;
            if (checkBox1.Checked)
            {
                s = s + Convert.ToInt16(checkBox1.Text);
                f = true;
            }
            if (checkBox2.Checked)
            {
                s = s + Convert.ToInt16(checkBox1.Text);
                f = true;
            }
            if (checkBox3.Checked)
            {
                s = s + Convert.ToInt16(checkBox1.Text);
                f = true;
            }
            if (checkBox4.Checked)
            {
                s = s + Convert.ToInt16(checkBox1.Text);
                f = true;
            }
            if (f)
                textBox1.Text = s.ToString();

        }

       /* private void button2_Click(object sender, EventArgs e)
        {
            //if (radioButton5.Checked)
            //    label2.ForeColor = Color.Red;
            //if (radioButton6.Checked)
            //    label2.ForeColor = Color.White;
            //if (radioButton7.Checked)
            //    label2.ForeColor = Color.Black;
            //if (radioButton8.Checked)
            //    label2.ForeColor = Color.Yellow;

               

        }
    */

        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                label2.BackColor = Color.Red;
            else if(radioButton2.Checked)
                label2.BackColor = Color.White;
            else if(radioButton3.Checked)
                label2.BackColor = Color.Black;
            else if(radioButton4.Checked)
                label2.BackColor = Color.Yellow;
            //for change fount lin text
            if (radioButton5.Checked)
                label2.ForeColor = Color.Red;
            if (radioButton6.Checked)
                label2.ForeColor = Color.White;
            if (radioButton7.Checked)
                label2.ForeColor = Color.Black;
            if (radioButton8.Checked)
                label2.ForeColor = Color.Yellow;


        }

        private void button4_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = groupBox2.Enabled = panel1.Enabled =true;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled=groupBox2.Enabled=panel1.Enabled = false;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = groupBox2.Visible = panel1.Visible = true;
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = groupBox2.Visible = panel1.Visible = false;
            

        }
    }
}
