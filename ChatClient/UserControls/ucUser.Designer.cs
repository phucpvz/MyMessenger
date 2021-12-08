
namespace ChatClient.UserControls
{
    partial class ucUser
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlUser = new System.Windows.Forms.Panel();
            this.lblName = new MaterialSkin.Controls.MaterialLabel();
            this.pcbAvatar = new System.Windows.Forms.PictureBox();
            this.pnlUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlUser
            // 
            this.pnlUser.BackColor = System.Drawing.Color.White;
            this.pnlUser.Controls.Add(this.lblName);
            this.pnlUser.Controls.Add(this.pcbAvatar);
            this.pnlUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlUser.Location = new System.Drawing.Point(0, 0);
            this.pnlUser.Margin = new System.Windows.Forms.Padding(2);
            this.pnlUser.Name = "pnlUser";
            this.pnlUser.Size = new System.Drawing.Size(303, 66);
            this.pnlUser.TabIndex = 0;
            this.pnlUser.Click += new System.EventHandler(this.pnlUser_Click);
            this.pnlUser.MouseEnter += new System.EventHandler(this.pnlUser_MouseEnter);
            this.pnlUser.MouseLeave += new System.EventHandler(this.pnlUser_MouseLeave);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Depth = 0;
            this.lblName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblName.Location = new System.Drawing.Point(69, 22);
            this.lblName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(84, 19);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Tên hiển thị";
            // 
            // pcbAvatar
            // 
            this.pcbAvatar.Location = new System.Drawing.Point(2, 2);
            this.pcbAvatar.Margin = new System.Windows.Forms.Padding(2);
            this.pcbAvatar.Name = "pcbAvatar";
            this.pcbAvatar.Size = new System.Drawing.Size(62, 61);
            this.pcbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbAvatar.TabIndex = 0;
            this.pcbAvatar.TabStop = false;
            // 
            // ucUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlUser);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ucUser";
            this.Size = new System.Drawing.Size(303, 66);
            this.pnlUser.ResumeLayout(false);
            this.pnlUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAvatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlUser;
        private System.Windows.Forms.PictureBox pcbAvatar;
        private MaterialSkin.Controls.MaterialLabel lblName;
    }
}
