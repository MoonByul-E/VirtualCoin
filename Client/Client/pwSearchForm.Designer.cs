
namespace Client
{
    partial class pwSearchForm
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
            this.tb_Name = new MetroFramework.Controls.MetroTextBox();
            this.tb_ID = new MetroFramework.Controls.MetroTextBox();
            this.cb_EMail_Domain = new MetroFramework.Controls.MetroComboBox();
            this.tb_EMail_Domain = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tb_EMail_ID = new MetroFramework.Controls.MetroTextBox();
            this.btn_pwSearch = new MetroFramework.Controls.MetroButton();
            this.tb_REPW = new MetroFramework.Controls.MetroTextBox();
            this.tb_PW = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // tb_Name
            // 
            // 
            // 
            // 
            this.tb_Name.CustomButton.Image = null;
            this.tb_Name.CustomButton.Location = new System.Drawing.Point(107, 1);
            this.tb_Name.CustomButton.Name = "";
            this.tb_Name.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tb_Name.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_Name.CustomButton.TabIndex = 1;
            this.tb_Name.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_Name.CustomButton.UseSelectable = true;
            this.tb_Name.CustomButton.Visible = false;
            this.tb_Name.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tb_Name.Lines = new string[0];
            this.tb_Name.Location = new System.Drawing.Point(23, 92);
            this.tb_Name.MaxLength = 32767;
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.PasswordChar = '\0';
            this.tb_Name.PromptText = "이름";
            this.tb_Name.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_Name.SelectedText = "";
            this.tb_Name.SelectionLength = 0;
            this.tb_Name.SelectionStart = 0;
            this.tb_Name.ShortcutsEnabled = true;
            this.tb_Name.Size = new System.Drawing.Size(129, 23);
            this.tb_Name.TabIndex = 2;
            this.tb_Name.UseSelectable = true;
            this.tb_Name.WaterMark = "이름";
            this.tb_Name.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_Name.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.tb_ID.Location = new System.Drawing.Point(23, 63);
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
            this.tb_ID.TabIndex = 1;
            this.tb_ID.UseSelectable = true;
            this.tb_ID.WaterMark = "아이디";
            this.tb_ID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_ID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // cb_EMail_Domain
            // 
            this.cb_EMail_Domain.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cb_EMail_Domain.FormattingEnabled = true;
            this.cb_EMail_Domain.ItemHeight = 19;
            this.cb_EMail_Domain.Items.AddRange(new object[] {
            "naver.com",
            "gmail.com",
            "daum.net",
            "hanmail.net",
            "직접입력"});
            this.cb_EMail_Domain.Location = new System.Drawing.Point(186, 119);
            this.cb_EMail_Domain.Name = "cb_EMail_Domain";
            this.cb_EMail_Domain.Size = new System.Drawing.Size(129, 25);
            this.cb_EMail_Domain.TabIndex = 4;
            this.cb_EMail_Domain.UseSelectable = true;
            this.cb_EMail_Domain.SelectedIndexChanged += new System.EventHandler(this.cb_EMail_Domain_SelectedIndexChanged);
            // 
            // tb_EMail_Domain
            // 
            // 
            // 
            // 
            this.tb_EMail_Domain.CustomButton.Image = null;
            this.tb_EMail_Domain.CustomButton.Location = new System.Drawing.Point(107, 1);
            this.tb_EMail_Domain.CustomButton.Name = "";
            this.tb_EMail_Domain.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tb_EMail_Domain.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_EMail_Domain.CustomButton.TabIndex = 1;
            this.tb_EMail_Domain.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_EMail_Domain.CustomButton.UseSelectable = true;
            this.tb_EMail_Domain.CustomButton.Visible = false;
            this.tb_EMail_Domain.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tb_EMail_Domain.Lines = new string[0];
            this.tb_EMail_Domain.Location = new System.Drawing.Point(186, 150);
            this.tb_EMail_Domain.MaxLength = 32767;
            this.tb_EMail_Domain.Name = "tb_EMail_Domain";
            this.tb_EMail_Domain.PasswordChar = '\0';
            this.tb_EMail_Domain.ReadOnly = true;
            this.tb_EMail_Domain.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_EMail_Domain.SelectedText = "";
            this.tb_EMail_Domain.SelectionLength = 0;
            this.tb_EMail_Domain.SelectionStart = 0;
            this.tb_EMail_Domain.ShortcutsEnabled = true;
            this.tb_EMail_Domain.Size = new System.Drawing.Size(129, 23);
            this.tb_EMail_Domain.TabIndex = 5;
            this.tb_EMail_Domain.UseSelectable = true;
            this.tb_EMail_Domain.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_EMail_Domain.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(158, 125);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(22, 19);
            this.metroLabel1.TabIndex = 7;
            this.metroLabel1.Text = "@";
            // 
            // tb_EMail_ID
            // 
            // 
            // 
            // 
            this.tb_EMail_ID.CustomButton.Image = null;
            this.tb_EMail_ID.CustomButton.Location = new System.Drawing.Point(107, 1);
            this.tb_EMail_ID.CustomButton.Name = "";
            this.tb_EMail_ID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tb_EMail_ID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_EMail_ID.CustomButton.TabIndex = 1;
            this.tb_EMail_ID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_EMail_ID.CustomButton.UseSelectable = true;
            this.tb_EMail_ID.CustomButton.Visible = false;
            this.tb_EMail_ID.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tb_EMail_ID.Lines = new string[0];
            this.tb_EMail_ID.Location = new System.Drawing.Point(23, 121);
            this.tb_EMail_ID.MaxLength = 32767;
            this.tb_EMail_ID.Name = "tb_EMail_ID";
            this.tb_EMail_ID.PasswordChar = '\0';
            this.tb_EMail_ID.PromptText = "이메일";
            this.tb_EMail_ID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_EMail_ID.SelectedText = "";
            this.tb_EMail_ID.SelectionLength = 0;
            this.tb_EMail_ID.SelectionStart = 0;
            this.tb_EMail_ID.ShortcutsEnabled = true;
            this.tb_EMail_ID.Size = new System.Drawing.Size(129, 23);
            this.tb_EMail_ID.TabIndex = 3;
            this.tb_EMail_ID.UseSelectable = true;
            this.tb_EMail_ID.WaterMark = "이메일";
            this.tb_EMail_ID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_EMail_ID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btn_pwSearch
            // 
            this.btn_pwSearch.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_pwSearch.Location = new System.Drawing.Point(20, 396);
            this.btn_pwSearch.Name = "btn_pwSearch";
            this.btn_pwSearch.Size = new System.Drawing.Size(359, 23);
            this.btn_pwSearch.TabIndex = 6;
            this.btn_pwSearch.Text = "비밀번호 찾기";
            this.btn_pwSearch.UseSelectable = true;
            this.btn_pwSearch.Click += new System.EventHandler(this.btn_pwSearch_Click);
            // 
            // tb_REPW
            // 
            // 
            // 
            // 
            this.tb_REPW.CustomButton.Image = null;
            this.tb_REPW.CustomButton.Location = new System.Drawing.Point(112, 1);
            this.tb_REPW.CustomButton.Name = "";
            this.tb_REPW.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tb_REPW.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_REPW.CustomButton.TabIndex = 1;
            this.tb_REPW.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_REPW.CustomButton.UseSelectable = true;
            this.tb_REPW.CustomButton.Visible = false;
            this.tb_REPW.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tb_REPW.Lines = new string[0];
            this.tb_REPW.Location = new System.Drawing.Point(23, 208);
            this.tb_REPW.MaxLength = 32767;
            this.tb_REPW.Name = "tb_REPW";
            this.tb_REPW.PasswordChar = '*';
            this.tb_REPW.PromptText = "변경할 비밀번호 재입력";
            this.tb_REPW.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_REPW.SelectedText = "";
            this.tb_REPW.SelectionLength = 0;
            this.tb_REPW.SelectionStart = 0;
            this.tb_REPW.ShortcutsEnabled = true;
            this.tb_REPW.Size = new System.Drawing.Size(134, 23);
            this.tb_REPW.TabIndex = 9;
            this.tb_REPW.UseSelectable = true;
            this.tb_REPW.WaterMark = "변경할 비밀번호 재입력";
            this.tb_REPW.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_REPW.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // tb_PW
            // 
            // 
            // 
            // 
            this.tb_PW.CustomButton.Image = null;
            this.tb_PW.CustomButton.Location = new System.Drawing.Point(112, 1);
            this.tb_PW.CustomButton.Name = "";
            this.tb_PW.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tb_PW.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_PW.CustomButton.TabIndex = 1;
            this.tb_PW.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_PW.CustomButton.UseSelectable = true;
            this.tb_PW.CustomButton.Visible = false;
            this.tb_PW.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tb_PW.Lines = new string[0];
            this.tb_PW.Location = new System.Drawing.Point(23, 179);
            this.tb_PW.MaxLength = 32767;
            this.tb_PW.Name = "tb_PW";
            this.tb_PW.PasswordChar = '*';
            this.tb_PW.PromptText = "변경할 비밀번호";
            this.tb_PW.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_PW.SelectedText = "";
            this.tb_PW.SelectionLength = 0;
            this.tb_PW.SelectionStart = 0;
            this.tb_PW.ShortcutsEnabled = true;
            this.tb_PW.Size = new System.Drawing.Size(134, 23);
            this.tb_PW.TabIndex = 8;
            this.tb_PW.UseSelectable = true;
            this.tb_PW.WaterMark = "변경할 비밀번호";
            this.tb_PW.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_PW.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // pwSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 439);
            this.Controls.Add(this.tb_REPW);
            this.Controls.Add(this.tb_PW);
            this.Controls.Add(this.btn_pwSearch);
            this.Controls.Add(this.cb_EMail_Domain);
            this.Controls.Add(this.tb_EMail_Domain);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.tb_EMail_ID);
            this.Controls.Add(this.tb_ID);
            this.Controls.Add(this.tb_Name);
            this.MaximizeBox = false;
            this.Name = "pwSearchForm";
            this.Resizable = false;
            this.Text = "비밀번호 찾기";
            this.Load += new System.EventHandler(this.pwSearchForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox tb_Name;
        private MetroFramework.Controls.MetroTextBox tb_ID;
        private MetroFramework.Controls.MetroComboBox cb_EMail_Domain;
        private MetroFramework.Controls.MetroTextBox tb_EMail_Domain;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox tb_EMail_ID;
        private MetroFramework.Controls.MetroButton btn_pwSearch;
        private MetroFramework.Controls.MetroTextBox tb_REPW;
        private MetroFramework.Controls.MetroTextBox tb_PW;
    }
}