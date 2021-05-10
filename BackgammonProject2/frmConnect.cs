using System;
using System.Collections.Generic;
using System.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace BackgammonProject2
{
    public partial class frmConnect : Form
    {
        public frmConnect()
        {
            InitializeComponent();
        }

        private void frmConnect_Load(object sender, EventArgs e)
        {
            IPAddress[] LocalIPs = Dns.GetHostAddresses(Dns.GetHostName());
            txtIP.Text = Convert.ToString(LocalIPs[LocalIPs.Length - 1]);
            // txtIP.Text = "127.0.0.1";

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (txtIP.Text != "" && txtPort.Text != "" && txtName.Text != "")
            {
                Form1.IPAddress = txtIP.Text;
                Form1.Port = txtPort.Text;
                Form1.UserName = txtName.Text;
                this.Close();
            }
            else
                MessageBox.Show("עלייך למלא את כל הנתונים");

        }
    }
}
