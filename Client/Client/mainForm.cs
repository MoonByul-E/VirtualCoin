using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSocketSharp;
using Newtonsoft.Json.Linq;
using System.Windows.Forms;

namespace Client
{
    public partial class mainForm : MetroFramework.Forms.MetroForm
    {
        WebSocket mainServer = new WebSocket(url: "ws://127.0.0.1:8888");
        private string Token;
        public string get_Token
        {
            get { return this.Token; }
            set { this.Token = value; }
        }

        public mainForm()
        {
            InitializeComponent();
            mainServer.Connect();
            mainServer.OnMessage += (sender, e) => {
                JObject revData = JObject.Parse(e.Data);

                if(revData["command"].ToString() == "alive")
                {
                    //Console.WriteLine("I`m ALIVE!");
                    JObject sendData = new JObject();
                    sendData.Add("command", "alive");
                    sendData.Add("token", Token);
                    mainServer.Send(sendData.ToString());
                }
                else if(revData["command"].ToString() == "tokenToID")
                {

                }
                
            };
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            JObject sendData = new JObject();
            sendData.Add("command", "tokenToID");
            sendData.Add("token", Token);
            mainServer.Send(sendData.ToString());
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            JObject sendData = new JObject();
            sendData.Add("command", "logout");
            sendData.Add("token", Token);
            mainServer.Send(sendData.ToString());
        }
    }
}
