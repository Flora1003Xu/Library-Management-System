namespace _1110login_reg
{
    partial class Man_Press
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Man_Press));
            this.btn_Del = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lv_Customer = new System.Windows.Forms.ListView();
            this.no = new System.Windows.Forms.ColumnHeader();
            this.name = new System.Windows.Forms.ColumnHeader();
            this.contact = new System.Windows.Forms.ColumnHeader();
            this.tel = new System.Windows.Forms.ColumnHeader();
            this.country = new System.Windows.Forms.ColumnHeader();
            this.province = new System.Windows.Forms.ColumnHeader();
            this.city = new System.Windows.Forms.ColumnHeader();
            this.distinct = new System.Windows.Forms.ColumnHeader();
            this.street = new System.Windows.Forms.ColumnHeader();
            this.doorno = new System.Windows.Forms.ColumnHeader();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_doorno = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_street = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_distinct = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_country = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_city = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_Note = new System.Windows.Forms.Label();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.txt_ContactName = new System.Windows.Forms.TextBox();
            this.txt_province = new System.Windows.Forms.TextBox();
            this.txt_Telephone = new System.Windows.Forms.TextBox();
            this.txt_PName = new System.Windows.Forms.TextBox();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Del
            // 
            this.btn_Del.Location = new System.Drawing.Point(198, 391);
            this.btn_Del.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Del.Name = "btn_Del";
            this.btn_Del.Size = new System.Drawing.Size(117, 46);
            this.btn_Del.TabIndex = 19;
            this.btn_Del.Text = "删 除";
            this.btn_Del.UseVisualStyleBackColor = true;
            this.btn_Del.Click += new System.EventHandler(this.btn_Del_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lv_Customer);
            this.groupBox2.Location = new System.Drawing.Point(8, 404);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(1197, 416);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "出版社信息列表         ";
            // 
            // lv_Customer
            // 
            this.lv_Customer.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.no,
            this.name,
            this.contact,
            this.tel,
            this.country,
            this.province,
            this.city,
            this.distinct,
            this.street,
            this.doorno});
            this.lv_Customer.FullRowSelect = true;
            this.lv_Customer.GridLines = true;
            this.lv_Customer.Location = new System.Drawing.Point(25, 40);
            this.lv_Customer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lv_Customer.MultiSelect = false;
            this.lv_Customer.Name = "lv_Customer";
            this.lv_Customer.Size = new System.Drawing.Size(1144, 356);
            this.lv_Customer.TabIndex = 0;
            this.lv_Customer.UseCompatibleStateImageBehavior = false;
            this.lv_Customer.View = System.Windows.Forms.View.Details;
            this.lv_Customer.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lv_Customer_ItemSelectionChanged);
            // 
            // no
            // 
            this.no.Text = "编号";
            // 
            // name
            // 
            this.name.Text = "出版社名称";
            this.name.Width = 150;
            // 
            // contact
            // 
            this.contact.Text = "联系人";
            this.contact.Width = 100;
            // 
            // tel
            // 
            this.tel.Text = "电话";
            this.tel.Width = 80;
            // 
            // country
            // 
            this.country.Text = "国家/地区";
            this.country.Width = 120;
            // 
            // province
            // 
            this.province.Text = "省";
            this.province.Width = 100;
            // 
            // city
            // 
            this.city.Text = "市";
            this.city.Width = 100;
            // 
            // distinct
            // 
            this.distinct.Text = "区";
            this.distinct.Width = 100;
            // 
            // street
            // 
            this.street.Text = "街道";
            this.street.Width = 100;
            // 
            // doorno
            // 
            this.doorno.Text = "号";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.btn_Search);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txt_doorno);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txt_street);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txt_distinct);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_country);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_city);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbl_Note);
            this.groupBox1.Controls.Add(this.lbl_Status);
            this.groupBox1.Controls.Add(this.txt_ContactName);
            this.groupBox1.Controls.Add(this.txt_province);
            this.groupBox1.Controls.Add(this.txt_Telephone);
            this.groupBox1.Controls.Add(this.txt_PName);
            this.groupBox1.Controls.Add(this.btn_Cancel);
            this.groupBox1.Controls.Add(this.btn_Save);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(1197, 379);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "编辑出版社信息 状态：";
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(306, 244);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Search.Size = new System.Drawing.Size(154, 56);
            this.btn_Search.TabIndex = 27;
            this.btn_Search.Text = "查 询";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1081, 193);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 24);
            this.label10.TabIndex = 26;
            this.label10.Text = "号";
            // 
            // txt_doorno
            // 
            this.txt_doorno.Location = new System.Drawing.Point(986, 188);
            this.txt_doorno.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_doorno.Name = "txt_doorno";
            this.txt_doorno.Size = new System.Drawing.Size(88, 35);
            this.txt_doorno.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(921, 190);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 24);
            this.label9.TabIndex = 24;
            this.label9.Text = "街道";
            // 
            // txt_street
            // 
            this.txt_street.Location = new System.Drawing.Point(822, 188);
            this.txt_street.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_street.Name = "txt_street";
            this.txt_street.Size = new System.Drawing.Size(88, 35);
            this.txt_street.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(780, 190);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 24);
            this.label8.TabIndex = 22;
            this.label8.Text = "区";
            // 
            // txt_distinct
            // 
            this.txt_distinct.Location = new System.Drawing.Point(682, 188);
            this.txt_distinct.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_distinct.Name = "txt_distinct";
            this.txt_distinct.Size = new System.Drawing.Size(88, 35);
            this.txt_distinct.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(287, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 24);
            this.label7.TabIndex = 20;
            this.label7.Tag = "";
            this.label7.Text = "国家/地区";
            // 
            // txt_country
            // 
            this.txt_country.Location = new System.Drawing.Point(199, 188);
            this.txt_country.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_country.Name = "txt_country";
            this.txt_country.Size = new System.Drawing.Size(88, 35);
            this.txt_country.TabIndex = 19;
            this.txt_country.Tag = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(638, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 24);
            this.label4.TabIndex = 18;
            this.label4.Text = "市";
            // 
            // txt_city
            // 
            this.txt_city.Location = new System.Drawing.Point(544, 188);
            this.txt_city.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_city.Name = "txt_city";
            this.txt_city.Size = new System.Drawing.Size(88, 35);
            this.txt_city.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(502, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 24);
            this.label3.TabIndex = 16;
            this.label3.Text = "省";
            // 
            // lbl_Note
            // 
            this.lbl_Note.AutoSize = true;
            this.lbl_Note.Location = new System.Drawing.Point(462, 296);
            this.lbl_Note.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Note.Name = "lbl_Note";
            this.lbl_Note.Size = new System.Drawing.Size(0, 24);
            this.lbl_Note.TabIndex = 15;
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Location = new System.Drawing.Point(257, 1);
            this.lbl_Status.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(60, 24);
            this.lbl_Status.TabIndex = 14;
            this.lbl_Status.Text = "添加";
            // 
            // txt_ContactName
            // 
            this.txt_ContactName.Location = new System.Drawing.Point(663, 40);
            this.txt_ContactName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_ContactName.Name = "txt_ContactName";
            this.txt_ContactName.Size = new System.Drawing.Size(244, 35);
            this.txt_ContactName.TabIndex = 11;
            // 
            // txt_province
            // 
            this.txt_province.Location = new System.Drawing.Point(410, 188);
            this.txt_province.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_province.Name = "txt_province";
            this.txt_province.Size = new System.Drawing.Size(88, 35);
            this.txt_province.TabIndex = 10;
            // 
            // txt_Telephone
            // 
            this.txt_Telephone.Location = new System.Drawing.Point(199, 111);
            this.txt_Telephone.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_Telephone.Name = "txt_Telephone";
            this.txt_Telephone.Size = new System.Drawing.Size(244, 35);
            this.txt_Telephone.TabIndex = 9;
            // 
            // txt_PName
            // 
            this.txt_PName.Location = new System.Drawing.Point(199, 44);
            this.txt_PName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_PName.Name = "txt_PName";
            this.txt_PName.Size = new System.Drawing.Size(244, 35);
            this.txt_PName.TabIndex = 8;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(730, 243);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(154, 56);
            this.btn_Cancel.TabIndex = 7;
            this.btn_Cancel.Text = "取 消";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(517, 244);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(154, 56);
            this.btn_Save.TabIndex = 6;
            this.btn_Save.Text = "保 存";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 186);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "地址：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 111);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 24);
            this.label6.TabIndex = 4;
            this.label6.Text = "联系电话：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(568, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "联系人：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "出版社名称：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(402, 348);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(410, 24);
            this.label11.TabIndex = 28;
            this.label11.Text = "可通过出版社名称、联系人进行查询";
            // 
            // Man_Press
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(169)))), ((int)(((byte)(154)))));
            this.ClientSize = new System.Drawing.Size(1228, 830);
            this.Controls.Add(this.btn_Del);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Man_Press";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "出版社信息管理";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Man_Press_FormClosed);
            this.Load += new System.EventHandler(this.Man_Press_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_Del;
        private GroupBox groupBox2;
        private ListView lv_Customer;
        private ColumnHeader no;
        private ColumnHeader name;
        private ColumnHeader contact;
        private ColumnHeader tel;
        private ColumnHeader country;
        private GroupBox groupBox1;
        private Label lbl_Note;
        private Label lbl_Status;
        private TextBox txt_ContactName;
        private TextBox txt_province;
        private TextBox txt_Telephone;
        private TextBox txt_PName;
        private Button btn_Cancel;
        private Button btn_Save;
        private Label label5;
        private Label label6;
        private Label label2;
        private Label label1;
        private Label label10;
        private TextBox txt_doorno;
        private Label label9;
        private TextBox txt_street;
        private Label label8;
        private TextBox txt_distinct;
        private Label label7;
        private TextBox txt_country;
        private Label label4;
        private TextBox txt_city;
        private Label label3;
        private ColumnHeader province;
        private ColumnHeader city;
        private ColumnHeader distinct;
        private ColumnHeader street;
        private ColumnHeader doorno;
        private Button btn_Search;
        private Label label11;
    }
}