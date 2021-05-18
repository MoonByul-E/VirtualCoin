
namespace Client
{
    partial class mainForm
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
            this.lbl_ID = new MetroFramework.Controls.MetroLabel();
            this.lv_coinData = new System.Windows.Forms.ListView();
            this.ch_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_myCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lbl_ID
            // 
            this.lbl_ID.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbl_ID.Location = new System.Drawing.Point(150, 29);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(627, 23);
            this.lbl_ID.TabIndex = 0;
            this.lbl_ID.Text = " ";
            this.lbl_ID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lv_coinData
            // 
            this.lv_coinData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_Name,
            this.ch_Price,
            this.ch_myCount});
            this.lv_coinData.FullRowSelect = true;
            this.lv_coinData.GridLines = true;
            this.lv_coinData.HideSelection = false;
            this.lv_coinData.Location = new System.Drawing.Point(23, 63);
            this.lv_coinData.Name = "lv_coinData";
            this.lv_coinData.Size = new System.Drawing.Size(311, 223);
            this.lv_coinData.TabIndex = 1;
            this.lv_coinData.UseCompatibleStateImageBehavior = false;
            this.lv_coinData.View = System.Windows.Forms.View.Details;
            this.lv_coinData.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lv_coinData_MouseDoubleClick);
            // 
            // ch_Name
            // 
            this.ch_Name.Text = "이름";
            // 
            // ch_Price
            // 
            this.ch_Price.Text = "현재 가격";
            this.ch_Price.Width = 114;
            // 
            // ch_myCount
            // 
            this.ch_myCount.Text = "소지 개수";
            this.ch_myCount.Width = 133;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lv_coinData);
            this.Controls.Add(this.lbl_ID);
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.Resizable = false;
            this.Text = "메인";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainForm_FormClosing);
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lbl_ID;
        private System.Windows.Forms.ListView lv_coinData;
        private System.Windows.Forms.ColumnHeader ch_Name;
        private System.Windows.Forms.ColumnHeader ch_Price;
        private System.Windows.Forms.ColumnHeader ch_myCount;
    }
}