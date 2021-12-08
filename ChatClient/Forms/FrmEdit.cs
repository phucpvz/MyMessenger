using ChatClient.MyServiceReference;
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
    public partial class FrmEdit : MaterialForm
    {
        #region Properties
        private static FrmEdit _instance;
        public static FrmEdit Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new FrmEdit();
                }
                return _instance;
            }
        }

        private User currentUser;
        public User CurrentUser
        {
            get => currentUser;
            set
            {
                currentUser = value;
                if (currentUser != null)
                {
                    txtUsername.Text = currentUser.Username;
                    txtDisplayName.Text = currentUser.DisplayName;
                    pcbAvatar.Image = Program.GetAvatar(currentUser.Avatar);
                }
                else
                {
                    txtUsername.Text = "";
                    txtDisplayName.Text = "";
                    pcbAvatar.Image = null;
                }
            }
        }
        #endregion

        public FrmEdit()
        {
            InitializeComponent();
            lblError.Text = "";
            MaterialSkinManager.Instance.AddFormToManage(this);
            ActiveControl = pictureBox1;
            Program.LoadImagesExtension(dialog);       
        }

        private void ClearInfo()
        {
            lblError.Text = txtUsername.Text = txtOldPassword.Text = txtNewPassword.Text 
                = txtConfirmPass.Text = txtDisplayName.Text = dialog.FileName = "";
            pcbAvatar.Image = null;
            swChangePassword.Checked = false;
        }

        private void btnChooseAvatar_Click(object sender, EventArgs e)
        {
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                pcbAvatar.Image = Image.FromFile(dialog.FileName);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string displayName = txtDisplayName.Text;
            if (string.IsNullOrEmpty(displayName))
            {
                lblError.Text = "Tên hiển thị không được để trống!";
                return;
            }

            string oldPassword = "";
            string newPassword = "";
            if (swChangePassword.Checked)
            {
                oldPassword = txtOldPassword.Text;
                if (string.IsNullOrEmpty(oldPassword))
                {
                    lblError.Text = "Vui lòng nhập mật khẩu cũ!";
                    return;
                }
                newPassword = txtNewPassword.Text;
                if (string.IsNullOrEmpty(newPassword))
                {
                    lblError.Text = "Vui lòng nhập mật khẩu mới!";
                    return;
                }
                string confirm = txtConfirmPass.Text;
                if (!confirm.Equals(newPassword))
                {
                    lblError.Text = "Xác nhận mật khẩu mới không đúng!";
                    return;
                }
            }

            string imageFilePath = "";
            byte[] file_byte = null;
            if (!string.IsNullOrEmpty(dialog.FileName))
            {
                imageFilePath = dialog.FileName;
                dialog.FileName = "";
                if (pcbAvatar.Image != null)
                {
                    file_byte = Program.ImageToByteArray(pcbAvatar.Image);
                }
            }

            MyServiceReference.UpdateInformationRequest rq 
                = new MyServiceReference.UpdateInformationRequest();
            rq.Body = new MyServiceReference.UpdateInformationRequestBody
            {
                username = username,
                displayName = displayName,
                oldPassword = oldPassword,
                newPassword = newPassword,
                filePath = imageFilePath,
                file_byte = file_byte
            };

            string notification;
            try
            {
                notification = Program.webservice.UpdateInformation(rq).Body.UpdateInformationResult;
            }
            catch (Exception ex)
            {
                notification = ex.Message;
            }
            
            if (notification == "OK")
            {
                lblError.Text = "";
                MyServiceReference.GetUserRequest rq2 = new MyServiceReference.GetUserRequest();
                rq2.Body = new MyServiceReference.GetUserRequestBody(username);
                User user;
                try
                {
                    user = Program.webservice.GetUser(rq2).Body.GetUserResult;
                }
                catch (Exception ex)
                {
                    lblError.Text = ex.Message;
                    //lblError.Text = "Không tìm thấy dịch vụ web!";
                    return;
                }
                FrmMain.Instance.Sender = CurrentUser = user;

                MaterialSnackBar SnackBarMessage = new MaterialSnackBar
                    ("Đã thay đổi thông tin cá nhân của bạn!", "OK", true);
                SnackBarMessage.Show(this);
            }
            else
            {
                lblError.Text = notification;
            }
        }

        private void FrmEdit_VisibleChanged(object sender, EventArgs e)
        {
            if (!Visible)
            {
                ClearInfo();
            }
        }

        private void FrmEdit_FormClosed(object sender, FormClosedEventArgs e)
        {
            txtOldPassword.Clear();
            txtNewPassword.Clear();
            txtConfirmPass.Clear();
        }

        private void swChangePassword_CheckedChanged(object sender, EventArgs e)
        {
            pnlChangePassword.Visible = swChangePassword.Checked;
        }
    }
}
