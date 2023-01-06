using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TooBoxNesneleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //SİLME
            comboBox1.Items.Remove(comboBox1.SelectedItem);
            // display member
            // value member
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex==0)
            {
                pictureBox1.Image = Properties.Resources.Ankara;

                //pictureBox1.ImageLocation = "Ankara.jpeg";
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                pictureBox1.Image = Properties.Resources.İstanbul;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                pictureBox1.Image = Properties.Resources.İzmir;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked) // +
            {
                textBox4.Text = (Int32.Parse(textBox2.Text) + Int32.Parse(textBox3.Text)).ToString();
            }
            else if (radioButton2.Checked) // -
            {
                textBox4.Text = (Int32.Parse(textBox2.Text) - Int32.Parse(textBox3.Text)).ToString();
            }
            else if (radioButton3.Checked) // *
            {
                textBox4.Text = (Int32.Parse(textBox2.Text) * Int32.Parse(textBox3.Text)).ToString();
            }
            else if (radioButton4.Checked) // /
            {
                textBox4.Text = (double.Parse(textBox2.Text) / double.Parse(textBox3.Text)).ToString();
            }
        }
    }
}
