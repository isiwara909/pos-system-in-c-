using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stockmanegment_system
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        private void addForm(Form frm)
        {

            panel2.Controls.Clear();
            frm.TopLevel = false;
            frm.TopMost = true;
            //frm.Dock = DockStyle.Fill;
            panel2.Controls.Add(frm);
            frm.Show();


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            addForm(new Form3());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            addForm(new Form5());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            addForm( new Form6());
        }
    }
}
