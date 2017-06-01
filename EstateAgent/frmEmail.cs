using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstateAgent
{
    public partial class frmEmail : Form
    {
        public frmEmail()
        {
            InitializeComponent();
            webBrowser1.Navigate("estateoffourbrothers@gmail.com");
        }

        private void frmEmail_Load(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted_1(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMain formCalled = new frmMain();
            formCalled.Show();
            this.Close();
        }
    }
}
