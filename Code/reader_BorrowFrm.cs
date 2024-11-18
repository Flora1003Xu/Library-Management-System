using Microsoft.VisualBasic.Logging;
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
    public partial class reader_BorrowFrm : Form
    {
        public string username = "";
        public int userid = 0;
        public int borTLimit = 0;
        public reader_BorrowFrm()
        {
            InitializeComponent();
        }

        protected void get_All_Book()
        {
            MySqlConnection conn = new MySqlConnection("server=localhost;database=library;UID=mysql;PWD=123456;port=3306");
            conn.Open();
            string str = "select * from book_info, press_info where book_info.PID=press_info.PID";
            MySqlDataAdapter da = new MySqlDataAdapter(str, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            lv_Book.Items.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem item = new ListViewItem(dr["ISBN"].ToString());
                item.SubItems.Add(dr["BName"].ToString());
                item.SubItems.Add(dr["BAuthor"].ToString());
                item.SubItems.Add(dr["PName"].ToString());
                item.SubItems.Add(dr["BVersion"].ToString());
                item.SubItems.Add(dr["BStorage"].ToString());
                item.SubItems.Add(dr["BStorNow"].ToString());
                item.SubItems.Add(dr["BIntro"].ToString());
                lv_Book.Items.Add(item);
            }
        }

        protected void get_Book(string str)
        {
            MySqlConnection conn = new MySqlConnection("server=localhost;database=library;UID=mysql;PWD=123456;port=3306");
            conn.Open();
            MySqlDataAdapter da = new MySqlDataAdapter(str, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            lv_Book.Items.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem item = new ListViewItem(dr["ISBN"].ToString());
                item.SubItems.Add(dr["BName"].ToString());
                item.SubItems.Add(dr["BAuthor"].ToString());
                item.SubItems.Add(dr["PName"].ToString());
                item.SubItems.Add(dr["BVersion"].ToString());
                item.SubItems.Add(dr["BStorage"].ToString());
                item.SubItems.Add(dr["BStorNow"].ToString());
                item.SubItems.Add(dr["BIntro"].ToString());
                lv_Book.Items.Add(item);
            }
        }

        private void reader_BorrowFrm_Load(object sender, EventArgs e)
        {
            get_All_Book();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            string str = "select * from book_info, press_info where book_info.PID=press_info.PID";
            string str1="", str2="", str3 = "", str4 = "";
            if (txt_ISBN.Text!="")
            {
                string ISBN=txt_ISBN.Text;
                str1 = string.Format(" and ISBN like '%{0}%'",ISBN);
            }
            if(txt_BName.Text!="")
            {
                string BName=txt_BName.Text;
                str2 = string.Format(" and BName like '%{0}%'", BName);
            }
            if(txt_Author.Text!="")
            {
                string author=txt_Author.Text;
                str3 = string.Format(" and BAuthor like '%{0}%'", author);
            }
            if(txt_Press.Text!="")
            {
                string press = txt_Press.Text;
                str4 = string.Format(" and PName like '%{0}%'", press);
            }
            str=String.Concat(str,str1,str2,str3,str4);
            get_Book(str);
        }

        private void btn_Borrow_Click(object sender, EventArgs e)
        {
            if(lv_Book.SelectedItems.Count>0)
            {
                ListViewItem item = lv_Book.SelectedItems[0];
                string ISBN = item.SubItems[0].Text;
                string BName= item.SubItems[1].Text;
                string author= item.SubItems[2].Text;
                string press= item.SubItems[3].Text;
                int version = Convert.ToInt16(item.SubItems[4].Text);
                int stornow= Convert.ToInt16(item.SubItems[6].Text);
                if(stornow==0)
                {
                    MessageBox.Show("抱歉！您选择的书籍暂无库存！");
                    return;
                }
                else
                {
                    reader_Borrow2 r2=new reader_Borrow2();
                    r2.ISBN = ISBN;
                    r2.author = author;
                    r2.press = press;
                    r2.BName=BName;
                    r2.version = version;
                    r2.username = username;
                    r2.userid = userid;
                    r2.borTLimit=borTLimit;
                    r2.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("请在列表中选择您要借阅的书籍！");
            }
        }

        private void reader_BorrowFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Frm_Main frmMain = new Frm_Main();
            frmMain.userid = userid;
            frmMain.username = username;
            frmMain.Show();
        }
    }
}
