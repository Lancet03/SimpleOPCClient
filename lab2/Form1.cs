using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    public partial class Form1 : Form
    {
        private SimpleOPCClient _opcClient;
        public Form1()
        {
            InitializeComponent();

            _opcClient = new SimpleOPCClient();
            _opcClient.ConnectComplete += _opcClient_ConnectComplete;
        }

        private void _opcClient_ConnectComplete(object sender, EventArgs e)
        {
            if (_opcClient.ConnectionStatus == true)
            {
                this.labelConnectionStatus.BackColor = Color.Green;
                this.labelConnectionStatus.Text = "Соединено";
            }
            else
            {
                this.labelConnectionStatus.BackColor = Color.Red;
                this.labelConnectionStatus.Text = "Не соединено";
            }
        }

        private async void buttonConnect_Click(object sender, EventArgs e)
        {
            try
            {
                await _opcClient.Connect();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                _opcClient.Disconnect();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void buttonReadNodeValue_Click(object sender, EventArgs e)
        {
            labelNodeValue.Text = _opcClient.ReadNodeValue("ns=1;s=127.0.0.1/WorkTime");
        }

        private void ReadPositionBtn_Click(object sender, EventArgs e)
        {
            string posX = _opcClient.ReadNodeValue("ns=1;s=127.0.0.1/Channel 1/Axis 1 (X)/CurPos");
            string posY = _opcClient.ReadNodeValue("ns=1;s=127.0.0.1/Channel 1/Axis 2 (Y)/CurPos");
            string posZ = _opcClient.ReadNodeValue("ns=1;s=127.0.0.1/Channel 1/Axis 3 (Z)/CurPos");

            positionLabel.Text = $"X = {posX};\n Y = {posY}; \n Z = {posZ}";
        }
    }
}
