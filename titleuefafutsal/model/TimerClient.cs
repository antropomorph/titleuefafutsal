using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace titleuefafutsal.model
{
    public class RemoteClient
    {
        private const int SLEEP_TIME = 10;
        public delegate void MessageStreamDelegate(string str);
        public event MessageStreamDelegate LogMessage = delegate { };
        public event MessageStreamDelegate SetHomeScore = delegate { };
        public event MessageStreamDelegate SetGuestScore = delegate { };
        public event MessageStreamDelegate SetHomeFouls = delegate { };
        public event MessageStreamDelegate SetGuestFouls = delegate { };

        private Thread threadProcessRemoteData;
        private bool isStarted = false;
        private string remoteServerIPAddress;
        private string remoteServerPort;
        private Settings gameInfo;

        public bool IsStarted { get => isStarted; }

        public RemoteClient(Settings gameInfo)
        {
            this.remoteServerIPAddress = gameInfo.TimeServerAddress;
            this.remoteServerPort = gameInfo.TimeServerPort;
            this.gameInfo = gameInfo;
        }

        public void Stop()
        {
            isStarted = false;
        }

        public void Start()
        {
            isStarted = true;
            threadProcessRemoteData = new Thread(ProcessRemoteData);
            threadProcessRemoteData.IsBackground = true;
            threadProcessRemoteData.Start();
        }

        private void SendMessage(TcpClient client, string message)
        {
            byte[] data = Encoding.ASCII.GetBytes(message);
            client.GetStream().Write(data, 0, data.Length);
        }

        private void ProcessRemoteData()
        {
            dynamic matchInfo;
            TcpClient tcpClient = new TcpClient();
            TcpClient tcpLocalClient = new TcpClient();

            try
            {
                tcpClient.Connect(IPAddress.Parse(remoteServerIPAddress), Convert.ToInt32(remoteServerPort));
            }
            catch (Exception ex)
            {
                LogMessage(ex.Message);
                isStarted = false;
            }

            if (tcpClient.Connected)
            {
                NetworkStream stream = tcpClient.GetStream();
                StringBuilder responseData = new StringBuilder();
                StreamReader binaryReader = new StreamReader(stream);

                while (isStarted)
                {
                    if (tcpClient.Available > 0)
                    {
                        responseData.Append(binaryReader.ReadLine());
                        try
                        {
                            StringBuilder message = new StringBuilder();
                            matchInfo = JsonConvert.DeserializeObject(responseData.ToString());
                            if (matchInfo.gameTimer != null)
                            {
                                //gameInfo.Timer = (string)matchInfo.gameTimer;
                                //message.AppendLine(gameInfo.GetTimer());
                                TimeSpan TimerMS = TimeSpan.FromMilliseconds(Convert.ToDouble((string)matchInfo.gameTimer));
                                gameInfo.Timer = String.Format("{0}:{1:D2}", TimerMS.Minutes, TimerMS.Seconds);
                                LogMessage(gameInfo.Timer);
                                //LogMessage((string)matchInfo.gameTimer);
                            }
                            if (matchInfo.leftScore != null)
                            {
                                gameInfo.HomeScore = (string)matchInfo.leftScore;
                                SetHomeScore(gameInfo.HomeScore);
                                //message.AppendLine(gameInfo.GetHomeScore());
                            }
                            if (matchInfo.rightScore != null)
                            {
                                gameInfo.GuestScore = (string)matchInfo.rightScore;
                                SetGuestScore(gameInfo.GuestScore);
                                //message.AppendLine(gameInfo.GetGuestScore());
                            }
                            if (matchInfo.leftFoul != null)
                            {
                                gameInfo.HomeFouls = (int)matchInfo.leftFoul;
                                SetHomeFouls(gameInfo.HomeFouls.ToString());
                                //message.AppendLine(gameInfo.GetHomeFouls());
                            }
                            if (matchInfo.rightFoul != null)
                            {
                                gameInfo.GuestFouls = (int)matchInfo.rightFoul;
                                SetGuestFouls(gameInfo.GuestFouls.ToString());
                                //message.AppendLine(gameInfo.GetGuestFouls());
                            }

                            //message.AppendLine(responseData.ToString());

                            if (message.Capacity > 0)
                            {
                                //SendMessage(tcpLocalClient, message.ToString());
                                //LogMessage(message.ToString());
                            }
                        }
                        catch (Newtonsoft.Json.JsonReaderException ex)
                        {
                            LogMessage(ex.Message);
                        }

                        responseData.Clear();
                        if (!tcpClient.Connected)
                        {
                            LogMessage("Not connected!");
                        }
                    }
                    Thread.Sleep(SLEEP_TIME);
                }
                tcpClient.Close();
            }
        }
    }
}
