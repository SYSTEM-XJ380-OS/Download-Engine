using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net;

namespace For_fast_download_Engine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //制造加官方CEO亲自制作
            /*为快不破下载引擎的口号:
            当你勇敢地接纳自己的不完美，拥抱那些被自己视为"缺点",你的光芒会逐渐出现.*/
            this.Text = "For fast download Engine";
            string path = "c:/Trydownloading";
            if (!Directory.Exists(path))
            {
                String strInput = "data.bat";
                Process p = new Process();
                //设置要启动的应用程序
                p.StartInfo.FileName = "cmd.exe";
                //是否使用操作系统shell启动
                p.StartInfo.UseShellExecute = false;
                // 接受来自调用程序的输入信息
                p.StartInfo.RedirectStandardInput = true;
                //输出信息
                p.StartInfo.RedirectStandardOutput = true;
                // 输出错误
                p.StartInfo.RedirectStandardError = true;
                //不显示程序窗口
                p.StartInfo.CreateNoWindow = true;
                //启动程序
                p.Start();

                //向cmd窗口发送输入信息
                p.StandardInput.WriteLine(strInput + "&exit");

                p.StandardInput.AutoFlush = true;

                //获取输出信息
                string strOuput = p.StandardOutput.ReadToEnd();
                //等待程序执行完退出进程
                p.WaitForExit();
                p.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Start";
            label2.Text = "Language";
            button1.Text = "中文(简体)";
            button2.Text = "English(US) ";
            label3.Text = "Download";
            button3.Text = "Try downloading";
            label4.Text = "Note: The download file is in the directory C:/Trydownloading/";
            label5.Text = "Fliename";
            label6.Text = "Url";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Text = "为快不破下载引擎";
            label1.Text = "开始";
            label2.Text = "语言";
            label3.Text = "下载";
            button3.Text = "尝试下载";
            label4.Text = "注:下载文件在目录C:/Trydownloading/";
            label5.Text = "文件名";
            label6.Text = "Url";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Text = "For fast download Engine";
            label1.Text = "Start";
            label2.Text = "Language";
            label3.Text = "Download";
            button3.Text = "Try downloading";
            label4.Text = "Note: The download file is in the directory C:/Trydownloading/";
            label5.Text = "Fliename";
            label6.Text = "Url";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String q = textBox2.Text;
            String url = textBox1.Text;
            String ff = "C:\\Trydownloading";
            var wc = new WebClient();
            wc.DownloadFile(url, ff + "\\" + q);
            String b = "C:\\Trydownloading";
            String a = "start explorer " + b;
            Process p = new Process();
            //设置要启动的应用程序
            p.StartInfo.FileName = "cmd.exe";
            //是否使用操作系统shell启动
            p.StartInfo.UseShellExecute = false;
            // 接受来自调用程序的输入信息
            p.StartInfo.RedirectStandardInput = true;
            //输出信息
            p.StartInfo.RedirectStandardOutput = true;
            // 输出错误
            p.StartInfo.RedirectStandardError = true;
            //不显示程序窗口
            p.StartInfo.CreateNoWindow = true;
            //启动程序
            p.Start();

            //向cmd窗口发送输入信息
            p.StandardInput.WriteLine(a + "&exit");

            p.StandardInput.AutoFlush = true;

            //获取输出信息
            string strOuput = p.StandardOutput.ReadToEnd();
            //等待程序执行完退出进程
            p.WaitForExit();
            p.Close();
        }
    }
}
