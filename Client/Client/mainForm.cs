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
    public partial class mainForm : MetroFramework.Forms.MetroForm
    {
        private string Token;
        public string get_Token
        {
            get { return this.Token; }
            set { this.Token = value; }
        }

        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            Console.WriteLine(Token);
        }
    }
}
