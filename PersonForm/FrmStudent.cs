using Arayuz2;
using System;
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
    public partial class FrmStudent : Form
    {
        public FrmStudent()
        {
            InitializeComponent();
        }

        StudentManager mngr = new StudentManager();
        void temizle()
        {
            txtId.Clear();
            txtAd.Clear();
            txtSoyad.Clear();
            txtYas.Clear();
        }
        private void EkleButonu(object sender, EventArgs e)
        {
            Student std = new Student();
            std.personId = Int32.Parse(txtId.Text);
            std.Name = txtAd.Text;
            std.LastName = txtSoyad.Text;
            std.Age = Int32.Parse(txtYas.Text);
            mngr.Add(std); 
            List();
            temizle();
        }

        void List() {
            dataGridView1.Rows.Clear() ;
            foreach (var item in mngr.List())
            {
                dataGridView1.Rows.Add(item.personId, item.Name, item.LastName, item.Age);
            }
         }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            int secilenSatirNo = e.RowIndex;
            txtId.Text = dataGridView1.Rows[secilenSatirNo].Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.Rows[secilenSatirNo].Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[secilenSatirNo].Cells[2].Value.ToString();
            txtYas.Text= dataGridView1.Rows[secilenSatirNo].Cells[3].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtId.Text))
            {
                mngr.Remove(Int32.Parse(txtId.Text));
                List();
                temizle();
            }
            
        }

        private void EnteraBasıncaCalıstırmaButonu(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                button1.PerformClick();
            }
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
