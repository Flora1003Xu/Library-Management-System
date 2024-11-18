using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1110login_reg
{
    public partial class bookmanage_frm : Form
    {
        public string username = "";
        public bool closeflag = false;
        public bookmanage_frm()
        {
            InitializeComponent();
        }

        private void btn_Pressmanagement_Click(object sender, EventArgs e)
        {
            Man_Press mp = new Man_Press();
            mp.username = username;
            mp.Show();
            closeflag = true;
            this.Close();
        }

        private void btn_bookmanage_Click(object sender, EventArgs e)
        {
            basicbookman_frm bf=new basicbookman_frm();
            bf.username = username;
            bf.Show();
            closeflag = true;
            this.Close();
        }

        private void bookmanage_frm_Load(object sender, EventArgs e)
        {
            lbl_managername.Text = username;
        }

        private void bookmanage_frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(!closeflag)
            {
                ManMain frm = new ManMain();
                frm.manname = username;
                frm.Show();
            }
            
        }

        private void btn_libmanage_Click(object sender, EventArgs e)
        {
            MessageBox.Show("该功能暂未开放，敬请期待！");
        }
    }
}
