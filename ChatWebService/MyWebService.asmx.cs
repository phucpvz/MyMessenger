using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Web.Services;

namespace ChatWebService
{
    /// <summary>
    /// Summary description for MyWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class MyWebService : System.Web.Services.WebService
    {
        MyMessengerDataContext db = null;

        public MyWebService()
        {
            db = new MyMessengerDataContext();
        }

        public string EncryptPassword(string password)
        {
            System.Security.Cryptography.MD5CryptoServiceProvider md5Hasher 
                = new System.Security.Cryptography.MD5CryptoServiceProvider();
            byte[] hashedDataBytes = md5Hasher.ComputeHash
                (System.Text.Encoding.UTF8.GetBytes(password));
            string sEncryptPass = Convert.ToBase64String(hashedDataBytes);
            return sEncryptPass;
        }

        public static byte[] ImageToByteArray(Image imageIn)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                imageIn.Save(ms, ImageFormat.Gif);
                return ms.ToArray();
            }
        }

        public void UploadFile(string avatar, byte[] bytes)
        {
            //Save the Byte Array as File.
            string filePath = Server.MapPath(avatar);
            File.WriteAllBytes(filePath, bytes);
        }

        public void DeleteFile(string avatar)
        {
            string filePath = Server.MapPath(avatar);
            File.Delete(filePath);
        }

        [WebMethod]
        public User SignIn(string username, string password)
        {
            string encryptPassword = EncryptPassword(password);
            User u = db.Users.FirstOrDefault
                (t => t.Username == username && t.Password == encryptPassword);
            if (u != null)
            {
                u.Chats.Clear();
                u.Chats1.Clear();
            }
            return u;
        }

        [WebMethod]
        public string SignUp(string username, string password, string displayName,
            string filePath, byte[] file_byte)
        {
            if (db.Users.Any(u => u.Username == username))
            {
                return "Tên đăng nhập đã tồn tại! Vui lòng chọn tên đăng nhập khác";
            }
            
            // Get file's name from file's path
            string[] names = filePath.Split('\\');
            string fileName = names[names.Length - 1];

            string avatar = $"~/Uploads/{DateTimeOffset.Now.ToUnixTimeMilliseconds()}_{fileName}";
            try
            {
                UploadFile(avatar, file_byte);
            }
            catch (Exception ex)
            {
                //return "Đã xảy ra lỗi khi tải lên ảnh đại diện của bạn!";
                return ex.Message;
            }

            string encryptPassword = EncryptPassword(password);
            try
            {
                User user = new User()
                {
                    Username = username,
                    Password = encryptPassword,
                    DisplayName = displayName,
                    Avatar = avatar
                };
                db.Users.InsertOnSubmit(user);
                db.SubmitChanges();
                return "OK";
            }
            catch (Exception ex)
            {
                //return "Đăng ký tài khoản thất bại!";
                return ex.Message;
            }
        }

        [WebMethod]
        public string UpdateInformation(string username, string displayName, string oldPassword = "", 
            string newPassword = "", string filePath = "", byte[] file_byte = null)
        {
            User user = db.Users.FirstOrDefault(u => u.Username == username);
            if (user == null)
            {
                return "Tên đăng nhập không tồn tại!";
            }
            if (!string.IsNullOrEmpty(displayName))
            {
                user.DisplayName = displayName;
            }

            if (!string.IsNullOrEmpty(oldPassword))
            {
                if (!EncryptPassword(oldPassword).Equals(user.Password))
                {
                    return "Mật khẩu cũ không chính xác";
                }
                if (!string.IsNullOrEmpty(newPassword))
                {
                    user.Password = EncryptPassword(newPassword);
                }
            }

            string avatar = null;
            if (!string.IsNullOrEmpty(filePath))
            {
                if (file_byte == null)
                {
                    return "Có đường dẫn file nhưng không có ảnh!";
                }

                // Get file's name from file's path
                string[] names = filePath.Split('\\');
                string fileName = names[names.Length - 1];

                avatar = $"~/Uploads/{DateTimeOffset.Now.ToUnixTimeMilliseconds()}_{fileName}";
                try
                {
                    UploadFile(avatar, file_byte);
                }
                catch (Exception ex)
                {
                    //return "Đã xảy ra lỗi khi tải lên ảnh đại diện của bạn!";
                    return ex.Message;
                }

                // Xóa file ảnh cũ
                try
                {
                    if (!string.IsNullOrEmpty(user.Avatar))
                    {
                        DeleteFile(user.Avatar);
                    }
                }
                catch{}
            }
            if (!string.IsNullOrEmpty(avatar))
            {
                user.Avatar = avatar;
            }
            
            try
            {
                db.SubmitChanges();
                return "OK";
            }
            catch (Exception ex)
            {
                //return "Cập nhật thông tin cá nhân thất bại!";
                return ex.Message;
            }
        }

        [WebMethod]
        public User GetUser(string username)
        {
            User u = db.Users.FirstOrDefault(t => t.Username == username);
            if (u != null)
            {
                u.Chats.Clear();
                u.Chats1.Clear();
            }
            return u;
        }

        [WebMethod]
        public byte[] GetImage(string filePath)
        {
            try
            {
                return File.ReadAllBytes(Server.MapPath(filePath));
            }
            catch (Exception)
            {
                return null;
            }
        }

        // Get list user except user with username
        [WebMethod]
        public List<User> GetListUser(string exceptUsername = "")
        {
            List<User> users =  db.Users.ToList();
            if (exceptUsername != "")
            {
                User user = users.FirstOrDefault(u => u.Username == exceptUsername);
                users.Remove(user);
            }
            foreach (User u in users)
            {
                u.Chats.Clear();
                u.Chats1.Clear();
            }
            return users;
        }

        [WebMethod]
        public List<Chat> GetMessages(string sender, string receiver)
        {
            List<Chat> chats1 = db.Chats.Where(c => c.Sender == sender 
            && c.Receiver == receiver).ToList();
            List<Chat> chats2 = db.Chats.Where(c => c.Sender == receiver
            && c.Receiver == sender).ToList();
            chats1.AddRange(chats2);
            chats1 = chats1.OrderBy(c => c.ID).ToList();

            List<Chat> messages = new List<Chat>();
            foreach (Chat chat in chats1)
            {
                Chat mes = new Chat()
                {
                    ID = chat.ID,
                    Message = chat.Message,
                    SendTime = chat.SendTime,
                    Sender = chat.Sender,
                    Receiver = chat.Receiver
                };
                messages.Add(mes);
            }
            return messages;
        }

        [WebMethod]
        public string AddMessage(string sender, string receiver, string message, DateTime sendTime)
        {
            try
            {
                Chat chat = new Chat()
                {
                    Sender = sender,
                    Receiver = receiver,
                    Message = message,
                    SendTime = sendTime
                };

                db.Chats.InsertOnSubmit(chat);
                db.SubmitChanges();
                return chat.ID.ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        [WebMethod]
        public string DeleteMessage(int id)
        {
            try
            {
                Chat message = db.Chats.FirstOrDefault(m => m.ID == id);
                db.Chats.DeleteOnSubmit(message);
                db.SubmitChanges();
                return "OK";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        
    }
}
