using Opc.Ua;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static OPCClientApp.SimpleOPCClient;

namespace OPCClientApp
{
    public partial class Form1 : Form
    {
        private SimpleOPCClient _opcClient;
        public Form1()
        {
            InitializeComponent();

            _opcClient = new SimpleOPCClient();
            _opcClient.ConnectComplete += _opcClient_ConnectComplete;
            _opcClient.NodeValueChanged += _opcClient_NodeValueChanged;
        }

        private void _opcClient_NodeValueChanged(object sender, NodeValueChangedEventArgs e)
        {
            this.BeginInvoke(new Action(() =>
            {
                labelNodeValue.Text = e.nodeValue;

            }));
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

        private void readNodesBtn_Click(object sender, EventArgs e)
        {
            List<string> nodeStructure = _opcClient.ReadServerNodeStructure();

            string output = "";
            for (int i = 0; i < nodeStructure.Count; i++)
            {
                output += nodeStructure[i].ToString() + "\n";
            }
            nodesListText.Text = output;
        }

        List<OPCUnsubscribeObject> _workTimeUnsub = new List<OPCUnsubscribeObject>();
        private void buttonSubTest_Click(object sender, EventArgs e)
        {
            try
            {
                var unsub = _opcClient.SubscribeNodeValue("ns=1;s=127.0.0.1/WorkTime", 1000);

                var unsubX = _opcClient.SubscribeNodeValue("ns=1;s=127.0.0.1/Channel 1/Axis 1 (X)/CurPos", 1000);
                var unsubY = _opcClient.SubscribeNodeValue("ns=1;s=127.0.0.1/Channel 1/Axis 2 (Y)/CurPos", 1000);
                var unsubZ = _opcClient.SubscribeNodeValue("ns=1;s=127.0.0.1/Channel 1/Axis 3 (Z)/CurPos", 1000);

                if (unsub != null) _workTimeUnsub.Add(unsub);
                if (unsubX != null) _workTimeUnsub.Add(unsubX);
                if (unsubY != null) _workTimeUnsub.Add(unsubY);
                if (unsubZ != null) _workTimeUnsub.Add(unsubZ);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void buttonUnsubTest_Click(object sender, EventArgs e)
        {
            try
            {
                //if (_workTimeUnsub != null)
                //{
                //    _workTimeUnsub.Dispose();
                //}
                for (int i = 0; i < _workTimeUnsub.Count; i++) {
                    if (_workTimeUnsub[i] != null)
                    {
                        _workTimeUnsub[i].Dispose();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                _workTimeUnsub.Clear();
            }
        }
    }
}
