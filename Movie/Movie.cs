using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movie
{
    public partial class Movie : Form
    {
        public Movie()
        {
            InitializeComponent();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            name.Text = "";
            cat.Text = "";
            director.Text = "";
            imb.Text = "";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            String m_name = name.Text;
            String m_cat = cat.Text;
            String m_director = director.Text;
            String m_imb = imb.Text;
            Manager.Insertmovie(m_name, m_cat, m_director, m_imb);
            MessageBox.Show("บันทึกข้อมูลสำเร็จแล้ว", "แจ้งเตือน");
        }

        private void M_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            String m_name = name.Text;
            String m_cat = cat.Text;
            String m_director = director.Text;
            String m_imb = imb.Text;
            Manager.Updatemovie(m_name, m_cat, m_director, m_imb);
            MessageBox.Show("แก้ไขข้อมูลสำเร็จแล้ว", "แจ้งเตือน");
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            String m_name = name.Text;
            Manager.Deletemovie(m_name);
            MessageBox.Show("ลบข้อมูลสำเร็จแล้ว", "แจ้งเตือน");
        }
    }
}
