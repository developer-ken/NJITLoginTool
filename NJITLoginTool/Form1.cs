using CefSharp;
using CefSharp.WinForms;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NJITLoginTool
{
    public partial class Form1 : Form
    {
        private ChromiumWebBrowser bro;
        private CookieVisitor cookievi;
        public Form1()
        {
            InitializeComponent();
            cookievi = new CookieVisitor();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var settings = new CefSettings()
            {
                CachePath = System.IO.Path.GetFullPath("./cache"),
                PersistSessionCookies = true
            };
            Cef.Initialize(settings);
            finPannel.Hide();
            devid.Text = Guid.NewGuid().ToString();
            bro = new ChromiumWebBrowser("http://authserver.njit.edu.cn/authserver/login?service=https%3A%2F%2Fnjit.campusphere.net%2Fwec-counselor-sign-apps%2Fstu%2Fsign%2FsubmitSign")
            {
                Dock = DockStyle.Fill
            };
            this.Controls.Add(bro);
            bro.AddressChanged += Bro_AddressChanged;
            cookievi.SendCookie += Cookievi_SendCookie;
        }

        private void Cookievi_SendCookie(Cookie obj)
        {

            if (obj.Name == "MOD_AUTH_CAS")
            {
                CAS.Text = obj.Value;
                finPannel.Show();
            }
        }

        private void Bro_AddressChanged(object sender, AddressChangedEventArgs e)
        {
            string url = e.Address;
            if(url == "https://njit.campusphere.net/wec-counselor-sign-apps/stu/sign/submitSign")
            {
                bro.GetCookieManager().VisitAllCookies(cookievi);
            }
        }

        private void cpd_ext_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void stuid_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (stuid.Text.Length < 1)
                {
                    res.Text = "请填写您的用户信息和定位信息";
                    cpd_ext.Text = "缺少学号";
                    return;
                }
                JObject jb = new JObject();
                jb.Add("systemName", sysname.Text);
                jb.Add("systemVersion", sysver.Text);
                jb.Add("model", devmodel.Text);
                jb.Add("deviceId", devid.Text);
                jb.Add("appVersion", cliver.Text);
                jb.Add("lat", double.Parse(Location.Text.Split(',')[0]));
                jb.Add("lon", double.Parse(Location.Text.Split(',')[1]));
                jb.Add("userId", stuid.Text);
                string str = jb.ToString();
                cpd_ext.Text = Encrypt.Des.Encrypt(str, desKey.Text);

                res.Text = stuid.Text+"\n"+CAS.Text+"\n"+cpd_ext.Text+"\n"+Location.Text+","+locationName.Text.Replace(",","，")+"\n\n" +
                    "# 按Ctrl+S导出用户授权";
            }
            catch
            {
                cpd_ext.Text = "####加密运算错误####";
                res.Text = "";
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.Control&&e.KeyCode == Keys.S)
            {
                saveFileDialog1.ShowDialog();
                string savePath = saveFileDialog1.FileName;
                File.WriteAllText(savePath, res.Text);
            }
        }
    }
}
