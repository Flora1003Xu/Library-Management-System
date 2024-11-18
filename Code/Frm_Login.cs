using MySql.Data.MySqlClient;
using System.Data;

namespace _1110login_reg
{
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(username_txt.Text.Trim()=="")
            {
                MessageBox.Show("�������û�����");
                username_txt.Focus();
            }
            else if (password_txt.Text.Trim() == "")
            {
                MessageBox.Show("���������룡");
                password_txt.Focus();
            }
            else
            {
                string str;
                if(rbt_reader.Checked)
                    str = string.Format("select * from reader_info, rkind_info where reader_info.KID=rkind_info.KID and RName='{0}' and Password='{1}'",username_txt.Text,password_txt.Text);
                else
                    str = string.Format("select * from manager_info where MName='{0}' and Password='{1}'", username_txt.Text, password_txt.Text);
                MySqlConnection conn = new MySqlConnection("server=localhost;database=library;UID=mysql;PWD=123456;port=3306");
                conn.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(str,conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                conn.Close();
                
                if(dt.Rows.Count>0)
                {
                    this.Hide();
                    if (rbt_reader.Checked)
                    {
                        DataRow dr = dt.Rows[0];
                        int userid = Convert.ToInt16(dr["RID"].ToString());
                        int borTLimit = Convert.ToInt16(dr["TLimit"].ToString());
                        int borNLimit = Convert.ToInt16(dr["BLimit"].ToString()) ;
                        int readerBorNow = Convert.ToInt16(dr["RBorNow"].ToString());
                        Frm_Main f = new Frm_Main();
                        f.username = username_txt.Text;
                        f.userid = userid;
                        f.borNLimit = borNLimit;
                        f.borTLimit= borTLimit;
                        f.borNow = readerBorNow;
                        f.Show();
                    }
                    else
                    {
                        ManMain f = new ManMain();
                        f.manname = username_txt.Text;
                        f.Show();
                    }
                }
                else
                {
                    MessageBox.Show("�Բ����û��������벻��ȷ��");
                }
            }
        }

        private void rbt_reader_CheckedChanged(object sender, EventArgs e)
        {
            rbt_manager.Checked = !rbt_reader.Checked;
        }

        private void rbt_manager_CheckedChanged(object sender, EventArgs e)
        {
            rbt_reader.Checked = !rbt_manager.Checked;
        }

        private void Frm_Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("ȷ��Ҫ�뿪ϵͳ��", "��ʾ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {

        }
    }
}