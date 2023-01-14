using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Produkt produkt;
        private void button1_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;
            produkt = new Produkt(textBox1.Text, (int)numericUpDown1.Value, dateTimePicker1.Value, (int)numericUpDown2.Value);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(produkt.ToString());
            if (produkt.Lzeslevnit(checkBox1.Checked) == true)
            {
                MessageBox.Show("Produkt lze slevnit");
            }
            else
            {
                MessageBox.Show("Produkt nelze slevnit");
            }
        }
    }
}
