
namespace ChatClient.Forms
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSelectedName = new MaterialSkin.Controls.MaterialLabel();
            this.pcbSelectedUser = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEdit = new MaterialSkin.Controls.MaterialButton();
            this.lblYourName = new MaterialSkin.Controls.MaterialLabel();
            this.pcbYourAvatar = new System.Windows.Forms.PictureBox();
            this.pnlConversation = new System.Windows.Forms.Panel();
            this.pnlUsers = new System.Windows.Forms.Panel();
            this.txtInput = new MaterialSkin.Controls.MaterialTextBox();
            this.pnlChat = new System.Windows.Forms.Panel();
            this.btnSend = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSelectedUser)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbYourAvatar)).BeginInit();
            this.pnlChat.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.lblSelectedName);
            this.panel1.Controls.Add(this.pcbSelectedUser);
            this.panel1.Location = new System.Drawing.Point(298, 66);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(661, 63);
            this.panel1.TabIndex = 8;
            // 
            // lblSelectedName
            // 
            this.lblSelectedName.AutoSize = true;
            this.lblSelectedName.Depth = 0;
            this.lblSelectedName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblSelectedName.Location = new System.Drawing.Point(68, 24);
            this.lblSelectedName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSelectedName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSelectedName.Name = "lblSelectedName";
            this.lblSelectedName.Size = new System.Drawing.Size(43, 19);
            this.lblSelectedName.TabIndex = 1;
            this.lblSelectedName.Text = "Name";
            // 
            // pcbSelectedUser
            // 
            this.pcbSelectedUser.Location = new System.Drawing.Point(2, 2);
            this.pcbSelectedUser.Margin = new System.Windows.Forms.Padding(2);
            this.pcbSelectedUser.Name = "pcbSelectedUser";
            this.pcbSelectedUser.Size = new System.Drawing.Size(61, 58);
            this.pcbSelectedUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbSelectedUser.TabIndex = 0;
            this.pcbSelectedUser.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.btnEdit);
            this.panel2.Controls.Add(this.lblYourName);
            this.panel2.Controls.Add(this.pcbYourAvatar);
            this.panel2.Location = new System.Drawing.Point(9, 66);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(284, 63);
            this.panel2.TabIndex = 11;
            // 
            // btnEdit
            // 
            this.btnEdit.AccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(129)))));
            this.btnEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEdit.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEdit.Depth = 0;
            this.btnEdit.HighEmphasis = true;
            this.btnEdit.Icon = global::ChatClient.Properties.Resources.pngwing_com;
            this.btnEdit.Location = new System.Drawing.Point(240, 14);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEdit.MaximumSize = new System.Drawing.Size(40, 40);
            this.btnEdit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.NoAccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnEdit.Size = new System.Drawing.Size(40, 36);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEdit.UseAccentColor = true;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lblYourName
            // 
            this.lblYourName.AutoSize = true;
            this.lblYourName.BackColor = System.Drawing.Color.Transparent;
            this.lblYourName.Depth = 0;
            this.lblYourName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblYourName.Location = new System.Drawing.Point(68, 24);
            this.lblYourName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblYourName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblYourName.Name = "lblYourName";
            this.lblYourName.Size = new System.Drawing.Size(43, 19);
            this.lblYourName.TabIndex = 1;
            this.lblYourName.Text = "Name";
            // 
            // pcbYourAvatar
            // 
            this.pcbYourAvatar.Location = new System.Drawing.Point(2, 2);
            this.pcbYourAvatar.Margin = new System.Windows.Forms.Padding(2);
            this.pcbYourAvatar.Name = "pcbYourAvatar";
            this.pcbYourAvatar.Size = new System.Drawing.Size(61, 58);
            this.pcbYourAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbYourAvatar.TabIndex = 0;
            this.pcbYourAvatar.TabStop = false;
            // 
            // pnlConversation
            // 
            this.pnlConversation.AutoScroll = true;
            this.pnlConversation.AutoScrollMinSize = new System.Drawing.Size(20, 20);
            this.pnlConversation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlConversation.BackColor = System.Drawing.SystemColors.Control;
            this.pnlConversation.Location = new System.Drawing.Point(298, 132);
            this.pnlConversation.Margin = new System.Windows.Forms.Padding(2);
            this.pnlConversation.Name = "pnlConversation";
            this.pnlConversation.Size = new System.Drawing.Size(661, 411);
            this.pnlConversation.TabIndex = 12;
            // 
            // pnlUsers
            // 
            this.pnlUsers.AutoScroll = true;
            this.pnlUsers.BackColor = System.Drawing.SystemColors.Control;
            this.pnlUsers.Location = new System.Drawing.Point(9, 133);
            this.pnlUsers.Margin = new System.Windows.Forms.Padding(2);
            this.pnlUsers.Name = "pnlUsers";
            this.pnlUsers.Size = new System.Drawing.Size(284, 480);
            this.pnlUsers.TabIndex = 6;
            // 
            // txtInput
            // 
            this.txtInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInput.Depth = 0;
            this.txtInput.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtInput.Hint = "Aa";
            this.txtInput.LeadingIcon = null;
            this.txtInput.Location = new System.Drawing.Point(3, 13);
            this.txtInput.MaxLength = 50;
            this.txtInput.MouseState = MaterialSkin.MouseState.OUT;
            this.txtInput.Multiline = false;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(591, 36);
            this.txtInput.TabIndex = 13;
            this.txtInput.Text = "";
            this.txtInput.TrailingIcon = null;
            this.txtInput.UseTallSize = false;
            this.txtInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtInput_KeyDown);
            // 
            // pnlChat
            // 
            this.pnlChat.BackColor = System.Drawing.SystemColors.Control;
            this.pnlChat.Controls.Add(this.btnSend);
            this.pnlChat.Controls.Add(this.txtInput);
            this.pnlChat.Location = new System.Drawing.Point(298, 547);
            this.pnlChat.Margin = new System.Windows.Forms.Padding(2);
            this.pnlChat.Name = "pnlChat";
            this.pnlChat.Size = new System.Drawing.Size(661, 66);
            this.pnlChat.TabIndex = 13;
            // 
            // btnSend
            // 
            this.btnSend.Depth = 0;
            this.btnSend.Icon = global::ChatClient.Properties.Resources.Message__Send_;
            this.btnSend.Location = new System.Drawing.Point(600, 4);
            this.btnSend.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(58, 59);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "materialFloatingActionButton1";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(975, 636);
            this.Controls.Add(this.pnlChat);
            this.Controls.Add(this.pnlConversation);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlUsers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.Padding = new System.Windows.Forms.Padding(2, 52, 2, 2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Messenger";
            this.VisibleChanged += new System.EventHandler(this.frmMain_VisibleChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSelectedUser)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbYourAvatar)).EndInit();
            this.pnlChat.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pcbSelectedUser;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pcbYourAvatar;
        private System.Windows.Forms.Panel pnlConversation;
        private System.Windows.Forms.Panel pnlUsers;
        private MaterialSkin.Controls.MaterialFloatingActionButton btnSend;
        private MaterialSkin.Controls.MaterialTextBox txtInput;
        private System.Windows.Forms.Panel pnlChat;
        private MaterialSkin.Controls.MaterialLabel lblSelectedName;
        private MaterialSkin.Controls.MaterialLabel lblYourName;
        private MaterialSkin.Controls.MaterialButton btnEdit;
    }
}

