using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UDPClient
{
    public partial class UDPClient : Form
    {
        public UDPClient()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte[] message = Encoding.Unicode.GetBytes(tbxMessage.Text);

            IPAddress serverIp = IPAddress.Parse("127.0.0.1");
            IPEndPoint destination = new IPEndPoint(serverIp, 12345);

            UdpClient client = new UdpClient();
            client.Send(message, message.Length, destination);
        }

        private void UDPClient_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tbxMessage_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
