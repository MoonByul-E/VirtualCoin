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
    public partial class idSearchForm : MetroFramework.Forms.MetroForm
    {
        private WebSocket loginServer;
        public WebSocket get_loginServer
        {
            get { return this.loginServer; }
            set { this.loginServer = value; }
        }

        public idSearchForm()
        {
            InitializeComponent();
        }

        private void showAlter(string Title, string Message)
        {
            AlterForm alterForm = new AlterForm();
            alterForm.get_Alter_Title = Title;
            alterForm.get_Alter_Message = Message;
            alterForm.ShowDialog();
        }

        private void idSearchForm_Load(object sender, EventArgs e)
        {
            cb_EMail_Domain.SelectedIndex = 0;
        }

        private void cb_EMail_Domain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cb_EMail_Domain.Text == "직접입력")
            {
                tb_EMail_Domain.Text = "";
                tb_EMail_Domain.WaterMark = "직접입력";
                tb_EMail_Domain.ReadOnly = false;
            }
            else
            {
                tb_EMail_Domain.Text = cb_EMail_Domain.Text;
                tb_EMail_Domain.WaterMark = "";
                tb_EMail_Domain.ReadOnly = true;
            }
        }

        private void btn_idSearch_Click(object sender, EventArgs e)
        {
            //이름 입력 안함
            if(tb_Name.Text == "")
            {
                showAlter("오류!", "이름을 입력해주세요.");
                tb_Name.Focus();
            }
            //이메일 아이디 입력 안함
            else if(tb_EMail_ID.Text == "")
            {
                showAlter("오류!", "이메일을 입력해주세요.");
                tb_EMail_ID.Focus();
            }
            //이메일 도메인 입력 안함
            else if(tb_EMail_Domain.Text == "")
            {
                showAlter("오류!", "이메일을 입력해주세요.");
                tb_EMail_Domain.Focus();
            }
            //이름, 이메일 모두 입력
            else
            {
                //서버에 아이디 찾기 요청
                JObject sendData = new JObject();
                sendData.Add("command", "idSearch");
                sendData.Add("name", tb_Name.Text);
                sendData.Add("email_ID", tb_EMail_ID.Text);
                sendData.Add("email_Domain", tb_EMail_Domain.Text);
                loginServer.Send(sendData.ToString());
            }
        }
    }
}
