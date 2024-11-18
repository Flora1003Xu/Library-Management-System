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
    public partial class ManMain : Form
    {
        public string manname = "";
        public bool closeflag = true;
        public ManMain()
        {
            InitializeComponent();
            
        }

        private void btn_bookmanagement_Click(object sender, EventArgs e)
        {
            bookmanage_frm bf = new bookmanage_frm();
            bf.username=manname;
            bf.Show();
            closeflag = false;
            this.Close();
            closeflag=true;
        }

        private void ManMain_Load(object sender, EventArgs e)
        {
            lbl_managername.Text = manname;
        }

        private void btn_borrow_Click(object sender, EventArgs e)
        {
            MessageBox.Show("功能尚未开放。敬请期待！");
        }

        private void btn_returnmanagement_Click(object sender, EventArgs e)
        {
            MessageBox.Show("功能尚未开放。敬请期待！");
        }

        private void btn_fine_Click(object sender, EventArgs e)
        {
            MessageBox.Show("功能尚未开放。敬请期待！");
        }

        private void ManMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(closeflag)
            {
                DialogResult dr = MessageBox.Show("确定要离开系统吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
            
        }
    }
}
