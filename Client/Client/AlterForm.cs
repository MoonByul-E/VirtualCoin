using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class AlterForm : MetroFramework.Forms.MetroForm
    {
        private string Alter_Title;
        private string Alter_Message;
        public string get_Alter_Title
        {
            get { return this.Alter_Title; }
            set { this.Alter_Title = value; }
        }
        public string get_Alter_Message
        {
            get { return this.Alter_Message; }
            set { this.Alter_Message = value; }
        }

        public AlterForm()
        {
            InitializeComponent();
        }

        private void AlterForm_Load(object sender, EventArgs e)
        {
            this.Text = Alter_Title;
            lbl_Alter_Message.Text = Alter_Message;
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
