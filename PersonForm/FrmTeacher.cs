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
    public partial class FrmTeacher : Form
    {
        public FrmTeacher()
        {
            InitializeComponent();
        }
        TeacherManager mngr = new TeacherManager();
        void temizle()
        {
            txtId.Clear();
            txtAd.Clear();
            txtSoyad.Clear();
            txtYas.Clear();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Teacher t = new Teacher();
            t.personId = Int32.Parse(txtId.Text);
            t.Name = txtAd.Text;
            t.LastName = txtSoyad.Text;
            t.Age = Int32.Parse(txtYas.Text);
            mngr.Add(t); // std öğrencisini kaydet
            List();
            temizle();
        }
        void List()
        {
            dataGridView1.Rows.Clear();
            foreach (var item in mngr.List())
            {
                dataGridView1.Rows.Add(item.personId, item.Name, item.LastName, item.Age);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // grid üzerinde sçilen kaydı ilgili text 'lere aktarmak
            int secilenSatirNo = e.RowIndex;
            txtId.Text = dataGridView1.Rows[secilenSatirNo].Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.Rows[secilenSatirNo].Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[secilenSatirNo].Cells[2].Value.ToString();
            txtYas.Text = dataGridView1.Rows[secilenSatirNo].Cells[3].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtId.Text))
            {
                mngr.Remove(Int32.Parse(txtId.Text));// silme
                List();
                temizle();
            }
        }
    }
}
