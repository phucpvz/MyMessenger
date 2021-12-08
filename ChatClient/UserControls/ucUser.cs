using ChatClient.MyServiceReference;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatClient.UserControls
{
    public partial class ucUser : UserControl
    {
        private event EventHandler<UserSelectedEventArgs> userSelected;
        public event EventHandler<UserSelectedEventArgs> UserSelected
        {
            add { userSelected += value; }
            remove { userSelected -= value; }
        }

        private bool isSelected;
        public bool IsSelected { 
            get => isSelected; 
            set
            {
                isSelected = value;
                pnlUser.BackColor = isSelected ? Color.DodgerBlue : Color.White;
            }
        }

        public ucUser(User u)
        {
            InitializeComponent();
            Tag = u;
            lblName.Text = u.DisplayName;
            pcbAvatar.Image = Program.GetAvatar(u.Avatar);
        }

        public Image Avatar
        {
            get => pcbAvatar.Image;
        }

        private void pnlUser_MouseEnter(object sender, EventArgs e)
        {
            if (!IsSelected)
            {
                pnlUser.BackColor = Color.LightSkyBlue;
            }
        }

        private void pnlUser_MouseLeave(object sender, EventArgs e)
        {
            if (!IsSelected)
            {
                pnlUser.BackColor = Color.White;
            }
        }

        private void pnlUser_Click(object sender, EventArgs e)
        {
            if (userSelected != null)
            {
                userSelected(this, new UserSelectedEventArgs((User)Tag));
            }
            IsSelected = true;
        }
    }

    public class UserSelectedEventArgs : EventArgs
    {
        private User selectedUser;

        public User SelectedUser { get => selectedUser; set => selectedUser = value; }

        public UserSelectedEventArgs(User selectedUser)
        {
            SelectedUser = selectedUser;
        }
    }


}
