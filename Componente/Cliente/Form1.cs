using System.Collections.Generic;
using System.Runtime.Remoting;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;
using ObjetoRemoto;
using System.Linq;
using System.Text;
using System.Data;
using System;


namespace Cliente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RemotingConfiguration.Configure("Cliente.exe.config", false);
        }

        private void btnLocal_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El cliente se ejecuta en: " + AppDomain.CurrentDomain.FriendlyName);
        }

        private void btnRemoto_Click(object sender, EventArgs e)
        {
            ObjetoRemoto.ObjetoRemoto elObjeto = new ObjetoRemoto.ObjetoRemoto();
            MessageBox.Show("El objeto remoto se ejecuta en: " + elObjeto.ObtenerDominioActual());
        }
    }
}