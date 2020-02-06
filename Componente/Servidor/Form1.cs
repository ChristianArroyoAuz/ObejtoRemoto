using System.Collections.Generic;
using System.Runtime.Remoting;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System;


namespace Servidor
{
    public partial class Form1 : Form
    {
        private void Form1_Load(object sender, EventArgs e)
        {
            RemotingConfiguration.Configure("Servidor.exe.config", false);
        }

        public Form1()
        {
            InitializeComponent();
        }
    }
}