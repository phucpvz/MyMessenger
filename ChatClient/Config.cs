using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatClient
{
    [Serializable]
    public class Config
    {
        private string serverIPAddress;

        public string ServerIPAddress { get => serverIPAddress; set => serverIPAddress = value; }
    }
}
