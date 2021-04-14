using SwissTransport.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTransportApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ITransport transport = new Transport();

        private void StartortSuchleiste1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SuchenButton1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
