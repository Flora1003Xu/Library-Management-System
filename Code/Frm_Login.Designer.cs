namespace _1110login_reg
{
    partial class Frm_Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Login));
            this.login_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.username_txt = new System.Windows.Forms.TextBox();
            this.password_txt = new System.Windows.Forms.TextBox();
            this.rbt_reader = new System.Windows.Forms.RadioButton();
            this.rbt_manager = new System.Windows.Forms.RadioButton();
            this.lbl_type = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // login_button
            // 
            this.login_button.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.login_button.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.login_button.ForeColor = System.Drawing.Color.Black;
            this.login_button.Location = new System.Drawing.Point(844, 570);
            this.login_button.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(190, 58);
            this.login_button.TabIndex = 0;
            this.login_button.Text = "登录";
            this.login_button.UseVisualStyleBackColor = false;
            this.login_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(678, 270);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "用户名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(678, 372);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "密码：";
            // 
            // username_txt
            // 
            this.username_txt.Location = new System.Drawing.Point(844, 264);
            this.username_txt.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.username_txt.Name = "username_txt";
            this.username_txt.Size = new System.Drawing.Size(324, 38);
            this.username_txt.TabIndex = 3;
            // 
            // password_txt
            // 
            this.password_txt.Location = new System.Drawing.Point(844, 366);
            this.password_txt.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.password_txt.Name = "password_txt";
            this.password_txt.PasswordChar = '*';
            this.password_txt.Size = new System.Drawing.Size(324, 38);
            this.password_txt.TabIndex = 4;
            // 
            // rbt_reader
            // 
            this.rbt_reader.AutoSize = true;
            this.rbt_reader.BackColor = System.Drawing.Color.Transparent;
            this.rbt_reader.Checked = true;
            this.rbt_reader.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbt_reader.Location = new System.Drawing.Point(844, 464);
            this.rbt_reader.Name = "rbt_reader";
            this.rbt_reader.Size = new System.Drawing.Size(91, 28);
            this.rbt_reader.TabIndex = 6;
            this.rbt_reader.TabStop = true;
            this.rbt_reader.Text = "读者";
            this.rbt_reader.UseVisualStyleBackColor = false;
            this.rbt_reader.CheckedChanged += new System.EventHandler(this.rbt_reader_CheckedChanged);
            // 
            // rbt_manager
            // 
            this.rbt_manager.AutoSize = true;
            this.rbt_manager.BackColor = System.Drawing.Color.Transparent;
            this.rbt_manager.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbt_manager.Location = new System.Drawing.Point(969, 464);
            this.rbt_manager.Name = "rbt_manager";
            this.rbt_manager.Size = new System.Drawing.Size(116, 28);
            this.rbt_manager.TabIndex = 7;
            this.rbt_manager.Text = "管理员";
            this.rbt_manager.UseVisualStyleBackColor = false;
            this.rbt_manager.CheckedChanged += new System.EventHandler(this.rbt_manager_CheckedChanged);
            // 
            // lbl_type
            // 
            this.lbl_type.AutoSize = true;
            this.lbl_type.BackColor = System.Drawing.Color.Transparent;
            this.lbl_type.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_type.Location = new System.Drawing.Point(678, 464);
            this.lbl_type.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_type.Name = "lbl_type";
            this.lbl_type.Size = new System.Drawing.Size(85, 24);
            this.lbl_type.TabIndex = 8;
            this.lbl_type.Text = "身份：";
            // 
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1214, 729);
            this.Controls.Add(this.lbl_type);
            this.Controls.Add(this.rbt_manager);
            this.Controls.Add(this.rbt_reader);
            this.Controls.Add(this.password_txt);
            this.Controls.Add(this.username_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.login_button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "图书管理系统";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Login_FormClosing);
            this.Load += new System.EventHandler(this.Frm_Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button login_button;
        private Label label1;
        private Label label2;
        private TextBox username_txt;
        private TextBox password_txt;
        private Button reg_button;
        private RadioButton rbt_reader;
        private RadioButton rbt_manager;
        private Label lbl_type;
    }
}