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

                //생존 응답
                if(revData["command"].ToString() == "alive")
                {
                    //Console.WriteLine("I`m ALIVE!");
                    JObject sendData = new JObject();
                    sendData.Add("command", "alive");
                    sendData.Add("token", Token);
                    mainServer.Send(sendData.ToString());
                }
                //로그인 토큰으로 아이디 구하기
                else if(revData["command"].ToString() == "tokenToID")
                {
                    lbl_ID.Text = "ID: " + revData["id"].ToString();
                }
                //코인 정보 불러오기
                else if(revData["command"].ToString() == "coinData")
                {
                    for(int i = 0; i < revData["name"].Count(); i++)
                    {
                        ListViewItem coinItem = new ListViewItem(revData["name"][i].ToString());
                        coinItem.SubItems.Add(revData["price"][i].ToString() + " 원");
                        coinItem.SubItems.Add(i.ToString());
                        lv_coinData.Items.Add(coinItem);
                    }
                }
                //내정보 불러오기
                else if(revData["command"].ToString() == "myData")
                {
                    for (int i = 0; i < JArray.Parse(revData["coinData"].ToString()).Count(); i++)
                    {
                        //Console.WriteLine(lv_coinData.Items[i].SubItems[2].Text);

                        lv_coinData.Items[i].SubItems[2].Text = JArray.Parse(revData["coinData"].ToString())[i] + " 개";
                        /*ListViewItem coinItem = new ListViewItem(lv_coinData.Items.);
                        coinItem.SubItems.Add(revData["price"][i].ToString() + " 원");
                        //coinItem.SubItems.Add(i + " 개");
                        lv_coinData.Items.Add(coinItem);*/
                    }
                    //Console.WriteLine(JArray.Parse(revData["coinData"].ToString()));
                }
            };
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            JObject sendData = new JObject();
            sendData.Add("command", "tokenToID");
            sendData.Add("token", Token);
            mainServer.Send(sendData.ToString());

            sendData = new JObject();
            sendData.Add("command", "coinData");
            mainServer.Send(sendData.ToString());

            sendData = new JObject();
            sendData.Add("command", "myData");
            sendData.Add("token", Token);
            mainServer.Send(sendData.ToString());
        }

        private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            JObject sendData = new JObject();
            sendData.Add("command", "logout");
            sendData.Add("token", Token);
            mainServer.Send(sendData.ToString());
        }

        //리스트뷰 클릭시
        private void lv_coinData_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(lv_coinData.SelectedItems.Count == 1)
            {
                ListView.SelectedListViewItemCollection items = lv_coinData.SelectedItems;
                ListViewItem listViewItem = items[0];

                coinGraphForm coinGraphForm = new coinGraphForm();
                coinGraphForm.get_coinName = listViewItem.SubItems[0].Text;
                coinGraphForm.ShowDialog();
                Console.WriteLine(listViewItem.SubItems[0].Text);
            }
        }
    }
}
