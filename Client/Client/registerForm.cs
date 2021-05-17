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
    public partial class registerForm : MetroFramework.Forms.MetroForm
    {
        private WebSocket loginServer;
        public WebSocket get_loginServer
        {
            get { return this.loginServer; }
            set { this.loginServer = value; }
        }
        public registerForm()
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

        private void registerForm_Load(object sender, EventArgs e)
        {
            cb_EMail_Domain.SelectedIndex = 0;
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            //아이디 입력 안함
            if (tb_ID.Text == "")
            {
                showAlter("오류!", "아이디를 입력해주세요.");
                tb_ID.Focus();
            }
            //비밀번호 입력 안함
            else if (tb_PW.Text == "")
            {
                showAlter("오류!", "비밀번호를 입력해주세요.");
                tb_PW.Focus();
            }
            //비밀번호 재입력 안함
            else if (tb_REPW.Text == "")
            {
                showAlter("오류!", "비밀번호를 다시 입력해주세요.");
                tb_REPW.Focus();
            }
            //비밀번호 일치 안함
            else if (tb_PW.Text != tb_REPW.Text)
            {
                showAlter("오류!", "비밀번호가 일치 하지 않습니다.");
                tb_REPW.Focus();
            }
            //이름 입력 안함
            else if (tb_Name.Text == "")
            {
                showAlter("오류!", "이름을 입력해주세요.");
                tb_Name.Focus();
            }
            //이메일 아이디 입력 안함
            else if (tb_EMail_ID.Text == "")
            {
                showAlter("오류!", "이메일을 입력해주세요.");
                tb_EMail_ID.Focus();
            }
            //이메일 도메인 입력 안함
            else if (tb_EMail_Domain.Text == "")
            {
                showAlter("오류!", "이메일을 입력해주세요.");
                tb_EMail_Domain.Focus();
            }
            //모두 입력함
            else
            {
                //서버에 회원가입 요청
                JObject sendData = new JObject();
                sendData.Add("command", "register");
                sendData.Add("id", tb_ID.Text);
                sendData.Add("pw", tb_PW.Text);
                sendData.Add("name", tb_Name.Text);
                sendData.Add("email_ID", tb_EMail_ID.Text);
                sendData.Add("email_Domain", tb_EMail_Domain.Text);
                loginServer.Send(sendData.ToString());
            }
        }

        private void cb_EMail_Domain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_EMail_Domain.Text == "직접입력")
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
    }
}
