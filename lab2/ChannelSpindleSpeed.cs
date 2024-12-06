using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static OPCClientApp.SimpleOPCClient;

namespace OPCClientApp
{
    public partial class ChannelSpindleSpeed : UserControl, IOPCClientControl
    {
        private SimpleOPCClient _client;
        private List<OPCUnsubscribeObject> _subscriptions = new List<OPCUnsubscribeObject>();

        public ChannelSpindleSpeed()
        {
            InitializeComponent();
        }

        void IOPCClientControl.Init(SimpleOPCClient client)
        {
            _subscriptions.Clear(); _client = client;
            if (_client != null)
            {
                _client.ConnectComplete += _client_ConnectComplete;
                _client.NodeValueChanged += _client_NodeValueChanged;
            }
        }

        private void _client_NodeValueChanged(object sender, NodeValueChangedEventArgs e)
        {
            this.BeginInvoke(new Action(() =>
            {
                switch (e.nodeId)
                {
                    case "ns=1;s=127.0.0.1/Channel 1/Spindle override":
                        labelPersent.Text = e.nodeValue;
                        break;
                    case "ns=1;s=127.0.0.1/Channel 1/Axis 5 (S1)/CurVel":
                        labelBarRPM.Text = e.nodeValue;
                        progressBarRPM.Value = int.Parse(e.nodeValue.Split(',')[0]);
                        break;
                }
            }));
        }
        private void _client_ConnectComplete(object sender, EventArgs e)
        {
            if (_client.ConnectionStatus == true)
            {
                _subscriptions.Add(_client.SubscribeNodeValue("ns=1;s=127.0.0.1/Channel 1/Spindle override", 1000));
                _subscriptions.Add(_client.SubscribeNodeValue("ns=1;s=127.0.0.1/Channel 1/Axis 5 (S1)/CurVel", 1000));
            }
            else
            {
                _subscriptions.Clear();
            }
        }
    }
}
