
namespace Client
{
    partial class loginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_ID = new MetroFramework.Controls.MetroTextBox();
            this.tb_PW = new MetroFramework.Controls.MetroTextBox();
            this.btn_Login = new MetroFramework.Controls.MetroButton();
            this.tb_ChangeLog = new MetroFramework.Controls.MetroTextBox();
            this.btn_PWSearch = new MetroFramework.Controls.MetroButton();
            this.btn_Register = new MetroFramework.Controls.MetroButton();
            this.btn_IDSearch = new MetroFramework.Controls.MetroButton();
            this.lbl_Version = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // tb_ID
            // 
            // 
            // 
            // 
            this.tb_ID.CustomButton.Image = null;
            this.tb_ID.CustomButton.Location = new System.Drawing.Point(107, 1);
            this.tb_ID.CustomButton.Name = "";
            this.tb_ID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tb_ID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_ID.CustomButton.TabIndex = 1;
            this.tb_ID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_ID.CustomButton.UseSelectable = true;
            this.tb_ID.CustomButton.Visible = false;
            this.tb_ID.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tb_ID.Lines = new string[0];
            this.tb_ID.Location = new System.Drawing.Point(20, 364);
            this.tb_ID.MaxLength = 32767;
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.PasswordChar = '\0';
            this.tb_ID.PromptText = "아이디";
            this.tb_ID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_ID.SelectedText = "";
            this.tb_ID.SelectionLength = 0;
            this.tb_ID.SelectionStart = 0;
            this.tb_ID.ShortcutsEnabled = true;
            this.tb_ID.Size = new System.Drawing.Size(129, 23);
            this.tb_ID.TabIndex = 0;
            this.tb_ID.UseSelectable = true;
            this.tb_ID.WaterMark = "아이디";
            this.tb_ID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_ID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // tb_PW
            // 
            // 
            // 
            // 
            this.tb_PW.CustomButton.Image = null;
            this.tb_PW.CustomButton.Location = new System.Drawing.Point(107, 1);
            this.tb_PW.CustomButton.Name = "";
            this.tb_PW.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tb_PW.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_PW.CustomButton.TabIndex = 1;
            this.tb_PW.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_PW.CustomButton.UseSelectable = true;
            this.tb_PW.CustomButton.Visible = false;
            this.tb_PW.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tb_PW.Lines = new string[0];
            this.tb_PW.Location = new System.Drawing.Point(20, 393);
            this.tb_PW.MaxLength = 32767;
            this.tb_PW.Name = "tb_PW";
            this.tb_PW.PasswordChar = '*';
            this.tb_PW.PromptText = "비밀번호";
            this.tb_PW.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_PW.SelectedText = "";
            this.tb_PW.SelectionLength = 0;
            this.tb_PW.SelectionStart = 0;
            this.tb_PW.ShortcutsEnabled = true;
            this.tb_PW.Size = new System.Drawing.Size(129, 23);
            this.tb_PW.TabIndex = 1;
            this.tb_PW.UseSelectable = true;
            this.tb_PW.WaterMark = "비밀번호";
            this.tb_PW.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_PW.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_PW.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_PW_KeyDown);
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(155, 364);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(52, 52);
            this.btn_Login.TabIndex = 2;
            this.btn_Login.Text = "로그인";
            this.btn_Login.UseSelectable = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // tb_ChangeLog
            // 
            // 
            // 
            // 
            this.tb_ChangeLog.CustomButton.Image = null;
            this.tb_ChangeLog.CustomButton.Location = new System.Drawing.Point(65, 1);
            this.tb_ChangeLog.CustomButton.Name = "";
            this.tb_ChangeLog.CustomButton.Size = new System.Drawing.Size(293, 293);
            this.tb_ChangeLog.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_ChangeLog.CustomButton.TabIndex = 1;
            this.tb_ChangeLog.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_ChangeLog.CustomButton.UseSelectable = true;
            this.tb_ChangeLog.CustomButton.Visible = false;
            this.tb_ChangeLog.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tb_ChangeLog.Lines = new string[0];
            this.tb_ChangeLog.Location = new System.Drawing.Point(20, 63);
            this.tb_ChangeLog.MaxLength = 32767;
            this.tb_ChangeLog.Multiline = true;
            this.tb_ChangeLog.Name = "tb_ChangeLog";
            this.tb_ChangeLog.PasswordChar = '\0';
            this.tb_ChangeLog.ReadOnly = true;
            this.tb_ChangeLog.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_ChangeLog.SelectedText = "";
            this.tb_ChangeLog.SelectionLength = 0;
            this.tb_ChangeLog.SelectionStart = 0;
            this.tb_ChangeLog.ShortcutsEnabled = true;
            this.tb_ChangeLog.Size = new System.Drawing.Size(359, 295);
            this.tb_ChangeLog.TabIndex = 3;
            this.tb_ChangeLog.UseSelectable = true;
            this.tb_ChangeLog.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_ChangeLog.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btn_PWSearch
            // 
            this.btn_PWSearch.Location = new System.Drawing.Point(299, 364);
            this.btn_PWSearch.Name = "btn_PWSearch";
            this.btn_PWSearch.Size = new System.Drawing.Size(80, 23);
            this.btn_PWSearch.TabIndex = 4;
            this.btn_PWSearch.Text = "비밀번호 찾기";
            this.btn_PWSearch.UseSelectable = true;
            this.btn_PWSearch.Click += new System.EventHandler(this.btn_PWSearch_Click);
            // 
            // btn_Register
            // 
            this.btn_Register.Location = new System.Drawing.Point(213, 393);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(80, 23);
            this.btn_Register.TabIndex = 5;
            this.btn_Register.Text = "회원가입";
            this.btn_Register.UseSelectable = true;
            this.btn_Register.Click += new System.EventHandler(this.btn_Register_Click);
            // 
            // btn_IDSearch
            // 
            this.btn_IDSearch.Location = new System.Drawing.Point(213, 364);
            this.btn_IDSearch.Name = "btn_IDSearch";
            this.btn_IDSearch.Size = new System.Drawing.Size(80, 23);
            this.btn_IDSearch.TabIndex = 6;
            this.btn_IDSearch.Text = "아이디 찾기";
            this.btn_IDSearch.UseSelectable = true;
            this.btn_IDSearch.Click += new System.EventHandler(this.btn_IDSearch_Click);
            // 
            // lbl_Version
            // 
            this.lbl_Version.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lbl_Version.ForeColor = System.Drawing.Color.Gray;
            this.lbl_Version.Location = new System.Drawing.Point(299, 393);
            this.lbl_Version.Name = "lbl_Version";
            this.lbl_Version.Size = new System.Drawing.Size(80, 23);
            this.lbl_Version.TabIndex = 7;
            this.lbl_Version.Text = "Ver.1.0.0";
            this.lbl_Version.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lbl_Version.UseCustomForeColor = true;
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(399, 439);
            this.Controls.Add(this.lbl_Version);
            this.Controls.Add(this.btn_IDSearch);
            this.Controls.Add(this.btn_Register);
            this.Controls.Add(this.btn_PWSearch);
            this.Controls.Add(this.tb_ChangeLog);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.tb_PW);
            this.Controls.Add(this.tb_ID);
            this.Font = new System.Drawing.Font("둥근모꼴", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MaximizeBox = false;
            this.Name = "loginForm";
            this.Padding = new System.Windows.Forms.Padding(17, 60, 17, 20);
            this.Resizable = false;
            this.Text = "로그인";
            this.Load += new System.EventHandler(this.loginForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox tb_ID;
        private MetroFramework.Controls.MetroTextBox tb_PW;
        private MetroFramework.Controls.MetroButton btn_Login;
        private MetroFramework.Controls.MetroTextBox tb_ChangeLog;
        private MetroFramework.Controls.MetroButton btn_PWSearch;
        private MetroFramework.Controls.MetroButton btn_Register;
        private MetroFramework.Controls.MetroButton btn_IDSearch;
        private MetroFramework.Controls.MetroLabel lbl_Version;
    }
}