using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices;
using Microsoft.Win32;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System.Net;
// OpenQA.Selenium.IE;
//using OpenQA.Selenium.PhantomJS;



namespace MultiTorProxy_
{
    class ProxyTor
    {
        [DllImport("wininet.dll")]
        public static extern bool InternetSetOption(IntPtr hInternet, int dwOption, IntPtr lpBuffer, int dwBufferLength);
        public const int INTERNET_OPTION_SETTINGS_CHANGED = 39;
        public const int INTERNET_OPTION_REFRESH = 37;
        static bool settingsReturn, refreshReturn;


        public static string ProgramaEjecutaTors = "1_start_un_tor_n.bat";
        public static string ProgramaEjecutaPoliposProxy = "2_start_un_polipo_n.bat";
        public static string ProgramaTerminaPoliposProxy = "3_stop_all_tor.bat";
        public static string ProgramaTerminaTors = "4_stop_all_polipo.bat";



        public static void ProxyTor_N(string n)
        {
            string log = "\\hardlinkCopy.log ";
            string path = Directory.GetCurrentDirectory();


            string comando = "\\hardlinkCopyFile.bat ";

            EjecutarTORyPolipo_N(Directory.GetCurrentDirectory() + "\\" + ProgramaEjecutaTors, Directory.GetCurrentDirectory() + "\\" + ProgramaEjecutaPoliposProxy, n, 0);

        }


        public static void EjecutarTORyPolipo_N(string pathCompletoProgramaEjecutaTors, string pathCompletoProgramaEjecutaPoliposProxys, string N, int mutexPrint)
        {

            System.Diagnostics.Process myProcessTor = new System.Diagnostics.Process();
            myProcessTor.StartInfo.Arguments = " " + N;
            myProcessTor.StartInfo.UseShellExecute = true;
            myProcessTor.StartInfo.FileName = pathCompletoProgramaEjecutaTors;
            myProcessTor.StartInfo.CreateNoWindow = true;
            myProcessTor.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;

            //myProcessTor.StartInfo.RedirectStandardOutput = true;
            //Console.WriteLine(myProcessTor.StandardOutput.ReadToEnd());
            myProcessTor.Start();

            System.Threading.Thread.Sleep(1000);

            System.Diagnostics.Process myProcessProxy = new System.Diagnostics.Process();
            myProcessProxy.StartInfo.Arguments = " " + N;
            myProcessProxy.StartInfo.UseShellExecute = true;
            myProcessProxy.StartInfo.FileName = pathCompletoProgramaEjecutaPoliposProxys;
            myProcessProxy.StartInfo.CreateNoWindow = true;
            myProcessTor.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            myProcessProxy.Start();



            myProcessProxy.WaitForExit(System.Threading.Timeout.Infinite);

            int exitCode = myProcessProxy.ExitCode;
            myProcessProxy.Close();
            if (exitCode != 0)
            {
                switch (exitCode)
                {
                    case 1:
                        throw new ApplicationException("IFilter Extraction Failed");
                        MessageBox.Show("myProcessProxy: IFilter Extraction Failed");
                    default:
                        throw new ApplicationException("Unknown Exit Code:" + exitCode.ToString());
                        MessageBox.Show("myProcessProxy: Unknown Exit Code:" + exitCode.ToString());
                }
            }

            myProcessTor.WaitForExit(System.Threading.Timeout.Infinite);

            myProcessTor.Close();
            if (exitCode != 0)
            {
                switch (exitCode)
                {
                    case 1:
                        throw new ApplicationException("IFilter Extraction Failed");
                        MessageBox.Show("myProcessTor: IFilter Extraction Failed");
                    default:
                        throw new ApplicationException("Unknown Exit Code:" + exitCode.ToString());
                        MessageBox.Show("myProcessTor: Unknown Exit Code:" + exitCode.ToString());
                }
            }

            //Label ipYPuertoN = Form1.listaDeIpYPuerto[Convert.ToInt32(N)];
            //ipYPuertoN.ForeColor = System.Drawing.Color.Red;
            //ipYPuertoN.Text = ipYPuertoN.Text.Substring(0, ipYPuertoN.Text.IndexOf(":")) + ":" + (int.Parse(N) + 30000).ToString();


            


        }
        public static void KillPolipoYTor_N(string N)
        {

            System.Diagnostics.Process myProcessTor = new System.Diagnostics.Process();
            myProcessTor.StartInfo.Arguments = " " + N;
            myProcessTor.StartInfo.UseShellExecute = true;
            myProcessTor.StartInfo.FileName =  Directory.GetCurrentDirectory() + "\\" + "3_stop_un_tor_n.bat";
            myProcessTor.StartInfo.CreateNoWindow = true;
            myProcessTor.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;

            //myProcessTor.StartInfo.RedirectStandardOutput = true;
            //Console.WriteLine(myProcessTor.StandardOutput.ReadToEnd());
            myProcessTor.Start();

            

            System.Threading.Thread.Sleep(1000);

            System.Diagnostics.Process myProcessProxy = new System.Diagnostics.Process();
            myProcessProxy.StartInfo.Arguments = " " + N;
            myProcessProxy.StartInfo.UseShellExecute = true;
            myProcessProxy.StartInfo.FileName = Directory.GetCurrentDirectory() + "\\" + "4_stop_un_polipo_n.bat";
            myProcessProxy.StartInfo.CreateNoWindow = true;
            myProcessTor.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            myProcessProxy.Start();

            myProcessTor.WaitForExit();
            myProcessProxy.WaitForExit();







        }

        public static void KillPolipoYTorTodos()
        {

            System.Diagnostics.Process myProcessTor = new System.Diagnostics.Process();
            
            myProcessTor.StartInfo.UseShellExecute = true;
            myProcessTor.StartInfo.FileName = Directory.GetCurrentDirectory() + "\\" + "3_stop_all_tor.bat";
            myProcessTor.StartInfo.CreateNoWindow = true;
            myProcessTor.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;

            //myProcessTor.StartInfo.RedirectStandardOutput = true;
            //Console.WriteLine(myProcessTor.StandardOutput.ReadToEnd());
            myProcessTor.Start();



            System.Threading.Thread.Sleep(1000);

            System.Diagnostics.Process myProcessProxy = new System.Diagnostics.Process();
            
            myProcessProxy.StartInfo.UseShellExecute = true;
            myProcessProxy.StartInfo.FileName = Directory.GetCurrentDirectory() + "\\" + "4_stop_all_polipo.bat";
            myProcessProxy.StartInfo.CreateNoWindow = true;
            myProcessTor.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            myProcessProxy.Start();

            myProcessTor.WaitForExit();
            myProcessProxy.WaitForExit();







        }
        public static void EjecutarChromeProxy( string ipYpuerto)
        {

            System.Diagnostics.Process myProcess = new System.Diagnostics.Process();
            myProcess.StartInfo.Arguments = " --proxy-server="+ipYpuerto+ " https://www.cual-es-mi-ip.net/";
            myProcess.StartInfo.UseShellExecute = true;
            myProcess.StartInfo.FileName = "chrome.exe";
            myProcess.StartInfo.CreateNoWindow = false;
            myProcess.Start();

            //myProcess.WaitForExit();
            
        }
        public static void EjecutarOperaProxy(string ipYpuerto)
        {

            System.Diagnostics.Process myProcess = new System.Diagnostics.Process();
            myProcess.StartInfo.Arguments = " --proxy-server=" + ipYpuerto+" https://www.cual-es-mi-ip.net/";
            myProcess.StartInfo.UseShellExecute = true;
            myProcess.StartInfo.FileName = "opera.exe";
            myProcess.StartInfo.CreateNoWindow = false;
            myProcess.Start();

            //myProcess.WaitForExit();

        }

        public static void EjecutarFirefoxProxy(string ipYPuerto)
        {

            try
            {
                FirefoxProfile profile = new FirefoxProfile();
                String PROXY = ipYPuerto;
                OpenQA.Selenium.Proxy proxy = new OpenQA.Selenium.Proxy();
                proxy.HttpProxy = PROXY;
                proxy.FtpProxy = PROXY;
                proxy.SslProxy = PROXY;
                profile.SetProxyPreferences(proxy);
                FirefoxOptions options = new FirefoxOptions();
                options.Profile = profile;
                options.AddArgument("https://www.cual-es-mi-ip.net");
                
                FirefoxDriver driver = new FirefoxDriver(options);
                driver.Close();

            }
            catch {
            }

        }

        public static void ConectarGlobalAProxy(string ip, string port)
        {

    

            RegistryKey registry = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings", true);
            registry.SetValue("ProxyEnable", 1);
            registry.SetValue("ProxyServer", ip+":" + port);



        }

        public static void ResetearGlobalProxy()
        {


            RegistryKey registry = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings", true);
            registry.SetValue("ProxyEnable", 0);
            

            //These lines implement the Interface in the beginning of program 
            //They cause the OS to refresh the settings, causing IP to realy update
            settingsReturn = InternetSetOption(IntPtr.Zero, INTERNET_OPTION_SETTINGS_CHANGED, IntPtr.Zero, 0);
            refreshReturn = InternetSetOption(IntPtr.Zero, INTERNET_OPTION_REFRESH, IntPtr.Zero, 0);


            //System.Diagnostics.Process myProcessTor = new System.Diagnostics.Process();
            //myProcessTor.StartInfo.Arguments = " winhttp reset proxy";
            //myProcessTor.StartInfo.UseShellExecute = true;
            //myProcessTor.StartInfo.FileName = "netsh";
            //myProcessTor.StartInfo.CreateNoWindow = false;
            //myProcessTor.Start();

            //myProcessTor.WaitForExit();

        }

        public static void ResetearGlobalProxyWinhttp()
        {



            System.Diagnostics.Process myProcessTor = new System.Diagnostics.Process();
            myProcessTor.StartInfo.Arguments = " winhttp reset proxy";
            myProcessTor.StartInfo.UseShellExecute = true;
            myProcessTor.StartInfo.FileName = "netsh";
            myProcessTor.StartInfo.CreateNoWindow = false;
            myProcessTor.Start();

            myProcessTor.WaitForExit();

        }

        public static string CualEsNiIp(string i)
        {


            try{
                Label ipYPuertoN = Form1.listaDeIpYPuerto[Convert.ToInt32(i)];
                ipYPuertoN.ForeColor = System.Drawing.Color.Yellow;



                // Create a new request to the mentioned URL.				

                WebRequest myWebRequest = WebRequest.Create("https://api.ipify.org");
                string proxyDir = "localhost";

                
                WebProxy myProxy = new WebProxy(proxyDir, 30000+int.Parse(i));
                // Obtain the Proxy Prperty of the  Default browser.  

                myWebRequest.Proxy = myProxy;
                myWebRequest.Method = "GET";

                HttpWebResponse myWebResponse = (HttpWebResponse)myWebRequest.GetResponse();
                StreamReader stream = new StreamReader(myWebResponse.GetResponseStream(), Encoding.UTF8);
                string str = stream.ReadLine();
                return str;
            }
            catch {
                string str = "";
                return str;
            }


            
            
        }

    }
}
