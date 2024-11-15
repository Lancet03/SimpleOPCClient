using Opc.Ua.Client;
using Opc.Ua.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Opc.Ua.Client;
using Opc.Ua.Configuration;
using Opc.Ua;

namespace lab2
{

    internal class SimpleOPCClient
    {
        private ApplicationInstance application;
        private Session m_session;

        /// <summary> 
        /// Значения параметров сессии по умолчанию 
        /// </summary> 
        public static readonly uint DefaultSessionTimeout = 60000;
        public static readonly int DefaultDiscoverTimeout = 15000;
        public static readonly int DefaultReconnectPeriod = 1;
        public static readonly int DefaultReconnectPeriodExponentialBackOff = 10;

        /// <summary>
        /// Событие генерируется после успешного соединения или отключения от сервера 
        /// </summary> 
        private EventHandler m_ConnectComplete;
        public event EventHandler ConnectComplete
        {
            add { m_ConnectComplete += value; }
            remove { m_ConnectComplete -= value; }
        }

        public void Disconnect()
        {
            //отключаем существующую сессию
            if (m_session != null)
            {
                //отписывыемся от события KeepAlive
                m_session.KeepAlive -= session_KeepAlive;
                //закрываем сессию
                m_session.Close(10000);
                m_session = null;
            }

            //выдача события об отключении
            if (m_ConnectComplete != null)
                m_ConnectComplete(this, null);
        }

        public bool ConnectionStatus
        {
            get => (m_session != null) ? m_session.Connected : false;
        }

        private async Task<Session> InternalConnect(string serverUrl, bool useSecurity, uint sessionTimeout)
        { //согласование точки подключения к серверу
            var endpointDescription = CoreClientUtils.SelectEndpoint(application.ApplicationConfiguration, serverUrl, useSecurity, DefaultDiscoverTimeout);
            var endpointConfiguration = EndpointConfiguration.Create(application.ApplicationConfiguration);
            var endpoint = new ConfiguredEndpoint(null, endpointDescription, endpointConfiguration);
            //создание сессии
            m_session = await Session.Create(application.ApplicationConfiguration, endpoint, false, true, application.ApplicationConfiguration.ApplicationName, sessionTimeout == 0 ? DefaultSessionTimeout : sessionTimeout, null, null);
            //подписка на событие поддержания активности соединения
            m_session.KeepAlive += session_KeepAlive;
            //выдача наружу события о изменении статуса соединения
            if (m_ConnectComplete != null)
                m_ConnectComplete(this, null);
            return m_session;
        }

        private void session_KeepAlive(ISession session, KeepAliveEventArgs e)
        {
            if (Object.ReferenceEquals(session, m_session))
            {
                if (ServiceResult.IsBad(e.Status))
                {
                    this.Disconnect();
                }
            }
        }

        public Task<Session> Connect()
        {
            return InternalConnect("opc.tcp://127.0.0.1:4840", false, 0);
        }



        public SimpleOPCClient()
        {
            application = new ApplicationInstance();
            application.ApplicationConfiguration = new ApplicationConfiguration();
            application.ApplicationType = ApplicationType.Client;
            application.ConfigSectionName = "SimpleOPCClient";
            application.LoadApplicationConfiguration(false).Wait();
        }

        public string ReadNodeValue(string strNodeId)
        {
            if ((m_session == null) || (ConnectionStatus == false))
                return string.Empty;
            
            NodeId nodeId = new NodeId(strNodeId);
            DataValue val = m_session.ReadValue(nodeId);
            return val.ToString();
        }
    }
}
