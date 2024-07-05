using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Quản_lý_tài_khoản_nro
{
    public partial class frmmenumob : Form
    {
        public frmmenumob()
        {
            InitializeComponent();
        }

        private void frmmenumob_Load(object sender, EventArgs e)
        {
            string noidung = File.ReadAllText("autochat.txt");
            txtnoidungchat.Text = noidung;
        }
        
        private void btnsavenoidungchat_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtnoidungchat.Text))
            {
                MessageBox.Show("Nhập nội dung chat đi", "lỗi nhập", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Vào game bật auto sủa là ok", "Lưu thành công", MessageBoxButtons.OK);
                File.WriteAllText("autochat.txt", txtnoidungchat.Text);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public void ghifile(string noidung)
        {
            FileStream fileStream = new FileStream("khu.txt", FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(fileStream);
            writer.Write(noidung);
            writer.Close();
            fileStream.Close();
        }

        private void btnkhu_Click(object sender, EventArgs e)
        {
            
            if(string.IsNullOrEmpty(txtkhu.Text))
            {
                MessageBox.Show("Nhập khu cần đổi đi chứ ?", "Thông báo", MessageBoxButtons.OK);
            }
            else {
                ghifile(txtkhu.Text);
                MessageBox.Show("Đã đổi khu thành công");
                
            }
        }
    }
}
