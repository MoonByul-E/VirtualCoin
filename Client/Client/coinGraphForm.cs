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
    public partial class coinGraphForm : MetroFramework.Forms.MetroForm
    {
        private string coinName;
        public string get_coinName
        {
            get { return this.coinName; }
            set { this.coinName = value; }
        }

        public coinGraphForm()
        {
            InitializeComponent();
        }

        private void coinGraphForm_Load(object sender, EventArgs e)
        {
            lbl_coinName.Text = coinName;
            ct_Price.Series[0].Name = coinName;
        }
    }
}
