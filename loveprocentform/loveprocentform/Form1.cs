using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loveprocentform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int love = rnd.Next(19, 101);/*tova e random chislo ot 20 do 100*/
            string asd = love.ToString();
 
            if (textBox1.Text=="" || textBox2.Text == "")
            {
                label3.Text = "ГРЕШКА";
            }
            else
            {
                label3.Text ="Любов:"+asd +"%";
            }
            if (textBox1.Text=="Гошкина" && textBox2.Text=="Гошко")
            {
                label3.Text = "НИКОГА";
            }
            
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label3.Text = String.Empty;
            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
        }
    }
}
