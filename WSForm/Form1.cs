using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WSForm.FormReference;

namespace WSForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            

        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            WebService1SoapClient client = new WebService1SoapClient();
            label1.Text = client.txtfFile("web.txt");
        }
    }
}
