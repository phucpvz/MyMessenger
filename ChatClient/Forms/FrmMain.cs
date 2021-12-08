using ChatClient.MyServiceReference;
using ChatClient.UserControls;
using MaterialSkin.Controls;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ChatClient.Forms
{
    public partial class FrmMain : MaterialForm
    {
        #region Properties
        private static FrmMain _instance;
        public static FrmMain Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new FrmMain();
                }
                return _instance;
            }
        }

        private User sender;
        public User Sender
        {
            get => sender;
            set
            {
                sender = value;
                if (sender != null)
                {
                    lblYourName.Text = sender.DisplayName;
                    pcbYourAvatar.Image = Program.GetAvatar(sender.Avatar);
                    pnlChat.Visible = true;
                }
                else
                {
                    lblYourName.Text = "";
                    pcbYourAvatar.Image = null;
                    pnlChat.Visible = false;
                }
                ShowListUsers();
            }
        }

        private User receiver;
        public User Receiver
        {
            get => receiver;
            set
            {
                receiver = value;
                if (receiver != null)
                {
                    lblSelectedName.Text = receiver.DisplayName;
                    foreach (ucUser uc in pnlUsers.Controls)
                    {
                        User u = (User)uc.Tag;
                        if (u == receiver)
                        {
                            pcbSelectedUser.Image = uc.Avatar;
                            break;
                        }
                    }
                    pnlChat.Visible = true;
                }
                else
                {
                    lblSelectedName.Text = "";
                    pcbSelectedUser.Image = null;
                    pnlChat.Visible = false;
                }
                LoadMessage();
            }
        }

        //public string YourName {
        //    get => lblYourName.Text;
        //    set => lblYourName.Text = value;
        //}

        //public Image YourAvatar
        //{
        //    get => pcbYourAvatar.Image;
        //    set => pcbYourAvatar.Image = value;
        //}
        #endregion

        public FrmMain()
        {
            InitializeComponent();
            lblSelectedName.Text = "";
        }

        public void ShowListUsers()
        {
            foreach (ucUser uc in pnlUsers.Controls)
            {
                uc.Dispose();
            }
            pnlUsers.Controls.Clear();

            if (Sender == null)
            {
                return;
            }

            MyServiceReference.GetListUserRequest rq = new MyServiceReference.GetListUserRequest();
            rq.Body = new MyServiceReference.GetListUserRequestBody(Sender.Username);

            User[] users;
            try
            {
                users = Program.webservice.GetListUser(rq).Body.GetListUserResult;
            }
            catch (Exception)
            {
                return;
            }

            foreach (User u in users)
            {
                ucUser uc = new ucUser(u) { Dock = DockStyle.Top };
                uc.UserSelected += Uc_UserSelected;
                pnlUsers.Controls.Add(uc);
            }

            if (users.Length > 0)
            {
                Receiver = users[users.Length - 1];
            }
            else
            {
                Receiver = null;
            }
        }

        private void LoadMessage()
        {
            pnlConversation.Controls.Clear();
            if (Sender == null || Receiver == null)
            {
                return;
            }

            string senderID = Sender.Username;
            string receiverID = Receiver.Username;
            MyServiceReference.GetMessagesRequest rq = new MyServiceReference.GetMessagesRequest();
            rq.Body = new MyServiceReference.GetMessagesRequestBody(senderID, receiverID);

            Chat[] chats;
            try
            {
                chats = Program.webservice.GetMessages(rq).Body.GetMessagesResult;
            }
            catch (Exception)
            {
                return;
            }

            pnlConversation.Controls.Clear();

            foreach (Chat chat in chats)
            {
                bool isYourMessage = chat.Sender == Sender.Username;
                Image avatar = isYourMessage ? pcbYourAvatar.Image : pcbSelectedUser.Image;
                pnlConversation.Controls.Add(new ucMessageBox(isYourMessage, avatar, 
                    chat.Message, chat.SendTime, chat.ID) { Dock = DockStyle.Bottom });
            }
        }

        private void frmMain_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible)
            {
                CenterToScreen();
                MaterialSnackBar SnackBarMessage = new MaterialSnackBar
                    ("Đăng nhập thành công", "OK", true);
                SnackBarMessage.Show(this);
            }
            else
            {
                Sender = Receiver = null;
            }
        }

        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void Uc_UserSelected(object sender, UserSelectedEventArgs e)
        {
            Receiver = e.SelectedUser;
            foreach (ucUser uc in pnlUsers.Controls)
            {
                if (uc.IsSelected)
                {
                    uc.IsSelected = false;
                }
            }
        }

        private void SendMessage()
        {
            string message = txtInput.Text;
            txtInput.Clear();
            if (string.IsNullOrEmpty(message))
            {
                return;
            }

            DateTime now = DateTime.Now;
            MyServiceReference.AddMessageRequest rq = new MyServiceReference.AddMessageRequest();
            rq.Body = new MyServiceReference.AddMessageRequestBody
                (Sender.Username, Receiver.Username, message, now);

            string result;
            try
            {
                result = Program.webservice.AddMessage(rq).Body.AddMessageResult;
            }
            catch (Exception ex)
            {
                result = ex.Message;
            }

            int id;
            bool isNumeric = int.TryParse(result, out id);
            if (isNumeric)
            {
                pnlConversation.Controls.Add(new ucMessageBox(true, pcbYourAvatar.Image,
                message, now, id) { Dock = DockStyle.Bottom });
            }
            else
            {
                MaterialDialog materialDialog = new MaterialDialog(this, "LỖI",
                    result, "OK");
                materialDialog.ShowDialog(this);
            }
        }

        private void txtInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SendMessage();
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            SendMessage();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            FrmEdit.Instance.CurrentUser = Sender;
            FrmEdit.Instance.ShowDialog();
        }
    }
}
