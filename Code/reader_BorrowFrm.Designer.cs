namespace _1110login_reg
{
    partial class reader_BorrowFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(reader_BorrowFrm));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lv_Book = new System.Windows.Forms.ListView();
            this.ISBN = new System.Windows.Forms.ColumnHeader();
            this.bookName = new System.Windows.Forms.ColumnHeader();
            this.author = new System.Windows.Forms.ColumnHeader();
            this.press = new System.Windows.Forms.ColumnHeader();
            this.version = new System.Windows.Forms.ColumnHeader();
            this.storage = new System.Windows.Forms.ColumnHeader();
            this.storNow = new System.Windows.Forms.ColumnHeader();
            this.intro = new System.Windows.Forms.ColumnHeader();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Press = new System.Windows.Forms.TextBox();
            this.lbl_Note = new System.Windows.Forms.Label();
            this.txt_BName = new System.Windows.Forms.TextBox();
            this.txt_Author = new System.Windows.Forms.TextBox();
            this.txt_ISBN = new System.Windows.Forms.TextBox();
            this.btn_Borrow = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lv_Book);
            this.groupBox2.Location = new System.Drawing.Point(14, 297);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(1197, 416);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "图书馆藏信息列表";
            // 
            // lv_Book
            // 
            this.lv_Book.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ISBN,
            this.bookName,
            this.author,
            this.press,
            this.version,
            this.storage,
            this.storNow,
            this.intro});
            this.lv_Book.FullRowSelect = true;
            this.lv_Book.GridLines = true;
            this.lv_Book.Location = new System.Drawing.Point(24, 39);
            this.lv_Book.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lv_Book.MultiSelect = false;
            this.lv_Book.Name = "lv_Book";
            this.lv_Book.Size = new System.Drawing.Size(1144, 356);
            this.lv_Book.TabIndex = 0;
            this.lv_Book.UseCompatibleStateImageBehavior = false;
            this.lv_Book.View = System.Windows.Forms.View.Details;
            // 
            // ISBN
            // 
            this.ISBN.Text = "ISBN";
            this.ISBN.Width = 200;
            // 
            // bookName
            // 
            this.bookName.Text = "书名";
            this.bookName.Width = 200;
            // 
            // author
            // 
            this.author.Text = "作者";
            this.author.Width = 180;
            // 
            // press
            // 
            this.press.Text = "出版社名称";
            this.press.Width = 200;
            // 
            // version
            // 
            this.version.Text = "版次";
            this.version.Width = 100;
            // 
            // storage
            // 
            this.storage.Text = "总库存数";
            this.storage.Width = 150;
            // 
            // storNow
            // 
            this.storNow.Text = "可借数量";
            this.storNow.Width = 120;
            // 
            // intro
            // 
            this.intro.Text = "简介";
            this.intro.Width = 300;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_Press);
            this.groupBox1.Controls.Add(this.lbl_Note);
            this.groupBox1.Controls.Add(this.txt_BName);
            this.groupBox1.Controls.Add(this.txt_Author);
            this.groupBox1.Controls.Add(this.txt_ISBN);
            this.groupBox1.Controls.Add(this.btn_Borrow);
            this.groupBox1.Controls.Add(this.btn_Search);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(14, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(1197, 279);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "图书信息查询";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(368, 243);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(460, 24);
            this.label3.TabIndex = 20;
            this.label3.Text = "请点击选择下方列表以进行图书借阅操作";
            // 
            // txt_Press
            // 
            this.txt_Press.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Press.Location = new System.Drawing.Point(736, 115);
            this.txt_Press.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_Press.Name = "txt_Press";
            this.txt_Press.Size = new System.Drawing.Size(244, 38);
            this.txt_Press.TabIndex = 19;
            this.txt_Press.Tag = "";
            // 
            // lbl_Note
            // 
            this.lbl_Note.AutoSize = true;
            this.lbl_Note.Location = new System.Drawing.Point(463, 297);
            this.lbl_Note.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Note.Name = "lbl_Note";
            this.lbl_Note.Size = new System.Drawing.Size(0, 24);
            this.lbl_Note.TabIndex = 15;
            // 
            // txt_BName
            // 
            this.txt_BName.Location = new System.Drawing.Point(736, 46);
            this.txt_BName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_BName.Name = "txt_BName";
            this.txt_BName.Size = new System.Drawing.Size(244, 35);
            this.txt_BName.TabIndex = 11;
            // 
            // txt_Author
            // 
            this.txt_Author.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_Author.Location = new System.Drawing.Point(246, 114);
            this.txt_Author.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_Author.Name = "txt_Author";
            this.txt_Author.Size = new System.Drawing.Size(244, 35);
            this.txt_Author.TabIndex = 9;
            // 
            // txt_ISBN
            // 
            this.txt_ISBN.Location = new System.Drawing.Point(246, 47);
            this.txt_ISBN.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_ISBN.Name = "txt_ISBN";
            this.txt_ISBN.Size = new System.Drawing.Size(244, 35);
            this.txt_ISBN.TabIndex = 8;
            // 
            // btn_Borrow
            // 
            this.btn_Borrow.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Borrow.Location = new System.Drawing.Point(663, 178);
            this.btn_Borrow.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Borrow.Name = "btn_Borrow";
            this.btn_Borrow.Size = new System.Drawing.Size(154, 56);
            this.btn_Borrow.TabIndex = 7;
            this.btn_Borrow.Text = "借 阅";
            this.btn_Borrow.UseVisualStyleBackColor = true;
            this.btn_Borrow.Click += new System.EventHandler(this.btn_Borrow_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Search.Location = new System.Drawing.Point(375, 178);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(154, 56);
            this.btn_Search.TabIndex = 6;
            this.btn_Search.Text = "查 询";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(642, 117);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "出版社：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(93, 115);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 24);
            this.label6.TabIndex = 4;
            this.label6.Text = "作者：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(642, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "书名：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(93, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "ISBN：";
            // 
            // reader_BorrowFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(169)))), ((int)(((byte)(154)))));
            this.ClientSize = new System.Drawing.Size(1229, 729);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "reader_BorrowFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "借阅图书";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.reader_BorrowFrm_FormClosed);
            this.Load += new System.EventHandler(this.reader_BorrowFrm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox2;
        private ListView lv_Book;
        private ColumnHeader ISBN;
        private ColumnHeader bookName;
        private ColumnHeader author;
        private ColumnHeader press;
        private ColumnHeader storage;
        private ColumnHeader storNow;
        private ColumnHeader version;
        private ColumnHeader intro;
        private GroupBox groupBox1;
        private TextBox txt_Press;
        private Label lbl_Note;
        private TextBox txt_BName;
        private TextBox txt_Author;
        private TextBox txt_ISBN;
        private Button btn_Borrow;
        private Button btn_Search;
        private Label label5;
        private Label label6;
        private Label label2;
        private Label label1;
        private Label label3;
    }
}