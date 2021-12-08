
namespace ChatClient.UserControls
{
    partial class ucMessageBox
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMessage = new System.Windows.Forms.Label();
            this.cmsMessage = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.tsmiRemoveMessage = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.lblSendTime = new System.Windows.Forms.Label();
            this.pcbAvatar = new System.Windows.Forms.PictureBox();
            this.item2ToolStripMenuItem = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.cmsMessage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lblMessage);
            this.panel1.Controls.Add(this.lblSendTime);
            this.panel1.Controls.Add(this.pcbAvatar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(644, 121);
            this.panel1.TabIndex = 2;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.BackColor = System.Drawing.Color.Gray;
            this.lblMessage.ContextMenuStrip = this.cmsMessage;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.White;
            this.lblMessage.Location = new System.Drawing.Point(128, 21);
            this.lblMessage.MaximumSize = new System.Drawing.Size(400, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(48, 20);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.Text = "Hello";
            // 
            // cmsMessage
            // 
            this.cmsMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmsMessage.Depth = 0;
            this.cmsMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cmsMessage.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsMessage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiRemoveMessage});
            this.cmsMessage.Margin = new System.Windows.Forms.Padding(16, 8, 16, 8);
            this.cmsMessage.MouseState = MaterialSkin.MouseState.HOVER;
            this.cmsMessage.Name = "materialContextMenuStrip1";
            this.cmsMessage.Size = new System.Drawing.Size(188, 34);
            // 
            // tsmiRemoveMessage
            // 
            this.tsmiRemoveMessage.AutoSize = false;
            this.tsmiRemoveMessage.Name = "tsmiRemoveMessage";
            this.tsmiRemoveMessage.Size = new System.Drawing.Size(170, 30);
            this.tsmiRemoveMessage.Text = "Xóa tin nhắn";
            this.tsmiRemoveMessage.Click += new System.EventHandler(this.tsmiRemoveMessage_Click);
            // 
            // lblSendTime
            // 
            this.lblSendTime.AutoSize = true;
            this.lblSendTime.Location = new System.Drawing.Point(182, 21);
            this.lblSendTime.Name = "lblSendTime";
            this.lblSendTime.Size = new System.Drawing.Size(126, 17);
            this.lblSendTime.TabIndex = 4;
            this.lblSendTime.Text = "00-00-00 00:00:00";
            // 
            // pcbAvatar
            // 
            this.pcbAvatar.Location = new System.Drawing.Point(19, 21);
            this.pcbAvatar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pcbAvatar.Name = "pcbAvatar";
            this.pcbAvatar.Size = new System.Drawing.Size(85, 78);
            this.pcbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbAvatar.TabIndex = 2;
            this.pcbAvatar.TabStop = false;
            // 
            // item2ToolStripMenuItem
            // 
            this.item2ToolStripMenuItem.AutoSize = false;
            this.item2ToolStripMenuItem.Name = "item2ToolStripMenuItem";
            this.item2ToolStripMenuItem.Size = new System.Drawing.Size(170, 30);
            this.item2ToolStripMenuItem.Text = "Item 2";
            // 
            // ucMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ucMessageBox";
            this.Size = new System.Drawing.Size(644, 121);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.cmsMessage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pcbAvatar;
        private System.Windows.Forms.Label lblSendTime;
        private MaterialSkin.Controls.MaterialContextMenuStrip cmsMessage;
        private MaterialSkin.Controls.MaterialToolStripMenuItem tsmiRemoveMessage;
        private MaterialSkin.Controls.MaterialToolStripMenuItem item2ToolStripMenuItem;
        private System.Windows.Forms.Label lblMessage;
    }
}
