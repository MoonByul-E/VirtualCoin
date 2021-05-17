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
    public partial class loginForm : MetroFramework.Forms.MetroForm
    {
        string nowVersion = "1.0.0";
        WebSocket loginServer = new WebSocket(url: "ws://127.0.0.1:7777");
        idSearchForm idSearchForm;
        pwSearchForm pwSearchForm;

        public loginForm()
        {
            InitializeComponent();
            loginServer.Connect();
            loginServer.OnMessage += (sender, e) =>
            {
                JObject revData = JObject.Parse(e.Data);
                //Console.WriteLine(revData);

                //최신 버전 정보 데이터 받음
                if(revData["command"].ToString() == "version")
                {
                    //현재 버전이 최신 버전일때
                    if(nowVersion == revData["version"].ToString())
                    {
                        JObject sendData = new JObject();
                        sendData.Add("command", "changeLog");
                        loginServer.Send(sendData.ToString());
                    }
                    //현재 버전이 최신 버전이 아닐때
                    else
                    {
                        showAlter("업데이트 필요.", "현재 버전: " + nowVersion + "\n최신 버전: " + revData["version"].ToString());
                        Application.Exit();
                    }
                }
                //체인지 로그 데이터 받음
                else if(revData["command"].ToString() == "changeLog")
                {
                    tb_ChangeLog.Text = revData["changeLog"].ToString();
                }
                //로그인 데이터 받음
                else if(revData["command"].ToString() == "login")
                {
                    Console.WriteLine(revData);
                }
                //아이디 찾기 데이터 받음
                else if (revData["command"].ToString() == "idSearch")
                {
                    //아이디 찾기 성공
                    if(revData["result"].ToString() == "success")
                    {
                        showAlter("아이디 찾기", "아이디: " + revData["id"].ToString());
                        idSearchForm.Close();
                    }
                    //아이디 찾기 실패
                    else
                    {
                        showAlter("아이디 찾기", "입력하신 정보가 올바르지 않습니다.");
                    }
                }
                //비밀번호 찾기 데이터 받음
                else if(revData["command"].ToString() == "pwSearch")
                {
                    //비밀번호 찾기 성공
                    if(revData["result"].ToString() == "success")
                    {
                        showAlter("비밀번호 변경", "비밀번호가 성공적으로 변경 되었습니다.");
                        pwSearchForm.Close();
                    }
                    //비밀번호 찾기 실패
                    else
                    {
                        showAlter("비밀번호 찾기", "입력하신 정보가 올바르지 않습니다.");
                    }
                }
            };
        }

        private void showAlter(string Title, string Message)
        {
            AlterForm alterForm = new AlterForm();
            alterForm.get_Alter_Title = Title;
            alterForm.get_Alter_Message = Message;
            alterForm.ShowDialog();
        }

        private void loginForm_Load(object sender, EventArgs e)
        {
            JObject sendData = new JObject();
            sendData.Add("command", "version");
            loginServer.Send(sendData.ToString());
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            //아이디 입력 안함
            if(tb_ID.Text == "")
            {
                showAlter("오류!", "아이디를 입력해주세요.");
                tb_ID.Focus();
            }
            //비밀번호 입력 안함
            else if(tb_PW.Text == "")
            {
                showAlter("오류!", "비밀번호를 입력해주세요.");
                tb_PW.Focus();
            }
            //아이디, 비밀번호 모두 입력
            else
            {
                //서버에 로그인 요청
                JObject sendData = new JObject();
                sendData.Add("command", "login");
                sendData.Add("id", tb_ID.Text);
                sendData.Add("pw", tb_PW.Text);
                loginServer.Send(sendData.ToString());
            }
        }

        private void tb_PW_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btn_Login_Click(sender, e);
            }
        }

        private void btn_IDSearch_Click(object sender, EventArgs e)
        {
            idSearchForm = new idSearchForm();
            idSearchForm.get_loginServer = loginServer;
            idSearchForm.ShowDialog();
        }

        private void btn_PWSearch_Click(object sender, EventArgs e)
        {
            pwSearchForm = new pwSearchForm();
            pwSearchForm.get_loginServer = loginServer;
            pwSearchForm.ShowDialog();
        }
    }
}
