using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackgammonProject2
{
    public partial class FormBegin : Form
    {
        public FormBegin()
        {
            InitializeComponent();
        }

        private void btnInstr_Click(object sender, EventArgs e)
        {

        }

        private void FormBegin_Load(object sender, EventArgs e)
        {

        }

        private void picStart_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            this.Close();
        }
    }
}
