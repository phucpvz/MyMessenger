using ChatClient.Forms;
using ChatClient.MyServiceReference;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatClient.UserControls
{
    public partial class ucMessageBox : UserControl
    {
        public ucMessageBox(bool isYourMessage, Image avatar, string message, DateTime? sendTime, int id)
        {
            InitializeComponent();
            Tag = id;
            pcbAvatar.Image = avatar;
            lblMessage.Text = message;
            DateTime t = sendTime != null ? (DateTime)sendTime : new DateTime(0);
            lblSendTime.Text = t.ToString("dd-MM-yyyy HH:mm:ss");

            if (isYourMessage)
            {
                pcbAvatar.Location = new Point(550, pcbAvatar.Location.Y);
                lblMessage.Location = new Point
                    (pcbAvatar.Location.X - lblMessage.Size.Width - 20, lblMessage.Location.Y);
                lblMessage.BackColor = Color.DodgerBlue;
                lblSendTime.Location = new Point
                    (lblMessage.Location.X - lblSendTime.Size.Width - 5, lblSendTime.Location.Y);
            }
            else
            {
                lblSendTime.Location = new Point
                    (lblMessage.Location.X + lblMessage.Size.Width + 5, lblSendTime.Location.Y);
            }
            
        }

        private void DeleteMessage(int id)
        {
            MyServiceReference.DeleteMessageRequest rq = new MyServiceReference.DeleteMessageRequest();
            rq.Body = new MyServiceReference.DeleteMessageRequestBody(id);

            string result;
            try
            {
                result = Program.webservice.DeleteMessage(rq).Body.DeleteMessageResult;
            }
            catch (Exception ex)
            {
                result = ex.Message;
            }

            if (result == "OK")
            {
                Visible = false;
                MaterialSnackBar SnackBarMessage = new MaterialSnackBar
                    ("Đã xóa tin nhắn!", "OK", true);
                SnackBarMessage.Show(this);
            }
            else
            {
                MaterialDialog materialDialog = new MaterialDialog(FrmMain.Instance, "LỖI", 
                    result, "OK");
                materialDialog.ShowDialog(FrmMain.Instance);
            }
        }

        private void tsmiRemoveMessage_Click(object sender, EventArgs e)
        {
            MaterialDialog materialDialog = new MaterialDialog(FrmMain.Instance, "Xác nhận", 
                "Bạn có chắc muốn xóa tin nhắn này không?", "OK", true, "Cancel");
            DialogResult result = materialDialog.ShowDialog(this);
            if (result == DialogResult.Cancel)
            {
                return;
            }
            DeleteMessage((int)Tag);
        }
    }
}
