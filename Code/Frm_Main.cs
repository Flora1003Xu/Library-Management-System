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
    public partial class Frm_Main : Form
    {
        public string username = "";
        public int userid = 0;
        public int borTLimit = 0;
        public int borNLimit = 0;
        public int borNow = 0;
        public Frm_Main()
        {
            InitializeComponent();
        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {
            lbl_username.Text=username;
        }

        private void btn_Borrow_Click(object sender, EventArgs e)
        {
            if(borNow>=borNLimit)
            {
                MessageBox.Show("您借阅的书籍本数已达上限，请先归还部分书籍后才能继续借阅哦！");
                return;
            }
            reader_BorrowFrm rb = new reader_BorrowFrm();
            rb.username = username;
            rb.userid = userid;
            rb.borTLimit = borTLimit;
            rb.Show();
            this.Hide();
        }

        private void Frm_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("确定要离开系统吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("功能尚未开放。敬请期待！");
        }

        private void btn_Return_Click(object sender, EventArgs e)
        {
            MessageBox.Show("功能尚未开放。敬请期待！");
        }
    }
}
