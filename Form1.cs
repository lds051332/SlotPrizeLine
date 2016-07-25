using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrizeType
{
    public partial class Form1 : Form
    {
        List<CheckBox> cbList = new List<CheckBox>();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cbList.Add(cb0);
            cbList.Add(cb1);
            cbList.Add(cb2);
            cbList.Add(cb3);
            cbList.Add(cb4);
            cbList.Add(cb5);
            cbList.Add(cb6);
            cbList.Add(cb7);
            cbList.Add(cb8);
            cbList.Add(cb9);
            cbList.Add(cb10);
            cbList.Add(cb11);
            cbList.Add(cb12);
            cbList.Add(cb13);
            cbList.Add(cb14);
            //cbList.Add(cb15);
            //cbList.Add(cb16);
            //cbList.Add(cb17);
            //cbList.Add(cb18);
            //cbList.Add(cb19);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string result = "";
            foreach (CheckBox item in cbList)
            {
                if (item.Checked)
                {
                    result += item.Text + ",";
                }
            }
            result = result.TrimEnd(',');
            richTextBox1.Text += (result + "\n");
            foreach (CheckBox item in cbList)
            {
                item.Checked = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }
        //test
    }
}
