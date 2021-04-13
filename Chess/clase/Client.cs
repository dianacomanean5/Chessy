using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Chess.clase
{
    class Client
    {
        TcpClient client = null;
        NetworkStream stream = null;
        StreamReader streamReader = null;
        StreamWriter streamWriter = null;
        public Miscare miscare = null;

        public Client(Miscare miscare)
        {
            client = new TcpClient("localhost", 8000);
            stream = client.GetStream();
            streamReader = new StreamReader(stream);
            streamWriter = new StreamWriter(stream);
            SendMessage(miscare);
            StreamAndClientClose();
        }

        public Client()
        {
            client = new TcpClient("localhost", 8000);
            stream = client.GetStream();
            streamReader = new StreamReader(stream);
            streamWriter = new StreamWriter(stream);
            ReceiveMessage();
            //SendMessage(message);
            //StreamAndClientClose();
        }

        public void SendMessage(Miscare miscare)
        {
            streamWriter.WriteLine(Convert.ToString(JsonConvert.SerializeObject(miscare)));
            streamWriter.Flush();
        }
        public void ReceiveMessage()
        {
            while (true)
            {
                try
                {
                    miscare = JsonConvert.DeserializeObject<Miscare>(streamReader.ReadLine().ToString());
                    break;
                }
                catch { }
            }
            //VariabileGlobale.mesajPrimit = mesajPrimit;
        }

        public void StreamAndClientClose()
        {
            stream.Close();
            client.Close();
        }
    }
}
