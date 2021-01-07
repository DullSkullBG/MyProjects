using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace word_counter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string whole_text = richTextBox1.Text;
            string trimmed_text = whole_text.Trim();
            string[] split_text = trimmed_text.Split(' ');
            int space_count = 0;
            string new_text = "";

            foreach (string av in split_text)
            {
                if (av == "")
                {
                    space_count++;
                }
                else
                {
                    new_text = new_text + av + ",";
                }
            }

            new_text = new_text.TrimEnd(',');
            split_text = new_text.Split(',');
            MessageBox.Show(split_text.Length.ToString());
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
