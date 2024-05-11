using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Calculator_programming_2__bayan_alkhatieb_
{
   

    public partial class Form1 : Form
    {      
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Button bn = (Button)sender;

            if (textBox1.Text == "0" || isoperat == true)
            { textBox1.Clear(); }


            if (bn.Text == ".")
            {
                if(!textBox1.Text.Contains("."))
                { textBox1.Text = textBox1.Text + bn.Text; }
            }
            else
            {
                textBox1.Text = textBox1.Text + bn.Text;
            }
           isoperat = false;
        }



        string operation = "";
        double res = 0;
        bool isoperat = false;

        private void button12_Click(object sender, EventArgs e)
        {
            Button bn = (Button)sender;

            operation = bn.Text;

            res = Convert.ToDouble(textBox1.Text);

            isoperat = true;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            switch(operation)
            {
                case "+":
                    textBox1.Text = (res + Convert.ToDouble(textBox1.Text)).ToString();
                    break;

                case "-":

                    textBox1.Text = (res - Convert.ToDouble(textBox1.Text)).ToString();
                    break;


                case "*":
                    textBox1.Text = (res * Convert.ToDouble(textBox1.Text)).ToString();
                    break;


                case "/":
                    textBox1.Text = (res / Convert.ToDouble(textBox1.Text)).ToString();
                    break;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Clear();

            res = 0;
        }
    }
}
