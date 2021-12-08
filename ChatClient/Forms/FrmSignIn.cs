using ChatClient.MyServiceReference;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Windows.Forms;

namespace ChatClient.Forms
{
    public partial class FrmSignIn : MaterialForm
    {
        #region Properties
        private static FrmSignIn _instance;
        public static FrmSignIn Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new FrmSignIn();
                }
                return _instance;
            }
        }

        public string Error
        {
            get => lblError.Text;
            set => lblError.Text = value;
        }

        private int loginID;
        public int LoginID { get => loginID; set => loginID = value; }

        private readonly MaterialSkinManager manager;
        private readonly Config defaultConfig;
        #endregion

        private FrmSignIn()
        {
            InitializeComponent();
            manager = MaterialSkinManager.Instance;
            manager.EnforceBackcolorOnAllComponents = true;
            manager.AddFormToManage(this);
            manager.Theme = MaterialSkinManager.Themes.LIGHT;
            manager.ColorScheme = new ColorScheme
                (Primary.Blue400, Primary.Blue500, Primary.Blue500, Accent.Pink200, TextShade.WHITE);

            defaultConfig = new Config()
            {
                ServerIPAddress = "192.168.1.5"
            };
            Config config = Program.DeserializeFromXML();
            if (config == null)
            {
                config = defaultConfig;
            }

            try
            {
                Program.Configure(config.ServerIPAddress);
            }
            catch
            {
                Program.Configure(defaultConfig.ServerIPAddress);
            }

            lblError.Text = "";
            txtServerIPAddress.Text = Program.serverIP;
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            if (string.IsNullOrEmpty(username))
            {
                lblError.Text = "Bạn chưa nhập tên người dùng!";
                return;
            }
            string password = txtPassword.Text;
            if (string.IsNullOrEmpty(password))
            {
                lblError.Text = "Bạn chưa nhập mật khẩu!";
                return;
            }

            MyServiceReference.SignInRequest rq = new MyServiceReference.SignInRequest();
            rq.Body = new MyServiceReference.SignInRequestBody
            {
                username = username,
                password = password
            };

            User user;
            try
            {
                user = Program.webservice.SignIn(rq).Body.SignInResult;
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
                //lblError.Text = "Không tìm thấy dịch vụ web!";
                return;
            }

            if (user == null)
            {
                lblError.Text = "Tên đăng nhập hoặc mật khẩu của bạn không chính xác!";
                return;
            }

            FrmSignIn.Instance.Hide();
            FrmMain.Instance.Sender = user;
            FrmMain.Instance.ShowDialog();
            FrmSignIn.Instance.Show();
        }

        private void llbSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmSignIn.Instance.Hide();
            FrmSignUp.Instance.ShowDialog();
            FrmSignIn.Instance.Show();
        }

        private void frmLogin_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible)
            {
                CenterToScreen();
                Error = "";
            }
        }

        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Fix bug
            txtPassword.Clear();
        }

        private void swShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.Password = !txtPassword.Password;
            txtPassword.Focus();
        }

        private void btnSaveChange_Click(object sender, EventArgs e)
        {
            string oldIP = Program.serverIP;
            string newIP = txtServerIPAddress.Text;
            try
            {
                Program.Configure(newIP);
                Config config = new Config()
                {
                    ServerIPAddress = newIP
                };
                Program.SerializeToXML(config);
            }
            catch (Exception ex)
            {
                MaterialDialog materialDialog = new MaterialDialog(this, "Lỗi",
                    ex.Message, "OK");
                materialDialog.ShowDialog(this);

                Program.Configure(oldIP);
                txtServerIPAddress.Text = oldIP;
            }
            btnSaveChange.Enabled = false;
        }

        private void swTheme_CheckedChanged(object sender, EventArgs e)
        {
            if (swTheme.Checked)
            {
                manager.Theme = MaterialSkinManager.Themes.DARK;
            }
            else
            {
                manager.Theme = MaterialSkinManager.Themes.LIGHT;
            }
        }

        private void txtServerIPAddress_TextChanged(object sender, EventArgs e)
        {
            string serverIPAddress = txtServerIPAddress.Text;
            if (serverIPAddress != Program.serverIP)
            {
                btnSaveChange.Enabled = true;
            }
            else
            {
                btnSaveChange.Enabled = false;
            }
        }
    }


}
