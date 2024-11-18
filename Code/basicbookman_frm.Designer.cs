namespace _1110login_reg
{
    partial class basicbookman_frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(basicbookman_frm));
            this.btn_Del = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lv_basicBook = new System.Windows.Forms.ListView();
            this.no = new System.Windows.Forms.ColumnHeader();
            this.BName = new System.Windows.Forms.ColumnHeader();
            this.PName = new System.Windows.Forms.ColumnHeader();
            this.BAuthor = new System.Windows.Forms.ColumnHeader();
            this.PubDate = new System.Windows.Forms.ColumnHeader();
            this.price = new System.Windows.Forms.ColumnHeader();
            this.storage = new System.Windows.Forms.ColumnHeader();
            this.storNow = new System.Windows.Forms.ColumnHeader();
            this.version = new System.Windows.Forms.ColumnHeader();
            this.intro = new System.Windows.Forms.ColumnHeader();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.txt_intro = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.num_storage = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.num_version = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.num_price = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.dp_pubtime = new System.Windows.Forms.DateTimePicker();
            this.txt_author = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbox_press = new System.Windows.Forms.ComboBox();
            this.lbl_Note = new System.Windows.Forms.Label();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.txt_bookname = new System.Windows.Forms.TextBox();
            this.txt_ISBN = new System.Windows.Forms.TextBox();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_storage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_version)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_price)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Del
            // 
            this.btn_Del.Location = new System.Drawing.Point(239, 399);
            this.btn_Del.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Del.Name = "btn_Del";
            this.btn_Del.Size = new System.Drawing.Size(117, 42);
            this.btn_Del.TabIndex = 22;
            this.btn_Del.Text = "删 除";
            this.btn_Del.UseVisualStyleBackColor = true;
            this.btn_Del.Click += new System.EventHandler(this.btn_Del_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lv_basicBook);
            this.groupBox2.Location = new System.Drawing.Point(15, 408);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(1197, 416);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "图书基本信息列表         ";
            // 
            // lv_basicBook
            // 
            this.lv_basicBook.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.no,
            this.BName,
            this.PName,
            this.BAuthor,
            this.PubDate,
            this.price,
            this.storage,
            this.storNow,
            this.version,
            this.intro});
            this.lv_basicBook.FullRowSelect = true;
            this.lv_basicBook.GridLines = true;
            this.lv_basicBook.Location = new System.Drawing.Point(25, 40);
            this.lv_basicBook.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lv_basicBook.MultiSelect = false;
            this.lv_basicBook.Name = "lv_basicBook";
            this.lv_basicBook.Size = new System.Drawing.Size(1144, 356);
            this.lv_basicBook.TabIndex = 0;
            this.lv_basicBook.UseCompatibleStateImageBehavior = false;
            this.lv_basicBook.View = System.Windows.Forms.View.Details;
            this.lv_basicBook.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lv_basicBook_ItemSelectionChanged);
            // 
            // no
            // 
            this.no.Text = "ISBN";
            this.no.Width = 300;
            // 
            // BName
            // 
            this.BName.DisplayIndex = 2;
            this.BName.Text = "书名";
            this.BName.Width = 150;
            // 
            // PName
            // 
            this.PName.DisplayIndex = 1;
            this.PName.Text = "出版社名称";
            this.PName.Width = 250;
            // 
            // BAuthor
            // 
            this.BAuthor.Text = "作者";
            this.BAuthor.Width = 80;
            // 
            // PubDate
            // 
            this.PubDate.Text = "出版日期";
            this.PubDate.Width = 250;
            // 
            // price
            // 
            this.price.Text = "单价";
            this.price.Width = 100;
            // 
            // storage
            // 
            this.storage.Text = "库存";
            this.storage.Width = 100;
            // 
            // storNow
            // 
            this.storNow.Text = "现存数量";
            this.storNow.Width = 150;
            // 
            // version
            // 
            this.version.Text = "版次";
            this.version.Width = 100;
            // 
            // intro
            // 
            this.intro.Text = "简介";
            this.intro.Width = 120;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btn_Search);
            this.groupBox1.Controls.Add(this.txt_intro);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.num_storage);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.num_version);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.num_price);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dp_pubtime);
            this.groupBox1.Controls.Add(this.txt_author);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.cbox_press);
            this.groupBox1.Controls.Add(this.lbl_Note);
            this.groupBox1.Controls.Add(this.lbl_Status);
            this.groupBox1.Controls.Add(this.txt_bookname);
            this.groupBox1.Controls.Add(this.txt_ISBN);
            this.groupBox1.Controls.Add(this.btn_Cancel);
            this.groupBox1.Controls.Add(this.btn_Save);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(15, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(1197, 382);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "编辑图书基本信息 状态：        ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(353, 301);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(487, 24);
            this.label9.TabIndex = 40;
            this.label9.Text = "可通过ISBN、出版社、书名、作者查询书目";
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(262, 242);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(154, 56);
            this.btn_Search.TabIndex = 39;
            this.btn_Search.Text = "查 询";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // txt_intro
            // 
            this.txt_intro.Location = new System.Drawing.Point(968, 189);
            this.txt_intro.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_intro.Name = "txt_intro";
            this.txt_intro.Size = new System.Drawing.Size(201, 35);
            this.txt_intro.TabIndex = 38;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(835, 191);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 24);
            this.label8.TabIndex = 37;
            this.label8.Text = "简介：";
            // 
            // num_storage
            // 
            this.num_storage.Location = new System.Drawing.Point(968, 112);
            this.num_storage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.num_storage.Name = "num_storage";
            this.num_storage.Size = new System.Drawing.Size(201, 35);
            this.num_storage.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(835, 111);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 24);
            this.label7.TabIndex = 35;
            this.label7.Text = "数量：";
            // 
            // num_version
            // 
            this.num_version.Location = new System.Drawing.Point(968, 43);
            this.num_version.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.num_version.Name = "num_version";
            this.num_version.Size = new System.Drawing.Size(201, 35);
            this.num_version.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(835, 42);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 24);
            this.label4.TabIndex = 33;
            this.label4.Text = "版次：";
            // 
            // num_price
            // 
            this.num_price.Location = new System.Drawing.Point(577, 185);
            this.num_price.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.num_price.Name = "num_price";
            this.num_price.Size = new System.Drawing.Size(201, 35);
            this.num_price.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(443, 187);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 24);
            this.label3.TabIndex = 31;
            this.label3.Text = "单价：";
            // 
            // dp_pubtime
            // 
            this.dp_pubtime.Location = new System.Drawing.Point(176, 187);
            this.dp_pubtime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dp_pubtime.Name = "dp_pubtime";
            this.dp_pubtime.Size = new System.Drawing.Size(208, 35);
            this.dp_pubtime.TabIndex = 30;
            // 
            // txt_author
            // 
            this.txt_author.Location = new System.Drawing.Point(577, 111);
            this.txt_author.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_author.Name = "txt_author";
            this.txt_author.Size = new System.Drawing.Size(201, 35);
            this.txt_author.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(443, 114);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 24);
            this.label11.TabIndex = 28;
            this.label11.Text = "作者：";
            // 
            // cbox_press
            // 
            this.cbox_press.FormattingEnabled = true;
            this.cbox_press.Location = new System.Drawing.Point(577, 43);
            this.cbox_press.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbox_press.Name = "cbox_press";
            this.cbox_press.Size = new System.Drawing.Size(201, 32);
            this.cbox_press.TabIndex = 27;
            // 
            // lbl_Note
            // 
            this.lbl_Note.AutoSize = true;
            this.lbl_Note.Location = new System.Drawing.Point(461, 343);
            this.lbl_Note.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Note.Name = "lbl_Note";
            this.lbl_Note.Size = new System.Drawing.Size(0, 24);
            this.lbl_Note.TabIndex = 15;
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Location = new System.Drawing.Point(283, 0);
            this.lbl_Status.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(60, 24);
            this.lbl_Status.TabIndex = 14;
            this.lbl_Status.Text = "添加";
            // 
            // txt_bookname
            // 
            this.txt_bookname.Location = new System.Drawing.Point(176, 111);
            this.txt_bookname.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_bookname.Name = "txt_bookname";
            this.txt_bookname.Size = new System.Drawing.Size(208, 35);
            this.txt_bookname.TabIndex = 9;
            // 
            // txt_ISBN
            // 
            this.txt_ISBN.Location = new System.Drawing.Point(176, 44);
            this.txt_ISBN.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_ISBN.Name = "txt_ISBN";
            this.txt_ISBN.Size = new System.Drawing.Size(208, 35);
            this.txt_ISBN.TabIndex = 8;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(723, 242);
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
            this.btn_Save.Location = new System.Drawing.Point(495, 242);
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
            this.label5.Location = new System.Drawing.Point(46, 187);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "出版日期：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 112);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 24);
            this.label6.TabIndex = 4;
            this.label6.Text = "书名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(443, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "出版社：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "ISBN：";
            // 
            // basicbookman_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(169)))), ((int)(((byte)(154)))));
            this.ClientSize = new System.Drawing.Size(1226, 841);
            this.Controls.Add(this.btn_Del);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "basicbookman_frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "basicbookman_frm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.basicbookman_frm_FormClosed);
            this.Load += new System.EventHandler(this.basicbookman_frm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_storage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_version)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_price)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_Del;
        private GroupBox groupBox2;
        private ListView lv_basicBook;
        private ColumnHeader no;
        private ColumnHeader PName;
        private ColumnHeader BName;
        private ColumnHeader BAuthor;
        private ColumnHeader PubDate;
        private ColumnHeader price;
        private ColumnHeader storage;
        private ColumnHeader storNow;
        private ColumnHeader version;
        private ColumnHeader intro;
        private GroupBox groupBox1;
        private Label lbl_Note;
        private Label lbl_Status;
        private TextBox txt_bookname;
        private TextBox txt_ISBN;
        private Button btn_Cancel;
        private Button btn_Save;
        private Label label5;
        private Label label6;
        private Label label2;
        private Label label1;
        private ComboBox cbox_press;
        private TextBox txt_intro;
        private Label label8;
        private NumericUpDown num_storage;
        private Label label7;
        private NumericUpDown num_version;
        private Label label4;
        private NumericUpDown num_price;
        private Label label3;
        private DateTimePicker dp_pubtime;
        private TextBox txt_author;
        private Label label11;
        private Button btn_Search;
        private Label label9;
    }
}