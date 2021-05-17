
namespace Client
{
    partial class AlterForm
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
            this.lbl_Alter_Message = new MetroFramework.Controls.MetroLabel();
            this.btn_OK = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // lbl_Alter_Message
            // 
            this.lbl_Alter_Message.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Alter_Message.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbl_Alter_Message.Location = new System.Drawing.Point(20, 60);
            this.lbl_Alter_Message.Name = "lbl_Alter_Message";
            this.lbl_Alter_Message.Size = new System.Drawing.Size(339, 102);
            this.lbl_Alter_Message.TabIndex = 0;
            this.lbl_Alter_Message.Text = "lbl_Alter_Message";
            // 
            // btn_OK
            // 
            this.btn_OK.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_OK.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btn_OK.Location = new System.Drawing.Point(20, 124);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(339, 38);
            this.btn_OK.TabIndex = 1;
            this.btn_OK.Text = "확인";
            this.btn_OK.UseSelectable = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // AlterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 182);
            this.ControlBox = false;
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.lbl_Alter_Message);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AlterForm";
            this.Resizable = false;
            this.Text = "오류!";
            this.Load += new System.EventHandler(this.AlterForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lbl_Alter_Message;
        private MetroFramework.Controls.MetroButton btn_OK;
    }
}