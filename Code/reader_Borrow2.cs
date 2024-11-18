using MySql.Data.MySqlClient;
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
    public partial class reader_Borrow2 : Form
    {
        public string ISBN = "";
        public string BName = "";
        public string author = "";
        public string press = "";
        public int version = 0;
        public string username = "";
        public int userid = 0;
        public int borTLimit = 0;
        public reader_Borrow2()
        {
            InitializeComponent();
        }
        protected void databind_BID()
        {
            MySqlConnection conn = new MySqlConnection("server=localhost;database=library;UID=mysql;PWD=123456;port=3306");
            conn.Open();
            string str = string.Format("select LID from inlib_book_info where ISBN='{0}' and LState=1",ISBN);
            MySqlDataAdapter da = new MySqlDataAdapter(str, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            cbox_BID.DataSource = dt;
            cbox_BID.DisplayMember = "LID";
        }

        private void reader_Borrow2_Load(object sender, EventArgs e)
        {
            lbl_username.Text = username;
            databind_BID();
            txt_Author.ReadOnly = false;
            txt_BName.ReadOnly = false;
            txt_ISBN.ReadOnly = false;
            txt_Press.ReadOnly = false;
            txt_Version.ReadOnly = false;

            txt_Author.Text = author;
            txt_Author.ReadOnly = true;
            txt_BName.Text = BName;
            txt_BName.ReadOnly = true;
            txt_ISBN.Text = ISBN;
            txt_ISBN.ReadOnly = true;
            txt_Press.Text = press;
            txt_Press.ReadOnly = true;
            txt_Version.Text=version.ToString();
            txt_Version.ReadOnly = true;
            num_Borlen.Maximum = borTLimit;
        }

        private void btn_Borrow_Click(object sender, EventArgs e)
        {
            int bookid = Convert.ToInt16(cbox_BID.Text);
            DialogResult dr = MessageBox.Show("亲爱的读者"+username+"，\n您确认要借阅图书《"+BName+"》吗？", "确认提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dr.Equals(DialogResult.Yes))
            {
                int borlen = Convert.ToInt16(num_Borlen.Value.ToString());
                MySqlConnection conn = new MySqlConnection("server=localhost;database=library;UID=mysql;PWD=123456;port=3306");
                conn.Open();
                string str0 = "set @@autocommit=0;start transaction;";
                string str1 = string.Format("insert into borrow_info values(null,{0},1,{1},current_date(),{2},0);", userid,bookid,borlen);
                string str2 = string.Format("update inlib_book_info set LState=0 where LID={0};",bookid);
                string str3 = string.Format("update book_info set BBorrow=BBorrow+1, BStorNow=BStorNow-1 where ISBN='{0}';", ISBN);
                string str4 = "commit;set @@autocommit=1;";
                string str5 = string.Format("update reader_info set RBor=RBor+1, RBorNow=RBorNow+1 where RID={0}", userid);
                string str = String.Concat(str0, str1, str2, str3, str4,str5);
                MySqlCommand cmd = new MySqlCommand(str, conn);
                int i=cmd.ExecuteNonQuery();
                if(i>0)
                {
                    MessageBox.Show("借阅成功！请记得准时归还哦！");
                }
                else
                {
                    MessageBox.Show("抱歉！借阅失败！请稍后重试！");
                }
                Frm_Main f = new Frm_Main();
                f.userid = userid;
                f.username = username;
                f.Show();
                this.Hide();
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            reader_BorrowFrm rb = new reader_BorrowFrm();
            rb.userid = userid;
            rb.username=username;
            rb.Show();
            this.Hide();
        }

        private void reader_Borrow2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Frm_Main frm = new Frm_Main();
            frm.userid = userid;
            frm.username = username;
            frm.Show();
        }
    }
}
