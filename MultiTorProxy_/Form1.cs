using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MultiTorProxy_
{
    public partial class Form1 : Form
    {

        private int NumeroTorsProxysHabiles=0;
        public Form1()
        {
            InitializeComponent();
            panelPrincipal.Controls.Add(this.CrearBoxTor(NumeroTorsProxysHabiles));
            



        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Button button1 = sender as Button;
            if (button1.Text == "Iniciar") {
                string i = button1.Tag.ToString();

                Label ipYPuertoN = Form1.listaDeIpYPuerto[Convert.ToInt32(i)];
                ipYPuertoN.ForeColor = System.Drawing.Color.Red;
                ipYPuertoN.Text = ipYPuertoN.Text.Substring(0, ipYPuertoN.Text.IndexOf(":")) + ":" + (int.Parse(i) + 30000).ToString();
                Label ipTor = Form1.listaDeIpTor[Convert.ToInt32(i)];
                ipTor.ForeColor = System.Drawing.Color.Red;

                ProxyTor.ProxyTor_N(i);
                ipYPuertoN.ForeColor = System.Drawing.Color.Yellow;
                ipTor.ForeColor = System.Drawing.Color.Yellow;
                string IpTor = ProxyTor.CualEsNiIp(i);
                while (IpTor.Length < "0.0.0.0".Length)
                {

                    IpTor = ProxyTor.CualEsNiIp(i);
                }
                ipYPuertoN.ForeColor = System.Drawing.Color.Green;
                ipTor.ForeColor = System.Drawing.Color.Green;
                listaDeIpTor[int.Parse(i)].Text = IpTor;
                button1.Text = "Parar";
            }
            else {
                string i = button1.Tag.ToString();
                ProxyTor.KillPolipoYTor_N(i);
                button1.Text = "Iniciar";

                Label ipYPuertoN = Form1.listaDeIpYPuerto[Convert.ToInt32(i)];
                ipYPuertoN.ForeColor = System.Drawing.Color.Red;
                ipYPuertoN.Text = ipYPuertoN.Text.Substring(0, ipYPuertoN.Text.IndexOf(":")) + ":" + (int.Parse(i) + 30000).ToString();
                Label ipTor = Form1.listaDeIpTor[Convert.ToInt32(i)];
                ipTor.ForeColor = System.Drawing.Color.Red;
                ipYPuertoN.Text = "127.0.0.1:00000";
                ipTor.Text = "0.0.0.0";


                ipYPuertoN.ForeColor = System.Drawing.Color.Red;
                ipTor.ForeColor = System.Drawing.Color.Red;
            }


            
            

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }



        private void FlowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            FlowLayoutPanel flowLayoutPanel = sender as FlowLayoutPanel;
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox1 = sender as CheckBox;

            int i = Convert.ToInt32(checkBox1.Tag);
            Label ipYPuertoN = Form1.listaDeIpYPuerto[Convert.ToInt32(i)];


            if (checkBox1.Checked)
            {
                string puerto = ipYPuertoN.Text.Substring(ipYPuertoN.Text.IndexOf(":") + 1);
                
                ProxyTor.ConectarGlobalAProxy("localhost", puerto);
                checkBox1.Text = "Conectado";
            }
            else
            {
                ProxyTor.ResetearGlobalProxy();
                
                checkBox1.Text = "Desconectado";
            }
        }

        private void Label3_Click(object sender, EventArgs e)
        {
            Label label3 = sender as Label;
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            Label label1 = sender as Label;
        }




        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox2 = sender as CheckBox;

            int i = Convert.ToInt32(checkBox2.Tag);
            Label ipYPuertoN = Form1.listaDeIpYPuerto[Convert.ToInt32(i)];

            if (checkBox2.Checked == true)
            {

                ProxyTor.EjecutarChromeProxy(ipYPuertoN.Text);
                checkBox2.Text = "Conectado";
            }
            else
            {

                checkBox2.Text = "Desconectado";
            }


        }

        private void CheckBox4_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox4 = sender as CheckBox;

            int i = Convert.ToInt32(checkBox4.Tag);
            Label ipYPuertoN = Form1.listaDeIpYPuerto[Convert.ToInt32(i)];

            if (checkBox4.Checked == true)
            {

                ProxyTor.EjecutarFirefoxProxy(ipYPuertoN.Text);
                checkBox4.Text = "Conectado";
            }
            else
            {

                checkBox4.Text = "Desconectado";
            }

        }

        private void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox3 = sender as CheckBox;

            int i = Convert.ToInt32(checkBox3.Tag);
            Label ipYPuertoN = Form1.listaDeIpYPuerto[Convert.ToInt32(i)];

            
            if (checkBox3.Checked == true)
            {

                ProxyTor.EjecutarOperaProxy(ipYPuertoN.Text);
                checkBox3.Text = "Conectado";
            }
            else
            {

                checkBox3.Text = "Desconectado";
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {


            NumeroTorsProxysHabiles++;
            int i = NumeroTorsProxysHabiles;
               panelPrincipal.Controls.Add(this.CrearBoxTor(i));



        }



        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            ProxyTor.ResetearGlobalProxy();
            ProxyTor.ResetearGlobalProxyWinhttp();
            ProxyTor.KillPolipoYTorTodos();

        }







    }
}
