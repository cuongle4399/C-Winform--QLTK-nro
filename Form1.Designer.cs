namespace Quản_lý_tài_khoản_nro
{
    partial class frmQLTK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLTK));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.account = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.server = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblacount = new System.Windows.Forms.Label();
            this.lblpassword = new System.Windows.Forms.Label();
            this.lblserver = new System.Windows.Forms.Label();
            this.txtaccount = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.cbserver = new System.Windows.Forms.ComboBox();
            this.cbhien = new System.Windows.Forms.CheckBox();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnlogin = new System.Windows.Forms.Button();
            this.btncloseall = new System.Windows.Forms.Button();
            this.btnloginall = new System.Windows.Forms.Button();
            this.grbsize = new System.Windows.Forms.GroupBox();
            this.btnupdatesize = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtH = new System.Windows.Forms.TextBox();
            this.txtW = new System.Windows.Forms.TextBox();
            this.btnsavechat = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtnoidungchat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grbsize.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.account,
            this.password,
            this.server});
            this.dataGridView1.Location = new System.Drawing.Point(14, 13);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(543, 509);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Width = 40;
            // 
            // account
            // 
            this.account.HeaderText = "Tài Khoản";
            this.account.MinimumWidth = 6;
            this.account.Name = "account";
            this.account.Width = 350;
            // 
            // password
            // 
            this.password.HeaderText = "Mật Khẩu";
            this.password.MinimumWidth = 6;
            this.password.Name = "password";
            this.password.Visible = false;
            this.password.Width = 125;
            // 
            // server
            // 
            this.server.HeaderText = "Server";
            this.server.MinimumWidth = 6;
            this.server.Name = "server";
            this.server.Width = 150;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Quản_lý_tài_khoản_nro.Properties.Resources.maychu;
            this.pictureBox4.Location = new System.Drawing.Point(576, 191);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(38, 29);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Quản_lý_tài_khoản_nro.Properties.Resources.matkhau;
            this.pictureBox3.Location = new System.Drawing.Point(576, 142);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(38, 29);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Quản_lý_tài_khoản_nro.Properties.Resources.taikhoan;
            this.pictureBox2.Location = new System.Drawing.Point(576, 99);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 29);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Quản_lý_tài_khoản_nro.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(697, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(483, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblacount
            // 
            this.lblacount.Location = new System.Drawing.Point(623, 99);
            this.lblacount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblacount.Name = "lblacount";
            this.lblacount.Size = new System.Drawing.Size(101, 29);
            this.lblacount.TabIndex = 5;
            this.lblacount.Text = "Tài Khoản:";
            this.lblacount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblpassword
            // 
            this.lblpassword.Location = new System.Drawing.Point(623, 141);
            this.lblpassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(101, 29);
            this.lblpassword.TabIndex = 6;
            this.lblpassword.Text = "Mật Khẩu:";
            this.lblpassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblserver
            // 
            this.lblserver.Location = new System.Drawing.Point(623, 191);
            this.lblserver.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblserver.Name = "lblserver";
            this.lblserver.Size = new System.Drawing.Size(101, 29);
            this.lblserver.TabIndex = 7;
            this.lblserver.Text = "Server:";
            this.lblserver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtaccount
            // 
            this.txtaccount.Location = new System.Drawing.Point(749, 99);
            this.txtaccount.Multiline = true;
            this.txtaccount.Name = "txtaccount";
            this.txtaccount.Size = new System.Drawing.Size(459, 29);
            this.txtaccount.TabIndex = 8;
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(749, 142);
            this.txtpassword.Multiline = true;
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(382, 29);
            this.txtpassword.TabIndex = 9;
            // 
            // cbserver
            // 
            this.cbserver.FormattingEnabled = true;
            this.cbserver.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "Liên server",
            "Super 1",
            "Super 2"});
            this.cbserver.Location = new System.Drawing.Point(749, 191);
            this.cbserver.Name = "cbserver";
            this.cbserver.Size = new System.Drawing.Size(110, 28);
            this.cbserver.TabIndex = 10;
            this.cbserver.SelectedIndexChanged += new System.EventHandler(this.cbserver_SelectedIndexChanged);
            // 
            // cbhien
            // 
            this.cbhien.AutoSize = true;
            this.cbhien.Location = new System.Drawing.Point(1138, 144);
            this.cbhien.Name = "cbhien";
            this.cbhien.Size = new System.Drawing.Size(70, 24);
            this.cbhien.TabIndex = 11;
            this.cbhien.Text = "Hiện";
            this.cbhien.UseVisualStyleBackColor = true;
            this.cbhien.CheckedChanged += new System.EventHandler(this.cbhien_CheckedChanged);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(593, 237);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(122, 44);
            this.btnthem.TabIndex = 12;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(737, 237);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(122, 44);
            this.btnsua.TabIndex = 13;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(868, 237);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(122, 44);
            this.btnxoa.TabIndex = 14;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnlogin
            // 
            this.btnlogin.Location = new System.Drawing.Point(886, 191);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(122, 29);
            this.btnlogin.TabIndex = 16;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // btncloseall
            // 
            this.btncloseall.Location = new System.Drawing.Point(1167, 191);
            this.btncloseall.Name = "btncloseall";
            this.btncloseall.Size = new System.Drawing.Size(99, 29);
            this.btncloseall.TabIndex = 18;
            this.btncloseall.Text = "Close";
            this.btncloseall.UseVisualStyleBackColor = true;
            this.btncloseall.Click += new System.EventHandler(this.btncloseall_Click);
            // 
            // btnloginall
            // 
            this.btnloginall.Location = new System.Drawing.Point(1023, 191);
            this.btnloginall.Name = "btnloginall";
            this.btnloginall.Size = new System.Drawing.Size(122, 29);
            this.btnloginall.TabIndex = 17;
            this.btnloginall.Text = "Login all";
            this.btnloginall.UseVisualStyleBackColor = true;
            this.btnloginall.Click += new System.EventHandler(this.btnloginall_Click);
            // 
            // grbsize
            // 
            this.grbsize.Controls.Add(this.btnupdatesize);
            this.grbsize.Controls.Add(this.label1);
            this.grbsize.Controls.Add(this.txtH);
            this.grbsize.Controls.Add(this.txtW);
            this.grbsize.Location = new System.Drawing.Point(593, 421);
            this.grbsize.Name = "grbsize";
            this.grbsize.Size = new System.Drawing.Size(673, 101);
            this.grbsize.TabIndex = 20;
            this.grbsize.TabStop = false;
            this.grbsize.Text = "Kích Thước Game";
            this.grbsize.Enter += new System.EventHandler(this.grbsize_Enter);
            // 
            // btnupdatesize
            // 
            this.btnupdatesize.Location = new System.Drawing.Point(416, 38);
            this.btnupdatesize.Name = "btnupdatesize";
            this.btnupdatesize.Size = new System.Drawing.Size(187, 54);
            this.btnupdatesize.TabIndex = 3;
            this.btnupdatesize.Text = "Update size";
            this.btnupdatesize.UseVisualStyleBackColor = true;
            this.btnupdatesize.Click += new System.EventHandler(this.btnupdatesize_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(179, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "x";
            // 
            // txtH
            // 
            this.txtH.Location = new System.Drawing.Point(223, 52);
            this.txtH.Name = "txtH";
            this.txtH.Size = new System.Drawing.Size(110, 27);
            this.txtH.TabIndex = 1;
            // 
            // txtW
            // 
            this.txtW.Location = new System.Drawing.Point(52, 52);
            this.txtW.Name = "txtW";
            this.txtW.Size = new System.Drawing.Size(110, 27);
            this.txtW.TabIndex = 0;
            this.txtW.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnsavechat
            // 
            this.btnsavechat.Location = new System.Drawing.Point(1009, 237);
            this.btnsavechat.Name = "btnsavechat";
            this.btnsavechat.Size = new System.Drawing.Size(122, 44);
            this.btnsavechat.TabIndex = 21;
            this.btnsavechat.Text = "Save chat";
            this.btnsavechat.UseVisualStyleBackColor = true;
            this.btnsavechat.Click += new System.EventHandler(this.btnsavechat_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1144, 237);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 44);
            this.button2.TabIndex = 22;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txtnoidungchat
            // 
            this.txtnoidungchat.Location = new System.Drawing.Point(737, 299);
            this.txtnoidungchat.Multiline = true;
            this.txtnoidungchat.Name = "txtnoidungchat";
            this.txtnoidungchat.Size = new System.Drawing.Size(529, 40);
            this.txtnoidungchat.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(589, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 37);
            this.label2.TabIndex = 26;
            this.label2.Text = "nội dung chat";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmQLTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1301, 535);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtnoidungchat);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnsavechat);
            this.Controls.Add(this.grbsize);
            this.Controls.Add(this.btncloseall);
            this.Controls.Add(this.btnloginall);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.cbhien);
            this.Controls.Add(this.cbserver);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtaccount);
            this.Controls.Add(this.lblserver);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.lblacount);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmQLTK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QLTK-Cường Lê";
            this.Load += new System.EventHandler(this.frmQLTK_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmQLTK_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grbsize.ResumeLayout(false);
            this.grbsize.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lblacount;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.Label lblserver;
        private System.Windows.Forms.TextBox txtaccount;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.ComboBox cbserver;
        private System.Windows.Forms.CheckBox cbhien;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Button btncloseall;
        private System.Windows.Forms.Button btnloginall;
        private System.Windows.Forms.GroupBox grbsize;
        private System.Windows.Forms.Button btnupdatesize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtH;
        private System.Windows.Forms.TextBox txtW;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn account;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private System.Windows.Forms.DataGridViewTextBoxColumn server;
        private System.Windows.Forms.Button btnsavechat;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtnoidungchat;
        private System.Windows.Forms.Label label2;
    }
}

