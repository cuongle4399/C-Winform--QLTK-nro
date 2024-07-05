namespace Quản_lý_tài_khoản_nro
{
    partial class frmmenumob
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmmenumob));
            this.txtnoidungchat = new System.Windows.Forms.TextBox();
            this.btnsavenoidungchat = new System.Windows.Forms.Button();
            this.txtkhu = new System.Windows.Forms.TextBox();
            this.btnkhu = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtnoidungchat
            // 
            this.txtnoidungchat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnoidungchat.Location = new System.Drawing.Point(226, 86);
            this.txtnoidungchat.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtnoidungchat.Multiline = true;
            this.txtnoidungchat.Name = "txtnoidungchat";
            this.txtnoidungchat.Size = new System.Drawing.Size(182, 44);
            this.txtnoidungchat.TabIndex = 27;
            // 
            // btnsavenoidungchat
            // 
            this.btnsavenoidungchat.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsavenoidungchat.Location = new System.Drawing.Point(13, 86);
            this.btnsavenoidungchat.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnsavenoidungchat.Name = "btnsavenoidungchat";
            this.btnsavenoidungchat.Size = new System.Drawing.Size(187, 44);
            this.btnsavenoidungchat.TabIndex = 29;
            this.btnsavenoidungchat.Text = "Save chat";
            this.btnsavenoidungchat.UseVisualStyleBackColor = true;
            this.btnsavenoidungchat.Click += new System.EventHandler(this.btnsavenoidungchat_Click);
            // 
            // txtkhu
            // 
            this.txtkhu.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtkhu.Location = new System.Drawing.Point(226, 166);
            this.txtkhu.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtkhu.Multiline = true;
            this.txtkhu.Name = "txtkhu";
            this.txtkhu.Size = new System.Drawing.Size(78, 44);
            this.txtkhu.TabIndex = 30;
            this.txtkhu.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnkhu
            // 
            this.btnkhu.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnkhu.Location = new System.Drawing.Point(13, 166);
            this.btnkhu.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnkhu.Name = "btnkhu";
            this.btnkhu.Size = new System.Drawing.Size(187, 44);
            this.btnkhu.TabIndex = 31;
            this.btnkhu.Text = "Đổi khu";
            this.btnkhu.UseVisualStyleBackColor = true;
            this.btnkhu.Click += new System.EventHandler(this.btnkhu_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Quản_lý_tài_khoản_nro.Properties.Resources.xamhaha;
            this.pictureBox2.Location = new System.Drawing.Point(312, 166);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(96, 44);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 33;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Quản_lý_tài_khoản_nro.Properties.Resources.menumob;
            this.pictureBox1.Location = new System.Drawing.Point(74, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(273, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // frmmenumob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(428, 228);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnkhu);
            this.Controls.Add(this.txtkhu);
            this.Controls.Add(this.btnsavenoidungchat);
            this.Controls.Add(this.txtnoidungchat);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.MaximizeBox = false;
            this.Name = "frmmenumob";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Menu_mob";
            this.Load += new System.EventHandler(this.frmmenumob_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtnoidungchat;
        private System.Windows.Forms.Button btnsavenoidungchat;
        private System.Windows.Forms.TextBox txtkhu;
        private System.Windows.Forms.Button btnkhu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}