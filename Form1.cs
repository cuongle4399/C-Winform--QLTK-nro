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
using static System.Windows.Forms.LinkLabel;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Diagnostics;
using System.Threading;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.InteropServices;

namespace Quản_lý_tài_khoản_nro
{
    public partial class frmQLTK : Form
    {
        public frmQLTK()
        {
            InitializeComponent();
        }
        public void ghifile(DataGridView gridView)
        {
            FileStream fileStream = new FileStream("Account.txt", FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(fileStream);
            for (int i = 0; i < gridView.Rows.Count - 1; i++)
            {
                for (int j = 0; j < gridView.Columns.Count; j++)
                {
                    writer.Write(gridView.Rows[i].Cells[j].Value + "|");
                }
                writer.WriteLine();
            }
            writer.Close();
            fileStream.Close();
        }
        public void docfile(DataGridView gridView)
        {
            FileStream fileStream = new FileStream("Account.txt", FileMode.Open, FileAccess.Read);
            StreamReader read = new StreamReader(fileStream);
            string noidung = read.ReadLine();
            string id, user, password, server;
            while (noidung != null)
            {
                string[] mang = noidung.Split('|');
                id = mang[0];
                user = mang[1];
                password = mang[2];
                server = mang[3];
                gridView.Rows.Add(id, user, password, server);
                noidung = read.ReadLine();
            }
            read.Close();
            fileStream.Close();
        }
        public bool CanLogin()
        {
            if (!File.Exists("Dragon ball_240.exe"))
            {
                MessageBox.Show("Không Tìm Thấy File Game", "Lỗi Đăng Nhập", MessageBoxButtons.OK);
                return false;
            }

            if (File.Exists("Log"))
            {
                DialogResult result = MessageBox.Show("Đăng nhập lần đầu tiên", "Load dữ liệu", MessageBoxButtons.RetryCancel);
                if (result == DialogResult.Retry)
                {
                    File.Delete("Log");
                    return true;
                }
                return false;
            }

            return true;
        }
        public void Login(int index)
        {
            TextWriter textWriter = new StreamWriter("Log");
            for (int i = 0; i < 4; i++)
            {
                textWriter.Write(dataGridView1.Rows[index].Cells[i].Value.ToString() + "|");
            }
            textWriter.Close();
            Process.Start("Dragon ball_240.exe");
        }
        public bool checkadd()
        {
            if (string.IsNullOrEmpty(lblacount.Text))
            {
                MessageBox.Show("Bạn chưa nhập tài khoản", "Lỗi thêm tài khoản", MessageBoxButtons.OK);
                lblacount.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtpassword.Text))
            {
                MessageBox.Show("Bạn chưa nhập Mật khẩu", "Lỗi thêm mật khẩu", MessageBoxButtons.OK);
                txtpassword.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(cbserver.Text))
            {
                MessageBox.Show("Bạn chọn máy chủ", "Lỗi thêm server", MessageBoxButtons.OK);
                cbserver.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }


        private void frmQLTK_Load(object sender, EventArgs e)
        {
            docfile(dataGridView1);
            string[] size = File.ReadAllText("Size.txt").Split('x');
            txtW.Text = size[0];
            txtH.Text = size[1];


        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (checkadd())
            {

                dataGridView1.Rows.Add(new object[]
                {
                    "",
                    txtaccount.Text,
                    txtpassword.Text,
                    cbserver.Text
                });
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    if (dataGridView1.Rows[i].Cells[3].Value.ToString() == "Super 1")
                    {
                        dataGridView1.Rows[i].Cells[3].Value = 16;
                    }
                    else if (dataGridView1.Rows[i].Cells[3].Value.ToString() == "Super 2")
                    {
                        dataGridView1.Rows[i].Cells[3].Value = 17;
                    }
                    else if (dataGridView1.Rows[i].Cells[3].Value.ToString() == "Liên server")
                    {
                        dataGridView1.Rows[i].Cells[3].Value = 13;
                    }
                }

            }
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                // Cập nhật giá trị của cột tự động gán
                dataGridView1.Rows[i].Cells[0].Value = i;
            }
            ghifile(dataGridView1);
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value = txtaccount.Text;
            dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[2].Value = txtpassword.Text;
            dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[3].Value = cbserver.Text;
                if (dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[3].Value.ToString() == "Super 1")
                {
                    dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[3].Value = 16;
                }
                else if (dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[3].Value.ToString() == "Super 2")
                {
                    dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[3].Value = 17;
                }
                else if (dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[3].Value.ToString() == "Liên server")
                {
                    dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[3].Value = 13;
                 }

        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count >= 0)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentCell.RowIndex);//xóa dòng hiển thị trên datagridview
                int x = dataGridView1.CurrentCell.RowIndex;// index của dòng vừa bị xóa
                ghifile(dataGridView1);
               
            }
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                // Cập nhật giá trị của cột tự động gán
                dataGridView1.Rows[i].Cells[0].Value = i;
            }


        }


        private void cbhien_CheckedChanged(object sender, EventArgs e)
        {
            if (cbhien.Checked)
            {
                txtpassword.PasswordChar = '\0';
            }
            if (cbhien.Checked == false)
            {
                txtpassword.PasswordChar = '*';
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtaccount.Text= dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value.ToString()  ;
            txtpassword.Text= dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[2].Value.ToString() ;
            cbserver.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[3].Value.ToString()  ;
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (CanLogin())
            {
                Login(dataGridView1.CurrentRow.Index);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void cbserver_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        public void loginall()
        {
                for(int i = 0; i<dataGridView1.Rows.Count-1; i++)
                {
                    Login(i);
                    while (File.Exists("log"))
                    {
                        Thread.Sleep(2000);
                    }
                }

        }
        private void btnloginall_Click(object sender, EventArgs e)
        {
           new Thread(new ThreadStart(loginall)).Start();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnupdatesize_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtW.Text))
            {
                MessageBox.Show("Chưa nhập chiều ngang", "Lỗi Nhập Size", MessageBoxButtons.OK); txtW.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtH.Text))
            {
                MessageBox.Show("Chưa nhập chiều rộng", "Lỗi Nhập Size" ,MessageBoxButtons.OK);
                txtH.Focus();
            }
            else
            {
                MessageBox.Show("Nhập Size Thành Công", "Thông Báo", MessageBoxButtons.OK);
                File.WriteAllText("Size.txt", txtW.Text + "x" + txtH.Text);
            }
        }

        private void btncloseall_Click(object sender, EventArgs e)
        {
            {
                System.Diagnostics.Process process = System.Diagnostics.Process.GetProcessesByName("Dragon ball_240")[0];
                process.Kill();
            }
        }

        private void btnsavechat_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtnoidungchat.Text))
            {
                MessageBox.Show("Nhập nội dung chat đi", "lỗi nhập", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Vào game bật auto sủa là ok", "Lưu thành công", MessageBoxButtons.OK);
                File.WriteAllText("autochat.txt",txtnoidungchat.Text);
            }
        }

        private void grbsize_Enter(object sender, EventArgs e)
        {

        }

        private void frmQLTK_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F1)
            {
                btnlogin.PerformClick();
            }
        }
    }
}
