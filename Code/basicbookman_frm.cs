using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace _1110login_reg
{
    public partial class basicbookman_frm : Form
    {
        public string username = "";
        int pressid = 0;
        string theISBN = "";
        public basicbookman_frm()
        {
            InitializeComponent();
        }

        protected void clear_Form()
        {
            txt_intro.Text = "";
            txt_ISBN.Text = "";
            txt_author.Text = "";
            txt_bookname.Text = "";
            dp_pubtime.Value=DateTime.Now;
            num_price.Value = 0;
            num_storage.Value = 0;
            num_version.Value = 0;
            pressid = 0;
        }

        protected void get_basicBook(string s)
        {
            MySqlConnection conn = new MySqlConnection("server=localhost;database=library;UID=mysql;PWD=123456;port=3306");
            conn.Open();
            string str = "select ISBN,PName,BName,BAuthor,BPubDate,BPrice,BStorage,BStorNow,BVersion,BIntro from book_info,press_info where book_info.PID=press_info.PID ";
            str = String.Concat(str, s);
            MySqlDataAdapter da = new MySqlDataAdapter(str, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            lv_basicBook.Items.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem item = new ListViewItem(dr["ISBN"].ToString());
                item.SubItems.Add(dr["PName"].ToString());
                item.SubItems.Add(dr["BName"].ToString());
                item.SubItems.Add(dr["BAuthor"].ToString());
                item.SubItems.Add(dr["BPubDate"].ToString());
                item.SubItems.Add(dr["BPrice"].ToString());
                item.SubItems.Add(dr["BStorage"].ToString());
                item.SubItems.Add(dr["BStorNow"].ToString());
                item.SubItems.Add(dr["BVersion"].ToString());
                item.SubItems.Add(dr["BIntro"].ToString());
                lv_basicBook.Items.Add(item);
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            string ISBN = txt_ISBN.Text.Trim();
            string bname = txt_bookname.Text.Trim();
            string author =txt_author.Text.Trim();
            string pubdate=dp_pubtime.Value.ToString("yyyy-MM-dd");
            string pricestr=num_price.Value.ToString();
            int price = Convert.ToInt16(pricestr);
            string stostr=num_storage.Value.ToString();
            int storage = Convert.ToInt16(stostr);
            string versionstr=num_version.Value.ToString();
            int version = Convert.ToInt16(versionstr);
            string intro=txt_intro.Text.Trim();
            pressid = Convert.ToInt16(cbox_press.SelectedValue.ToString());
            if (ISBN == "")
            {
                lbl_Note.Text = "ISBN不能为空！";
                lbl_Note.ForeColor = Color.Red;
                txt_ISBN.Focus();
            }
            else if(bname=="")
            {
                lbl_Note.Text = "书名不能为空！";
                lbl_Note.ForeColor = Color.Red;
                txt_ISBN.Focus();
            }
            else if (lbl_Status.Text == "添加")
            {
                MySqlConnection conn = new MySqlConnection("server=localhost;database=library;UID=mysql;PWD=123456;port=3306");
                conn.Open();
                string hasISBN = string.Format("select COUNT(*) from book_info where ISBN='{0}'", ISBN);
                MySqlCommand cmd = new MySqlCommand(hasISBN, conn);
                int i = Convert.ToInt16(cmd.ExecuteScalar());
                if (i > 0)
                {
                    DialogResult dr = MessageBox.Show("该ISBN对应图书已存在。是否对其增加库存？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(dr == DialogResult.Yes)
                    {
                        string str1 = string.Format("update book_info set BStorage=BStorage+{0}, BStorNow=BStorNow+{1} where ISBN='{2}'", storage,storage, ISBN);
                        cmd.CommandText = str1;
                        int i1 = cmd.ExecuteNonQuery();
                        string str2 = string.Format("insert into inlib_book_info values(null,'{0}',1,current_date())",ISBN);
                        cmd.CommandText = str2;
                        int i2 = 0;
                        for(int j=0;j<storage;j++)
                            i2= cmd.ExecuteNonQuery();
                        if (i1>0&&i2>0)
                        {
                            lbl_Note.Text = "图书基本信息更新成功！";
                            lbl_Note.ForeColor = Color.Blue;
                            clear_Form();
                            get_basicBook(";");
                        }
                        else
                        {
                            lbl_Note.Text = "图书基本信息更新失败！";
                            lbl_Note.ForeColor = Color.Red;
                        }
                    }
                    else
                    {
                        clear_Form();
                    }
                }
                else
                {
                    if(ISBN.Length!=13)
                    {
                        MessageBox.Show("请输入长度为13位的ISBN编号！");
                        return;
                    }
                    string str = string.Format("insert into book_info values('{0}',{1},'{2}','{3}','{4}',{5},{6},{7},{8},'{9}',null,null,null)", ISBN, pressid, bname, author, pubdate, price, storage, storage, version,intro);
                    cmd.CommandText = str;
                    int i1 = cmd.ExecuteNonQuery();
                    
                    if (i1 > 0)
                    {
                        lbl_Note.Text = "图书基本信息添加成功！";
                        lbl_Note.ForeColor = Color.Blue;
                        clear_Form();
                        get_basicBook(";");
                    }
                    else
                    {
                        lbl_Note.Text = "图书基本信息添加失败！";
                        lbl_Note.ForeColor = Color.Red;
                    }
                }
                conn.Close();
            }
            else
            {
                MySqlConnection conn = new MySqlConnection("server=localhost;database=library;UID=mysql;PWD=123456;port=3306");
                conn.Open();
                string str = string.Format("update book_info set BIntro='{0}',PID={1},BName='{2}',BAuthor='{3}',BPubDate='{4}',BPrice={5},BStorage={6},BStorNow={7},BVersion={8} where ISBN='{9}'",intro, pressid, bname, author, pubdate, price, storage, storage, version,ISBN);
                MySqlCommand cmd = new MySqlCommand(str, conn);
                int i = cmd.ExecuteNonQuery();
                conn.Close();
                if (i > 0)
                {
                    lbl_Note.Text = "图书基本信息修改成功！";
                    lbl_Note.ForeColor = Color.Blue;
                    clear_Form();
                    get_basicBook(";");
                }
                else
                {
                    lbl_Note.Text = "图书基本信息修改失败！";
                    lbl_Note.ForeColor = Color.Red;
                }
            }
            lv_basicBook.SelectedItems.Clear();
        }

        protected void databind_Press()
        {
            MySqlConnection conn = new MySqlConnection("server=localhost;database=library;UID=mysql;PWD=123456;port=3306");
            conn.Open();
            string str = "select PID,PName from press_info";
            MySqlDataAdapter da = new MySqlDataAdapter(str, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            cbox_press.DataSource = dt;
            cbox_press.DisplayMember = "PName";
            cbox_press.ValueMember = "PID";
        }
        private void basicbookman_frm_Load(object sender, EventArgs e)
        {
            databind_Press();
            get_basicBook(";");
        }

        private void lv_basicBook_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (lv_basicBook.SelectedItems.Count > 0)
            {
                ListViewItem item = lv_basicBook.SelectedItems[0];
                txt_ISBN.Text = item.SubItems[0].Text;
                cbox_press.Text = item.SubItems[1].Text;
                txt_bookname.Text = item.SubItems[2].Text;
                txt_author.Text = item.SubItems[3].Text;
                dp_pubtime.Text = item.SubItems[4].Text;
                num_price.Value = Convert.ToInt16(item.SubItems[5].Text);
                num_storage.Value = Convert.ToInt16(item.SubItems[6].Text);
                num_version.Value = Convert.ToInt16(item.SubItems[8].Text);
                txt_intro.Text = item.SubItems[9].Text;
                lbl_Status.Text = "修改";
                theISBN = txt_ISBN.Text;
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            clear_Form();
            lv_basicBook.SelectedItems.Clear();
            get_basicBook(";");
            lbl_Status.Text = "添加";
        }

        private void btn_Del_Click(object sender, EventArgs e)
        {
            if (theISBN == "")
            {
                MessageBox.Show("请选择要删除的图书基本信息！");
            }
            else
            {
                DialogResult dr = MessageBox.Show("确定删除选中图书基本信息？", "删除提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    MySqlConnection conn = new MySqlConnection("server=localhost;database=library;UID=mysql;PWD=123456;port=3306");
                    conn.Open();
                    string selectstr = string.Format("select count(LID) from inlib_book_info where ISBN='{0}' group by ISBN; ", theISBN);
                    MySqlDataAdapter da = new MySqlDataAdapter(selectstr, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if(dt.Rows.Count > 0)
                    {
                        MessageBox.Show("该书仍有库存，若需删除，请先删除对应图书后再进行！");
                        return;
                    }
                    string str = string.Format("delete from book_info where ISBN='{0}'", theISBN);
                    MySqlCommand cmd = new MySqlCommand(str, conn);
                    int i = cmd.ExecuteNonQuery();
                    conn.Close();
                    if (i > 0)
                    {
                        lbl_Note.Text = "图书基本信息删除成功！";
                        lbl_Note.ForeColor = Color.Blue;
                        get_basicBook(";");
                    }
                    else
                    {
                        lbl_Note.Text = "图书基本信息删除失败！";
                        lbl_Note.ForeColor = Color.Red;
                    }
                }
                theISBN = "";
                clear_Form();
                lv_basicBook.SelectedItems.Clear();
            }
        }

        private void basicbookman_frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            bookmanage_frm bf = new bookmanage_frm();
            bf.username = username;
            bf.Show();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            string str1 = "", str2 = "", str3 = "", str4 = "";
            if (txt_ISBN.Text != "")
            {
                string ISBN = txt_ISBN.Text;
                str1 = string.Format(" and ISBN='{0}'", ISBN);
            }
            if (txt_bookname.Text != "")
            {
                string BName = txt_bookname.Text;
                str2 = string.Format(" and BName like '%{0}%'", BName);
            }
            if (txt_author.Text != "")
            {
                string author = txt_author.Text;
                str3 = string.Format(" and BAuthor like '%{0}%'", author);
            }
            if (cbox_press.Text != "")
            {
                string press = cbox_press.Text;
                str4 = string.Format(" and PName like '%{0}%'", press);
            }
            String str = String.Concat(str1, str2, str3, str4,";");
            get_basicBook(str);
        }
    }
}
