
namespace ChatClient.Forms
{
    partial class FrmSignIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSignIn));
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.txtPassword = new MaterialSkin.Controls.MaterialTextBox();
            this.txtUsername = new MaterialSkin.Controls.MaterialTextBox();
            this.swShowPassword = new MaterialSkin.Controls.MaterialSwitch();
            this.lblError = new MaterialSkin.Controls.MaterialLabel();
            this.btnSignIn = new MaterialSkin.Controls.MaterialButton();
            this.llbSignUp = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tpLogin = new System.Windows.Forms.TabPage();
            this.tpConfiguration = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.swTheme = new MaterialSkin.Controls.MaterialSwitch();
            this.btnSaveChange = new MaterialSkin.Controls.MaterialButton();
            this.txtServerIPAddress = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.pnlContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.materialTabControl1.SuspendLayout();
            this.tpLogin.SuspendLayout();
            this.tpConfiguration.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContainer
            // 
            this.pnlContainer.BackColor = System.Drawing.Color.White;
            this.pnlContainer.Controls.Add(this.txtPassword);
            this.pnlContainer.Controls.Add(this.txtUsername);
            this.pnlContainer.Controls.Add(this.swShowPassword);
            this.pnlContainer.Controls.Add(this.lblError);
            this.pnlContainer.Controls.Add(this.btnSignIn);
            this.pnlContainer.Controls.Add(this.llbSignUp);
            this.pnlContainer.Controls.Add(this.pictureBox1);
            this.pnlContainer.Location = new System.Drawing.Point(4, 4);
            this.pnlContainer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(402, 566);
            this.pnlContainer.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Depth = 0;
            this.txtPassword.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPassword.Hint = "Mật khẩu";
            this.txtPassword.LeadingIcon = global::ChatClient.Properties.Resources.PinClipart_com_ship_clipart_black_and_1303682;
            this.txtPassword.Location = new System.Drawing.Point(55, 286);
            this.txtPassword.MaxLength = 50;
            this.txtPassword.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Password = true;
            this.txtPassword.Size = new System.Drawing.Size(268, 50);
            this.txtPassword.TabIndex = 42;
            this.txtPassword.Text = "";
            this.txtPassword.TrailingIcon = null;
            // 
            // txtUsername
            // 
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Depth = 0;
            this.txtUsername.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtUsername.Hint = "Tên người dùng";
            this.txtUsername.LeadingIcon = global::ChatClient.Properties.Resources.Sample_User_Icon;
            this.txtUsername.Location = new System.Drawing.Point(55, 218);
            this.txtUsername.MaxLength = 50;
            this.txtUsername.MouseState = MaterialSkin.MouseState.OUT;
            this.txtUsername.Multiline = false;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(268, 50);
            this.txtUsername.TabIndex = 41;
            this.txtUsername.Text = "";
            this.txtUsername.TrailingIcon = null;
            // 
            // swShowPassword
            // 
            this.swShowPassword.AutoSize = true;
            this.swShowPassword.Depth = 0;
            this.swShowPassword.Location = new System.Drawing.Point(140, 373);
            this.swShowPassword.Margin = new System.Windows.Forms.Padding(0);
            this.swShowPassword.MouseLocation = new System.Drawing.Point(-1, -1);
            this.swShowPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.swShowPassword.Name = "swShowPassword";
            this.swShowPassword.Ripple = true;
            this.swShowPassword.Size = new System.Drawing.Size(183, 37);
            this.swShowPassword.TabIndex = 3;
            this.swShowPassword.Text = "Hiển thị mật khẩu";
            this.swShowPassword.UseVisualStyleBackColor = true;
            this.swShowPassword.CheckedChanged += new System.EventHandler(this.swShowPassword_CheckedChanged);
            // 
            // lblError
            // 
            this.lblError.Depth = 0;
            this.lblError.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblError.HighEmphasis = true;
            this.lblError.Location = new System.Drawing.Point(28, 83);
            this.lblError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblError.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(340, 117);
            this.lblError.TabIndex = 0;
            this.lblError.Text = "Thông báo";
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblError.UseAccent = true;
            // 
            // btnSignIn
            // 
            this.btnSignIn.AccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(129)))));
            this.btnSignIn.AutoSize = false;
            this.btnSignIn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSignIn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSignIn.Depth = 0;
            this.btnSignIn.HighEmphasis = true;
            this.btnSignIn.Icon = null;
            this.btnSignIn.Location = new System.Drawing.Point(125, 497);
            this.btnSignIn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnSignIn.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.NoAccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnSignIn.Size = new System.Drawing.Size(124, 29);
            this.btnSignIn.TabIndex = 5;
            this.btnSignIn.Text = "Đăng nhập";
            this.btnSignIn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSignIn.UseAccentColor = true;
            this.btnSignIn.UseVisualStyleBackColor = true;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // llbSignUp
            // 
            this.llbSignUp.AutoSize = true;
            this.llbSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbSignUp.Location = new System.Drawing.Point(72, 452);
            this.llbSignUp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.llbSignUp.Name = "llbSignUp";
            this.llbSignUp.Size = new System.Drawing.Size(262, 17);
            this.llbSignUp.TabIndex = 4;
            this.llbSignUp.TabStop = true;
            this.llbSignUp.Text = "Bạn chưa có tài khoản? Đăng ký tại đây!";
            this.llbSignUp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbSignUp_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ChatClient.Properties.Resources.line_messenger_social_transparent_icon_1320192471848876306_512;
            this.pictureBox1.Location = new System.Drawing.Point(169, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tpLogin);
            this.materialTabControl1.Controls.Add(this.tpConfiguration);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(22, 106);
            this.materialTabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(419, 600);
            this.materialTabControl1.TabIndex = 1;
            // 
            // tpLogin
            // 
            this.tpLogin.Controls.Add(this.pnlContainer);
            this.tpLogin.Location = new System.Drawing.Point(4, 22);
            this.tpLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpLogin.Name = "tpLogin";
            this.tpLogin.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpLogin.Size = new System.Drawing.Size(411, 574);
            this.tpLogin.TabIndex = 0;
            this.tpLogin.Text = "Đăng nhập";
            this.tpLogin.UseVisualStyleBackColor = true;
            // 
            // tpConfiguration
            // 
            this.tpConfiguration.Controls.Add(this.panel1);
            this.tpConfiguration.Location = new System.Drawing.Point(4, 22);
            this.tpConfiguration.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpConfiguration.Name = "tpConfiguration";
            this.tpConfiguration.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpConfiguration.Size = new System.Drawing.Size(411, 574);
            this.tpConfiguration.TabIndex = 1;
            this.tpConfiguration.Text = "Cấu hình";
            this.tpConfiguration.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.swTheme);
            this.panel1.Controls.Add(this.btnSaveChange);
            this.panel1.Controls.Add(this.txtServerIPAddress);
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(401, 564);
            this.panel1.TabIndex = 0;
            // 
            // swTheme
            // 
            this.swTheme.AutoSize = true;
            this.swTheme.Depth = 0;
            this.swTheme.Location = new System.Drawing.Point(14, 160);
            this.swTheme.Margin = new System.Windows.Forms.Padding(0);
            this.swTheme.MouseLocation = new System.Drawing.Point(-1, -1);
            this.swTheme.MouseState = MaterialSkin.MouseState.HOVER;
            this.swTheme.Name = "swTheme";
            this.swTheme.Ripple = true;
            this.swTheme.Size = new System.Drawing.Size(147, 37);
            this.swTheme.TabIndex = 2;
            this.swTheme.Text = "Giao diện tối";
            this.swTheme.UseVisualStyleBackColor = true;
            this.swTheme.CheckedChanged += new System.EventHandler(this.swTheme_CheckedChanged);
            // 
            // btnSaveChange
            // 
            this.btnSaveChange.AccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(129)))));
            this.btnSaveChange.AutoSize = false;
            this.btnSaveChange.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSaveChange.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSaveChange.Depth = 0;
            this.btnSaveChange.Enabled = false;
            this.btnSaveChange.HighEmphasis = true;
            this.btnSaveChange.Icon = null;
            this.btnSaveChange.Location = new System.Drawing.Point(140, 95);
            this.btnSaveChange.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSaveChange.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSaveChange.Name = "btnSaveChange";
            this.btnSaveChange.NoAccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnSaveChange.Size = new System.Drawing.Size(104, 36);
            this.btnSaveChange.TabIndex = 1;
            this.btnSaveChange.Text = "Lưu thay đổi";
            this.btnSaveChange.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSaveChange.UseAccentColor = true;
            this.btnSaveChange.UseVisualStyleBackColor = true;
            this.btnSaveChange.Click += new System.EventHandler(this.btnSaveChange_Click);
            // 
            // txtServerIPAddress
            // 
            this.txtServerIPAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtServerIPAddress.Depth = 0;
            this.txtServerIPAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtServerIPAddress.Hint = "Địa chỉ IP Server / Tên miền";
            this.txtServerIPAddress.LeadingIcon = null;
            this.txtServerIPAddress.Location = new System.Drawing.Point(14, 20);
            this.txtServerIPAddress.MaxLength = 50;
            this.txtServerIPAddress.MouseState = MaterialSkin.MouseState.OUT;
            this.txtServerIPAddress.Multiline = false;
            this.txtServerIPAddress.Name = "txtServerIPAddress";
            this.txtServerIPAddress.Size = new System.Drawing.Size(367, 50);
            this.txtServerIPAddress.TabIndex = 0;
            this.txtServerIPAddress.Text = "192.168.1.5";
            this.txtServerIPAddress.TrailingIcon = null;
            this.txtServerIPAddress.TextChanged += new System.EventHandler(this.txtServerIPAddress_TextChanged);
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTabSelector1.Location = new System.Drawing.Point(22, 69);
            this.materialTabSelector1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(419, 33);
            this.materialTabSelector1.TabIndex = 2;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // FrmSignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(458, 718);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.materialTabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "FrmSignIn";
            this.Padding = new System.Windows.Forms.Padding(2, 52, 2, 2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Messenger";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmLogin_FormClosed);
            this.VisibleChanged += new System.EventHandler(this.frmLogin_VisibleChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmLogin_KeyDown);
            this.pnlContainer.ResumeLayout(false);
            this.pnlContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.materialTabControl1.ResumeLayout(false);
            this.tpLogin.ResumeLayout(false);
            this.tpConfiguration.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.LinkLabel llbSignUp;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialButton btnSignIn;
        private MaterialSkin.Controls.MaterialLabel lblError;
        private MaterialSkin.Controls.MaterialSwitch swShowPassword;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tpLogin;
        private System.Windows.Forms.TabPage tpConfiguration;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialTextBox txtServerIPAddress;
        private MaterialSkin.Controls.MaterialButton btnSaveChange;
        private MaterialSkin.Controls.MaterialSwitch swTheme;
        private MaterialSkin.Controls.MaterialTextBox txtUsername;
        private MaterialSkin.Controls.MaterialTextBox txtPassword;
    }
}

