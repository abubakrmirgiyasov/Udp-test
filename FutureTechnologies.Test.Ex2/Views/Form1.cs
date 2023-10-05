using FutureTechnologies.Test.Ex2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FutureTechnologies.Test.Ex2
{
    public partial class Form1 : Form
    {
        private readonly UdpClient _udpClient;
        private int _totalPacketsSent = 0;
        private int _totalPacketsReceived = 0;
        private IPEndPoint _endpoint;

        public Form1()
        {
            InitializeComponent();
            _udpClient = new UdpClient();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MACAdresses_CB.Items.AddRange(NetworkInterface.GetAllNetworkInterfaces().Select(x => x.Id).ToArray());
            IpAdresses_CB.Items.AddRange(Dns.GetHostAddresses(Dns.GetHostName()).AsEnumerable().ToArray());
        }

        private void Send_B_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(IpAdresses_CB.Text))
            {
                MessageBox.Show("Выберите ip адрес", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _endpoint = new IPEndPoint(IPAddress.Parse(IpAdresses_CB.Text), 5555);
            _udpClient.Connect(_endpoint);
            
            double bytesPerSecond = (int)Length_NUD.Value * 1024 / 8; // mb/s
            double packetsPerSecond = bytesPerSecond / 1024;

            ThreadPool.QueueUserWorkItem(GenerateUdpTraffic, packetsPerSecond);
        }

        private async void GenerateUdpTraffic(object packet)
        {
            double p = (double)packet;

            _totalPacketsSent = 0;

            var random = new Random();

            while (p >= _totalPacketsSent)
            {
                byte[] data = new byte[(int)Length_NUD.Value];
                random.NextBytes(data);

                try
                {
                    _udpClient.Send(data, data.Length);
                    _totalPacketsSent++;

                    Console.WriteLine("Total packets sent: {0}", _totalPacketsSent);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при отправке пакета: {ex.Message}");
                }
            }

            await Task.Run(() =>
            {
                using (var receiver = new UdpClient(_endpoint))
                {
                    var data = receiver.Receive(ref _endpoint);

                    for (int i = 0; i < data.Length; i++)
                    {
                        _totalPacketsReceived++;
                    }
                }
            });

            Log_DGV.Invoke(new Action(() =>
            {
                Log_DGV.DataSource = new List<Log>()
                {
                    new Log()
                    {
                        Sent = (int)Length_NUD.Value,
                        Lost = (int)Length_NUD.Value - _totalPacketsReceived,
                        Received = _totalPacketsReceived,
                    },
                };
            }));
        }
    }
}
