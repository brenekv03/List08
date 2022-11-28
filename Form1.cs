using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace List08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<char> list = new List<char>();
        private void button1_Click(object sender, EventArgs e)
        {
            //vyrobit list charu
            //zpřístupnit tlacitka
            list.Clear();
            foreach(char c in textBox1.Text)
            {
                list.Add(c);
            }
            foreach(Control btn in this.Controls)
            {
                btn.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(button2.Text);
            MessageBox.Show((sender as Button).Text);
            (sender as Button).Enabled = false;
            for(int i =0;i<list.Count;i++)
            {
                if(list[i] == char.Parse((sender as Button).Text))
                {
                    list.RemoveAt(i);
                }
            }
            Vypis();
        }
        private void Vypis()
        {
            textBox1.Text = "";
            foreach(char c in list)
            {
                textBox1.Text += c;
            }
        }
    }
}
