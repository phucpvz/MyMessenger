using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatClient.Forms
{
    public partial class FrmSignUp : MaterialForm
    {
        #region Properties
        private static FrmSignUp _instance;
        public static FrmSignUp Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new FrmSignUp();
                }
                return _instance;
            }
        }
        #endregion

        public FrmSignUp()
        {
            InitializeComponent();
            MaterialSkinManager.Instance.AddFormToManage(this);
            ActiveControl = pictureBox1;
            Program.LoadImagesExtension(dialog);       
        }

        private void ClearInfo()
        {
            lblError.Text = txtUsername.Text = txtPassword.Text = txtConfirmPass.Text =
                txtDisplayName.Text = dialog.FileName = "";
            pcbAvatar.Image = null;
        }

        private void btnChooseAvatar_Click(object sender, EventArgs e)
        {
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                pcbAvatar.Image = Image.FromFile(dialog.FileName);
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            if (string.IsNullOrEmpty(username))
            {
                lblError.Text = "Tên đăng nhập không được để trống!";
                return;
            }
            string password = txtPassword.Text;
            if (string.IsNullOrEmpty(password))
            {
                lblError.Text = "Mật khẩu không được để trống!";
                return;
            }
            string confirm = txtConfirmPass.Text;
            if (!confirm.Equals(password))
            {
                lblError.Text = "Xác nhận mật khẩu không đúng!";
                return;
            }
            string displayName = txtDisplayName.Text;
            if (string.IsNullOrEmpty(displayName))
            {
                lblError.Text = "Tên hiển thị không được để trống!";
                return;
            }

            if (pcbAvatar.Image == null)
            {
                lblError.Text = "Bạn chưa chọn ảnh đại diện!";
                return;
            }

            byte[] file_byte = Program.ImageToByteArray(pcbAvatar.Image);

            MyServiceReference.SignUpRequest rq = new MyServiceReference.SignUpRequest();
            rq.Body = new MyServiceReference.SignUpRequestBody
            {
                username = username,
                password = password,
                displayName = displayName,
                filePath = dialog.FileName,
                file_byte = file_byte
            };

            string notification;
            try
            {
                notification = Program.webservice.SignUp(rq).Body.SignUpResult;
            }
            catch (Exception ex)
            {
                notification = ex.Message;
            }
            
            if (notification == "OK")
            {
                ClearInfo();
                MaterialSnackBar SnackBarMessage = new MaterialSnackBar
                    ("Đăng ký tài khoản thành công!", "OK", true);
                SnackBarMessage.Show(this);
            }
            else
            {
                lblError.Text = notification;
            }
        }

        private void FrmSignUp_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible)
            {
                ClearInfo();
            }
        }

        private void FrmSignUp_FormClosed(object sender, FormClosedEventArgs e)
        {
            txtPassword.Clear();
            txtConfirmPass.Clear();
        }
    }
}
