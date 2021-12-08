using ChatClient.Forms;
using ChatClient.MyServiceReference;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace ChatClient
{
    static class Program
    {
        private static BasicHttpBinding binding;
        public static string serverIP;
        public static MyServiceReference.MyWebServiceSoap webservice;

        public static byte[] ImageToByteArray(Image imageIn)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                imageIn.Save(ms, ImageFormat.Gif);
                return ms.ToArray();
            }
        }

        public static Image ByteArrayToImage(byte[] byteArrayIn)
        {
            if (byteArrayIn == null)
            {
                return null;
            }
            using (MemoryStream ms = new MemoryStream(byteArrayIn))
            {
                return Image.FromStream(ms);
            }
        }

        public static Image GetAvatar(string filePath)
        {
            MyServiceReference.GetImageRequest rq = new MyServiceReference.GetImageRequest();
            rq.Body = new GetImageRequestBody(filePath);
            return ByteArrayToImage(Program.webservice.GetImage(rq).Body.GetImageResult);
        }

        public static void LoadImagesExtension(OpenFileDialog dialog)
        {
            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageEncoders();
            string sep = string.Empty;

            foreach (ImageCodecInfo c in codecs)
            {
                string codecName = c.CodecName.Substring(8).Replace("Codec", "Files").Trim();
                dialog.Filter = string.Format("{0}{1}{2} ({3})|{3}", dialog.Filter, sep, codecName, c.FilenameExtension);
                sep = "|";
            }

            //dialog.Filter = string.Format("{0}{1}{2} ({3})|{3}", dialog.Filter, sep, "All Files", "*.*");
            dialog.FilterIndex = dialog.Filter.Count();
            dialog.DefaultExt = ".png"; // Default file extension 
        }

        public static void Configure(string serverIP)
        {
            Program.serverIP = serverIP;
            //Specify the address to be used for the client.
            EndpointAddress address = new EndpointAddress
                ($"http://{serverIP}/ChatWebService/MyWebService.asmx");
            webservice = new MyServiceReference.MyWebServiceSoapClient(binding, address);
        }

        private static readonly string filePath = Application.StartupPath + "\\config.xml";

        // Ghi nội dung cấu hình vào file
        public static bool SerializeToXML(Config config)
        {
            FileStream fs = null;
            try
            {
                fs = new FileStream(filePath, FileMode.Create, FileAccess.Write);
                XmlSerializer xml = new XmlSerializer(typeof(Config));
                xml.Serialize(fs, config);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                if (fs != null)
                {
                    fs.Close();
                }
            }
        }

        // Đọc nội dung cấu hình từ file
        public static Config DeserializeFromXML()
        {
            FileStream fs = null;
            try
            {
                fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                XmlSerializer xml = new XmlSerializer(typeof(Config));
                object obj = xml.Deserialize(fs);
                return (Config)obj;
            }
            catch
            {
                return null;
            }
            finally
            {
                if (fs != null)
                {
                    fs.Close();
                }
            }
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Specify the binding to be used for the client.
            binding = new BasicHttpBinding();
            binding.MaxReceivedMessageSize = 2147483647;
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(FrmSignIn.Instance);
        }
    }
}
