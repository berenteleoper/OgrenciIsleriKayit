﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmStudent frm = new FrmStudent();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmTeacher frm = new FrmTeacher();
            frm.Show();
        }
    }
}
