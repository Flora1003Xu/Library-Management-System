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
    public partial class Man_Press : Form
    {
        string pressid = "";
        public string username = "";
        public Man_Press()
        {
            InitializeComponent();
        }
       

        protected void clear_Form()
        {
            txt_PName.Text = "";
            txt_ContactName.Text = "";
            txt_city.Text = "";
            txt_country.Text = "";
            txt_distinct.Text = "";
            txt_doorno.Text = "";
            txt_province.Text = "";
            txt_street.Text = "";
            txt_Telephone.Text = "";
            lbl_Status.Text = "添加";
        }

        protected void get_Press(string s)
        {
            MySqlConnection conn = new MySqlConnection("server=localhost;database=library;UID=mysql;PWD=123456;port=3306");
            conn.Open();
            string str = "select * from press_info";
            str = String.Concat(str, s);
            MySqlDataAdapter da = new MySqlDataAdapter(str, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            lv_Customer.Items.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem item = new ListViewItem(dr["PID"].ToString());
                item.SubItems.Add(dr["PName"].ToString());
                item.SubItems.Add(dr["PContact"].ToString());
                item.SubItems.Add(dr["PPhone"].ToString());
                item.SubItems.Add(dr["PCounRe"].ToString());
                item.SubItems.Add(dr["PProvince"].ToString());
                item.SubItems.Add(dr["PCity"].ToString());
                item.SubItems.Add(dr["PDistinct"].ToString());
                item.SubItems.Add(dr["PStreet"].ToString());
                item.SubItems.Add(dr["PDNo"].ToString());
                lv_Customer.Items.Add(item);
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            string name = txt_PName.Text.Trim();
            string contact = txt_ContactName.Text.Trim();
            string tel = txt_Telephone.Text.Trim();
            string country = txt_country.Text.Trim();
            string pro = txt_province.Text.Trim();
            string city = txt_city.Text.Trim();
            string distinct = txt_distinct.Text.Trim();
            string street = txt_street.Text.Trim();
            string doorstr = txt_doorno.Text.Trim();
            int doorno=doorstr==""?0:Convert.ToInt16(doorstr);

            if (name == "")
            {
                lbl_Note.Text = "出版社名称不能为空！";
                lbl_Note.ForeColor = Color.Red;
                txt_PName.Focus();
            }
            else if (lbl_Status.Text == "添加")
            {
                MySqlConnection conn = new MySqlConnection("server=localhost;database=library;UID=mysql;PWD=123456;port=3306");
                conn.Open();
                string str = string.Format("insert into press_info values(null,'{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}',{8})", name, contact, tel, country, pro,city,distinct,street,doorno);
                MySqlCommand cmd = new MySqlCommand(str, conn);
                int i = cmd.ExecuteNonQuery();
                conn.Close();
                if (i > 0)
                {
                    lbl_Note.Text = "出版社信息添加成功！";
                    lbl_Note.ForeColor = Color.Blue;
                    clear_Form();
                    get_Press(";");
                }
                else
                {
                    lbl_Note.Text = "出版社信息添加失败！";
                    lbl_Note.ForeColor = Color.Red;
                }
            }
            else
            {
                MySqlConnection conn = new MySqlConnection("server=localhost;database=library;UID=mysql;PWD=123456;port=3306");
                conn.Open();
                string str = string.Format("update press_info set PName='{0}',PContact='{1}',PPhone='{2}',PCounRe='{3}',PProvince='{4}',PCity='{5}',PDistinct='{6}',PStreet='{7}',PDNo={8} where PID={9}", name, contact, tel, country, pro, city, distinct, street, doorno,pressid);
                MySqlCommand cmd = new MySqlCommand(str, conn);
                int i = cmd.ExecuteNonQuery();
                conn.Close();
                if (i > 0)
                {
                    lbl_Note.Text = "出版社信息修改成功！";
                    lbl_Note.ForeColor = Color.Blue;
                    clear_Form();
                    get_Press(";");
                }
                else
                {
                    lbl_Note.Text = "出版社信息修改失败！";
                    lbl_Note.ForeColor = Color.Red;
                }
            }
            lv_Customer.SelectedItems.Clear();
        }

        private void lv_Customer_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (lv_Customer.SelectedItems.Count > 0)
            {
                ListViewItem item = lv_Customer.SelectedItems[0];
                pressid = item.SubItems[0].Text;
                txt_PName.Text = item.SubItems[1].Text;
                txt_ContactName.Text = item.SubItems[2].Text;
                txt_Telephone.Text = item.SubItems[3].Text;
                txt_country.Text = item.SubItems[4].Text;
                txt_province.Text=item.SubItems[5].Text;
                txt_city.Text = item.SubItems[6].Text;
                txt_distinct.Text = item.SubItems[7].Text;
                txt_street.Text = item.SubItems[8].Text;
                txt_doorno.Text = item.SubItems[9].Text;
                lbl_Status.Text = "修改";
            }
        }

        private void Man_Press_Load(object sender, EventArgs e)
        {
            get_Press(";");
        }

        private void Man_Press_FormClosed(object sender, FormClosedEventArgs e)
        {
            bookmanage_frm bf = new bookmanage_frm();
            bf.username = username;
            bf.Show();
        }

        private void btn_Del_Click(object sender, EventArgs e)
        {
            if (pressid == "")
            {
                MessageBox.Show("请选择要删除的出版社信息！");
            }
            else
            {
                DialogResult dr = MessageBox.Show("确定删除选中出版社信息？", "删除提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    MySqlConnection conn = new MySqlConnection("server=localhost;database=library;UID=mysql;PWD=123456;port=3306");
                    conn.Open();
                    string str = string.Format("select * from book_info where PID={0}", pressid);
                    MySqlDataAdapter da = new MySqlDataAdapter(str, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count>0)
                    {
                        MessageBox.Show("馆藏图书中有该出版社出版图书，该出版社信息不可删除！");
                        return;
                    }
                    str = string.Format("delete from press_info where PID={0}", pressid);
                    MySqlCommand cmd = new MySqlCommand(str, conn);
                    int i = cmd.ExecuteNonQuery();
                    conn.Close();
                    if (i > 0)
                    {
                        lbl_Note.Text = "出版社信息删除成功！";
                        lbl_Note.ForeColor = Color.Blue;
                        get_Press(";");
                    }
                    else
                    {
                        lbl_Note.Text = "出版社信息删除失败！";
                        lbl_Note.ForeColor = Color.Red;
                    }
                }
                pressid = "";
                clear_Form();
                lv_Customer.SelectedItems.Clear();
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            clear_Form();
            lbl_Note.Text = "";
            lv_Customer.SelectedItems.Clear();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            string str1 = "", str2 = "";
            if (txt_PName.Text != "")
            {
                string pname = txt_PName.Text;
                str1 = string.Format(" PName='{0}'", pname);
            }
            if (txt_ContactName.Text != "")
            {
                string cName = txt_ContactName.Text;
                str2 = string.Format("PContact like '%{0}%'", cName);
                if (str1 != "")
                    str2 = String.Concat("and ", str2);
            }
            String str = String.Concat(" where ",str1, str2, ";");
            get_Press(str);
        }
    }
}
