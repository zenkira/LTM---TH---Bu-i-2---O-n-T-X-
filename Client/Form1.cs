using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
namespace Client
{
    public partial class Form1 : Form
    {
        Socket server;
        Socket client;


        byte[] data;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            IPEndPoint ipep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9050);
            client = new Socket(AddressFamily.InterNetwork,
            SocketType.Stream, ProtocolType.Tcp);
            try
            {
                client.Connect(ipep);
            }
            catch (SocketException ex)
            {
                MessageBox.Show("Unable to connect to server.");
                MessageBox.Show(ex.ToString());

                return;
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {

        }
    }
}
