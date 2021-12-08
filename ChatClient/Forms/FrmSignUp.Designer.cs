
namespace ChatClient.Forms
{
    partial class FrmSignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSignUp));
            this.dialog = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.lblError = new MaterialSkin.Controls.MaterialLabel();
            this.btnSignUp = new MaterialSkin.Controls.MaterialButton();
            this.btnChooseAvatar = new MaterialSkin.Controls.MaterialButton();
            this.txtDisplayName = new MaterialSkin.Controls.MaterialTextBox();
            this.txtConfirmPass = new MaterialSkin.Controls.MaterialTextBox();
            this.txtPassword = new MaterialSkin.Controls.MaterialTextBox();
            this.txtUsername = new MaterialSkin.Controls.MaterialTextBox();
            this.pcbAvatar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dialog
            // 
            this.dialog.RestoreDirectory = true;
            this.dialog.Title = "Chọn ảnh đại diện của bạn";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.materialLabel1);
            this.panel1.Controls.Add(this.lblError);
            this.panel1.Controls.Add(this.btnSignUp);
            this.panel1.Controls.Add(this.btnChooseAvatar);
            this.panel1.Controls.Add(this.txtDisplayName);
            this.panel1.Controls.Add(this.txtConfirmPass);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.txtUsername);
            this.panel1.Controls.Add(this.pcbAvatar);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(728, 481);
            this.panel1.TabIndex = 0;
            // 
            // materialLabel1
            // 
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(425, 139);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(150, 30);
            this.materialLabel1.TabIndex = 4;
            this.materialLabel1.Text = "Ảnh đại diện";
            this.materialLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblError
            // 
            this.lblError.Depth = 0;
            this.lblError.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblError.HighEmphasis = true;
            this.lblError.Location = new System.Drawing.Point(280, 12);
            this.lblError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblError.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(437, 115);
            this.lblError.TabIndex = 0;
            this.lblError.Text = "Thông báo";
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblError.UseAccent = true;
            // 
            // btnSignUp
            // 
            this.btnSignUp.AccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(129)))));
            this.btnSignUp.AutoSize = false;
            this.btnSignUp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSignUp.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSignUp.Depth = 0;
            this.btnSignUp.HighEmphasis = true;
            this.btnSignUp.Icon = null;
            this.btnSignUp.Location = new System.Drawing.Point(280, 423);
            this.btnSignUp.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnSignUp.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.NoAccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnSignUp.Size = new System.Drawing.Size(118, 36);
            this.btnSignUp.TabIndex = 6;
            this.btnSignUp.Text = "Đăng ký";
            this.btnSignUp.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSignUp.UseAccentColor = true;
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // btnChooseAvatar
            // 
            this.btnChooseAvatar.AccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(129)))));
            this.btnChooseAvatar.AutoSize = false;
            this.btnChooseAvatar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnChooseAvatar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnChooseAvatar.Depth = 0;
            this.btnChooseAvatar.HighEmphasis = true;
            this.btnChooseAvatar.Icon = null;
            this.btnChooseAvatar.Location = new System.Drawing.Point(443, 339);
            this.btnChooseAvatar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnChooseAvatar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnChooseAvatar.Name = "btnChooseAvatar";
            this.btnChooseAvatar.NoAccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnChooseAvatar.Size = new System.Drawing.Size(114, 36);
            this.btnChooseAvatar.TabIndex = 5;
            this.btnChooseAvatar.Text = "Chọn ảnh...";
            this.btnChooseAvatar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnChooseAvatar.UseAccentColor = true;
            this.btnChooseAvatar.UseVisualStyleBackColor = true;
            this.btnChooseAvatar.Click += new System.EventHandler(this.btnChooseAvatar_Click);
            // 
            // txtDisplayName
            // 
            this.txtDisplayName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDisplayName.Depth = 0;
            this.txtDisplayName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDisplayName.Hint = "Tên hiển thị";
            this.txtDisplayName.LeadingIcon = global::ChatClient.Properties.Resources.name_icon_382818_free_icons_library_names_logos_png_512_512;
            this.txtDisplayName.Location = new System.Drawing.Point(45, 343);
            this.txtDisplayName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDisplayName.MaxLength = 50;
            this.txtDisplayName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDisplayName.Multiline = false;
            this.txtDisplayName.Name = "txtDisplayName";
            this.txtDisplayName.Size = new System.Drawing.Size(214, 50);
            this.txtDisplayName.TabIndex = 3;
            this.txtDisplayName.Text = "";
            this.txtDisplayName.TrailingIcon = null;
            // 
            // txtConfirmPass
            // 
            this.txtConfirmPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfirmPass.Depth = 0;
            this.txtConfirmPass.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtConfirmPass.Hint = "Xác nhận mật khẩu";
            this.txtConfirmPass.LeadingIcon = global::ChatClient.Properties.Resources.show_password_icon_5;
            this.txtConfirmPass.Location = new System.Drawing.Point(45, 271);
            this.txtConfirmPass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtConfirmPass.MaxLength = 50;
            this.txtConfirmPass.MouseState = MaterialSkin.MouseState.OUT;
            this.txtConfirmPass.Multiline = false;
            this.txtConfirmPass.Name = "txtConfirmPass";
            this.txtConfirmPass.Password = true;
            this.txtConfirmPass.Size = new System.Drawing.Size(214, 50);
            this.txtConfirmPass.TabIndex = 2;
            this.txtConfirmPass.Text = "";
            this.txtConfirmPass.TrailingIcon = null;
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Depth = 0;
            this.txtPassword.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPassword.Hint = "Mật khẩu";
            this.txtPassword.LeadingIcon = global::ChatClient.Properties.Resources.PinClipart_com_ship_clipart_black_and_1303682;
            this.txtPassword.Location = new System.Drawing.Point(45, 203);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPassword.MaxLength = 50;
            this.txtPassword.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Password = true;
            this.txtPassword.Size = new System.Drawing.Size(214, 50);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.Text = "";
            this.txtPassword.TrailingIcon = null;
            // 
            // txtUsername
            // 
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Depth = 0;
            this.txtUsername.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtUsername.Hint = "Tên đăng nhập";
            this.txtUsername.LeadingIcon = global::ChatClient.Properties.Resources.Sample_User_Icon;
            this.txtUsername.Location = new System.Drawing.Point(45, 135);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUsername.MaxLength = 50;
            this.txtUsername.MouseState = MaterialSkin.MouseState.OUT;
            this.txtUsername.Multiline = false;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(214, 50);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.Text = "";
            this.txtUsername.TrailingIcon = null;
            // 
            // pcbAvatar
            // 
            this.pcbAvatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcbAvatar.Location = new System.Drawing.Point(425, 182);
            this.pcbAvatar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pcbAvatar.Name = "pcbAvatar";
            this.pcbAvatar.Size = new System.Drawing.Size(150, 150);
            this.pcbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbAvatar.TabIndex = 62;
            this.pcbAvatar.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ChatClient.Properties.Resources.line_messenger_social_transparent_icon_1320192471848876306_512;
            this.pictureBox1.Location = new System.Drawing.Point(116, 20);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 56;
            this.pictureBox1.TabStop = false;
            // 
            // FrmSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 575);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSignUp";
            this.Padding = new System.Windows.Forms.Padding(2, 52, 2, 2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng ký";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmSignUp_FormClosed);
            this.VisibleChanged += new System.EventHandler(this.FrmSignUp_VisibleChanged);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog dialog;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pcbAvatar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialTextBox txtUsername;
        private MaterialSkin.Controls.MaterialTextBox txtPassword;
        private MaterialSkin.Controls.MaterialTextBox txtConfirmPass;
        private MaterialSkin.Controls.MaterialTextBox txtDisplayName;
        private MaterialSkin.Controls.MaterialButton btnChooseAvatar;
        private MaterialSkin.Controls.MaterialButton btnSignUp;
        private MaterialSkin.Controls.MaterialLabel lblError;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}